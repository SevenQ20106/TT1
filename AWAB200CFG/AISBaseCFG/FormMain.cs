using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AISBaseCFG
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            //
	    //
            //
            InitBtnAtoNClick();
        }

        private static System.Timers.Timer Timer_1s;
        private void InitTimer()
        {
            Timer_1s = new System.Timers.Timer();
            Timer_1s.Interval = 1000;
            Timer_1s.Elapsed += Timer_1s_Elapsed;
            Timer_1s.AutoReset = true;
            Timer_1s.Enabled = true;
        }

        int iCount_10 = 0;

        private void Timer_1s_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (iCount_10 % 5 == 0)
            {
                iCount_10 = 0;
                SendHeartBeat();
            }
            iCount_10++;
        }

        private void 串口配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConn_Serialport frmSerialSet;
            if (connImpl != null && connImpl.CType == ConnType.Serial && connImpl.CStatus == ConnStatus.Started)
            {
                frmSerialSet = new FormConn_Serialport(connImpl as SerialImpl);
            }
            else
            {
                frmSerialSet = new FormConn_Serialport();
            }
            switch (frmSerialSet.ShowDialog())
            {
                case DialogResult.OK:
                    CreatSerialConn(frmSerialSet.comm);
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Ignore:
                    break;
            }

        }

        private void CreatSerialConn(SerialImpl serialConn)
        {
            ConnImpl conn = serialConn;
            conn.CName = "基站管理";
            conn.CType = ConnType.Serial;
            conn.CIO = DataDriection.IO;
            conn.onErrorReportHandle += OnErrorReport;
            HandleRst hr = conn.OnStart();
            switch (hr)
            {
                case HandleRst.Ok:
                    connImpl = conn;
                    connImpl.onStopHandle += OnStop;
                    connImpl.onRoute_OutEventHandle += DeCodeMsg;
                    connImpl.onRoute_OutEventHandle += ShowRecvData;
                    SetStatus();
                    SetBTNStatus(true);
                    InitQuery();
                    return;
                case HandleRst.Ignore:
                    MessageBox.Show(this, "串口已经被占用！");
                    return;
                case HandleRst.Error:
                    MessageBox.Show(this, "创建串口连接异常！");
                    return;
                default:
                    break;
            }
        }

        private void 网口连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitTimer();
            FormConn_TcpCli frmTcpCliSet = new FormConn_TcpCli();

            if (connImpl != null && connImpl.CType == ConnType.TcpCli && connImpl.CStatus == ConnStatus.Started)
            {
                frmTcpCliSet = new FormConn_TcpCli(connImpl as TcpCliImpl);
            }
            else
            {
                frmTcpCliSet = new FormConn_TcpCli();
            }
            if (frmTcpCliSet.ShowDialog() == DialogResult.OK)
            {
                ConnImpl conn = frmTcpCliSet.conn;
                conn.CName = "基站管理";
                conn.CType = ConnType.TcpCli;
                conn.CIO = DataDriection.IO;
                conn.onErrorReportHandle += OnErrorReport;
                (conn as TcpCliImpl).ConnectedServer += TCPCli_ConnectedServer;
                (conn as TcpCliImpl).DisConnectedServer += TCPCli_DisConnectedServer;
                connImpl = conn;
                HandleRst hr = conn.OnStart();
                if (hr == HandleRst.Error)
                {
                    MessageBox.Show(this, "创建网口连接异常！");
                    return;
                }
            }
        }

        private void TCPCli_DisConnectedServer(object sender, NetEventArgs e)
        {
            OnStop(connImpl as TcpCliImpl);
        }

        private void TCPCli_ConnectedServer(object sender, NetEventArgs e)
        {
            connImpl.onStopHandle += OnStop;
            connImpl.onRoute_OutEventHandle += DeCodeMsg;
            connImpl.onRoute_OutEventHandle += ShowRecvData;
            connImpl.CStatus = ConnStatus.Started;
            this.Invoke(new EventHandler(delegate
            {
                SetStatus();
            }));
            SendHeartBeat();
            SetBTNStatus(true);
            InitQuery();
        }

        private void SendHeartBeat()
        {
            if (connImpl != null && connImpl.CType == ConnType.TcpCli && connImpl.CStatus == ConnStatus.Started)
            {
                SendCMDToBase("!BEATHEART,*74\r\n");
            }

        }

        #region 变量定义
        List<string> listError = new List<string>();

        /// <summary>
        /// 基站对象
        /// </summary>
        public static BaseModel Bmodel = new BaseModel();

        ConnImpl connImpl;

        #endregion

        #region  解析接收报文
        private void DeCodeMsg(object obj, DTAEventArgs e)
        {
            foreach (var item in e.FrameArray)
            {
                //SendCMDToBase(item);
                string strHead = item.Substring(3, 3);
                switch (strHead)
                {
                    case "VER":
                        DeCodeVER(item);
                        break;
                    case "BCE":
                        DeCodeBCE(item);
                        break;
                    case "BCF":
                        DeCodeBCF(item);
                        break;
                    case "CAB":
                        DeCodeCAB(item);
                        break;
                    case "MTP":
                        DeCodeMTP(item);
                        break;
                    case "IPM":
                        DecodeIPM(item);
                        break;
                    case "ECB":
                        DeCodeECB(item);
                        break;
                    case "DLM":
                        DeCodeDLM(item);
                        break;
                    case "SPO":
                        DeCodeSPO(item);
                        break;
                    case "ATN":
                        DeCodeATN(item);
                        break;
                    default:
                        break;
                }
            }
        }

        #region General
        /// <summary>
        /// $ABVER,1,1,AB,AVIC,XiaoHeKou01,12345678,AWABS-200-V1.00,20140520,20131015*02
        /// </summary>
        /// <param name="strCMD"></param>
        private void DeCodeVER(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 11)
                {
                    return;
                }
                VER vermodel = new VER();
                vermodel.DeviceType = strArray[3];//AB
                vermodel.FacID = strArray[4];//AVIC
                vermodel.StationID = strArray[5];//XiaoHeKou01
                vermodel.DeviceNum = strArray[6];//12345678
                vermodel.ModelType = strArray[7];//AWABS-200-V1.00
                vermodel.SoftVersion = strArray[8];
                vermodel.HardVersion = strArray[9];

                SID sid = new SID();
                sid.UniqueID_Cur = vermodel.StationID;

                Bmodel.SidModel = sid;
                Bmodel.VerModel = vermodel;
                SendVERToForm(vermodel);
            }
            catch (Exception)
            {
                ShowError("DeCodeVER出错！");
            }
        }

        private void SendVERToForm(VER model)
        {
            if (model == null)
            {
                return;
            }
            if (txt_BaseNum.InvokeRequired)
            {
                txt_BaseNum.Invoke(new EventHandler(delegate { SendVERToForm(model); }));
            }
            else
            {
                txt_BaseNum.Text = model.StationID;
                txt_TalkerID.Text = model.DeviceType;
            }
        }

        private void DeCodeBCF(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 18)
                {
                    return;
                }
                BCF BCFModel = new BCF();
                BCFModel.MMSI = strArray[1];
                BCFModel.PositionSource = strArray[2];
                BCFModel.Latitude = strArray[3];
                BCFModel.NS = strArray[4];
                BCFModel.Longitude = strArray[5];
                BCFModel.EW = strArray[6];
                BCFModel.PositionAccuracy = strArray[7];
                BCFModel.RxA = strArray[8];
                BCFModel.RxB = strArray[9];
                BCFModel.TxA = strArray[10];
                BCFModel.TxB = strArray[11];
                BCFModel.PowerLevelA = strArray[12];
                BCFModel.PowerLevelB = strArray[13];
                BCFModel.MsgRetries = strArray[14];
                BCFModel.MsgRepeatIndicator = strArray[15];
                BCFModel.BaseTalkerID = strArray[16];
                if (Bmodel != null && Bmodel.SidModel != null)
                {
                    Bmodel.SidModel.MMSI_Cur = strArray[1];
                }
                SendBCFToForm(BCFModel);
            }
            catch (Exception)
            {
            }
        }

        private void SendBCFToForm(BCF model)
        {
            if (model == null)
            {
                return;
            }
            if (txt_MMSI.InvokeRequired)
            {
                txt_MMSI.Invoke(new EventHandler(delegate { SendBCFToForm(model); }));
            }
            else
            {
                txt_MMSI.Text = model.MMSI;
                txt_MsgRetires.Text = model.MsgRetries;
                txt_RepeatIndicator.Text = model.MsgRepeatIndicator;
                txt_RxA.Text = model.RxA;
                txt_RxB.Text = model.RxB;
                txt_TxA.Text = model.TxA;
                txt_TxB.Text = model.TxB;
                ckb_TxA_Powerlevel.Checked = model.PowerLevelA == "1" ? true : false;
                ckb_TxB_Powerlevel.Checked = model.PowerLevelB == "1" ? true : false;
                SelectedPositionSourcy(model.PositionSource);
                SendPosInfoToForm(model);
            }
        }

        private void SelectedPositionSourcy(string PosType)
        {
            switch (PosType)
            {
                case "0":
                    radioButton_Sur.Checked = true;
                    break;
                case "1":
                    radioButton_In.Checked = true;
                    break;
                case "2":
                    radioButton_Ex.Checked = true;
                    break;
                case "3":
                    radioButton_In_Sur.Checked = true;
                    break;
                case "4":
                    radioButton_In_Ex.Checked = true;
                    break;
                case "5":
                    radioButton_Ex_Sur.Checked = true;
                    break;
                case "6":
                    radioButton_Ex_In.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void SendPosInfoToForm(BCF model)
        {
            try
            {
                if (!string.IsNullOrEmpty(model.Longitude))
                {
                    txtLongDu.Text = model.Longitude.Substring(0, 3);
                    txtLongFen1.Text = model.Longitude.Substring(3, 2);
                    txtLongFen2.Text = model.Longitude.Substring(6, model.Longitude.Length - 6);
                }
                else
                {
                    txtLongDu.Text = "";
                    txtLongFen1.Text = "";
                    txtLongFen2.Text = "";
                }
                cbxEW.Text = model.EW;
                if (!string.IsNullOrEmpty(model.Latitude))
                {
                    txtLatDu.Text = model.Latitude.Substring(0, 2);
                    txtLatFen1.Text = model.Latitude.Substring(2, 2);
                    txtLatFen2.Text = model.Latitude.Substring(5, model.Latitude.Length - 5);
                }
                else
                {
                    txtLatDu.Text = "";
                    txtLatFen1.Text = "";
                    txtLatFen2.Text = "";
                }
                cbxSN.Text = model.NS;
                ckbPosAccuary.Checked = model.PositionAccuracy == "1" ? true : false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("经纬度格式解析出错！");
            }
        }

        private void DeCodeBCE(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 7)
                {
                    return;
                }
                BCE model = new BCE();
                model.BaseID = strArray[1];
                model.RATDMA = strArray[2];
                model.UTCSoure = strArray[3];
                model.ADSInterval = strArray[4];
                model.BlockControl = strArray[5];
                Bmodel.BCEModel = model;
                SendBCEToForm(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SendBCEToForm(BCE model)
        {
            if (model == null)
            {
                return;
            }
            if (txt_ADSInterval.InvokeRequired)
            {
                txt_ADSInterval.Invoke(new EventHandler(delegate { SendBCEToForm(model); }));
            }
            else
            {
                txt_BaseNum.Text = model.BaseID;
                txt_ADSInterval.Text = model.ADSInterval;
                ckb_RATDMA.Checked = model.RATDMA == "1" ? true : false;
            }
        }

        private void DeCodeCAB(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 6)
                {
                    return;
                }
                CAB model = new CAB();
                model.Tx_A = strArray[1];
                model.Tx_B = strArray[2];
                model.Reboot = strArray[3];
                model.Reset = strArray[4];

                SendCABToForm(model);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SendCABToForm(CAB model)
        {
            if (model == null)
            {
                return;
            }
            if (ckb_TxA_Enable.InvokeRequired)
            {
                ckb_TxA_Enable.Invoke(new EventHandler(delegate { SendCABToForm(model); }));
            }
            else
            {
                ckb_TxA_Enable.Checked = model.Tx_A == "1" ? true : false;
                ckb_TxB_Enable.Checked = model.Tx_B == "1" ? true : false;
            }
        }

        private void DeCodeMTP(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 3)
                {
                    return;
                }
                this.Invoke(new EventHandler(delegate
                {
                    if (strArray[1] == "A")
                    {
                        rbt_MTP_A.Checked = true;
                    }
                    if (strArray[2] == "B")
                    {
                        rbt_MTP_B.Checked = true;
                    }
                }));
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        #region  时隙分配
        private void DeCodeECB(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 12)
                {
                    return;
                }
                MsgTimeSlotCFG model = GetTSModel(strArray);
                switch (model.MsgType)
                {
                    case "4":
                        Bmodel.msg4 = model;
                        break;
                    case "17":
                        Bmodel.msg17 = model;
                        break;
                    case "20":
                        Bmodel.msg20 = model;
                        break;
                    case "22":
                        Bmodel.msg22 = model;
                        break;
                    case "23":
                        Bmodel.msg23 = model;
                        break;
                    default:
                        break;
                }
                SendECBToForm(model);
            }
            catch
            {
            }
        }

        private MsgTimeSlotCFG GetTSModel(string[] strArray)
        {
            MsgTimeSlotCFG model = new MsgTimeSlotCFG();
            model.BaseID = strArray[1];
            model.MsgType = strArray[2];
            model.ChAStartTime = strArray[3];
            model.ChAStartSlot = strArray[4];
            model.ChASlotInterval = strArray[5];
            model.ChASlotCounts = strArray[6];
            model.ChBStartTime = strArray[7];
            model.ChBStartSlot = strArray[8];
            model.ChBSlotInterval = strArray[9];
            model.ChBSlotCounts = strArray[10];

            return model;
        }

        private void SendECBToForm(MsgTimeSlotCFG model)
        {
            if (model == null)
            {
                return;
            }
            if (tPTimeSlot.InvokeRequired)
            {
                tPTimeSlot.Invoke(new EventHandler(delegate { SendECBToForm(model); }));
            }
            else
            {
                try
                {
                    string ChAStartTime = "txtChAStartTime" + model.MsgType;
                    string ChAStartSlot = "txtChAStartSlot" + model.MsgType;
                    string ChASlotInterval = "txtChASlotInterval" + model.MsgType;
                    string ChBStartTime = "txtChBStartTime" + model.MsgType;
                    string ChBStartSlot = "txtChBStartSlot" + model.MsgType;
                    string ChBSlotInterval = "txtChBSlotInterval" + model.MsgType;

                    TextBox txtChAStartTime = this.tPTimeSlot.Controls.Find(ChAStartTime, true)[0] as TextBox;
                    txtChAStartTime.Text = model.ChAStartTime;
                    TextBox txtChAStartSlot = this.tPTimeSlot.Controls.Find(ChAStartSlot, true)[0] as TextBox;
                    txtChAStartSlot.Text = model.ChAStartSlot;
                    ComboBox txtChASlotInterval = this.tPTimeSlot.Controls.Find(ChASlotInterval, true)[0] as ComboBox;
                    txtChASlotInterval.Text = model.ChASlotInterval;
                    TextBox txtChBStartTime = this.tPTimeSlot.Controls.Find(ChBStartTime, true)[0] as TextBox;
                    txtChBStartTime.Text = model.ChBStartTime;
                    TextBox txtChBStartSlot = this.tPTimeSlot.Controls.Find(ChBStartSlot, true)[0] as TextBox;
                    txtChBStartSlot.Text = model.ChBStartSlot;
                    ComboBox txtChBSlotInterval = this.tPTimeSlot.Controls.Find(ChBSlotInterval, true)[0] as ComboBox;
                    txtChBSlotInterval.Text = model.ChBSlotInterval;

                    if (model.MsgType == "17")
                    {
                        txtChASlotCounts17.Text = model.ChASlotCounts;
                        txtChBSlotCounts17.Text = model.ChBSlotCounts;
                    }
                    if (model.MsgType == "4")
                    {
                        txtChASlotInterval.Text = "750";
                        txtChBSlotInterval.Text = "750";
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        #endregion

        #region DLM
        private void DeCodeDLM(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 24)
                {
                    return;
                }
                int MsgId = 4 * int.Parse(strArray[1]);
                List<MsgDLM> listTemp = new List<MsgDLM>();
                listTemp = GetDLM(strArray);
                foreach (var item in listTemp)
                {
                    if (Bmodel.listDLM == null)
                    {
                        Bmodel.listDLM = listTemp;
                        break;
                    }
                    else
                    {
                        int iIndex = Bmodel.listDLM.FindIndex(model => model.MsgID == item.MsgID && model.Channel == item.Channel);
                        if (iIndex == -1)
                        {
                            Bmodel.listDLM.Add(item);
                        }
                        else
                        {
                            Bmodel.listDLM[iIndex] = item;
                        }
                    }
                }
                Invoke(new EventHandler(delegate
                {
                    if (MsgId == cbxDLMIndex.SelectedIndex)
                    {
                        SendDLMToForm();
                    }
                }));
            }
            catch
            {
                throw;
            }
        }

        private List<MsgDLM> GetDLM(string[] strArray)
        {
            List<MsgDLM> listTemp = new List<MsgDLM>();
            try
            {
                int MsgId = 4 * int.Parse(strArray[1]);
                string channel = strArray[2];
                for (int i = 0; i < 4; i++)
                {
                    MsgDLM model = new MsgDLM();
                    model.MsgID = (MsgId + i).ToString();
                    model.Channel = channel;
                    model.Owner = strArray[5 * i + 3];
                    model.StartSlot = strArray[5 * i + 4];
                    model.SlotCounts = strArray[5 * i + 5];
                    model.Timeout = strArray[5 * i + 6];
                    model.SlotIncrement = strArray[5 * i + 7];
                    listTemp.Add(model);
                }
                return listTemp;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void SendDLMToForm()
        {
            if (cbxDLMIndex.InvokeRequired)
            {
                Invoke(new EventHandler(delegate { SendDLMToForm(); }));
            }
            else
            {
                int i = cbxDLMIndex.SelectedIndex;
                List<MsgDLM> listTmp = Bmodel.listDLM.FindAll(model => int.Parse(model.MsgID) >= i && int.Parse(model.MsgID) < i + 4);
                foreach (var item in listTmp)
                {
                    SendDLMModleToForm(item);
                }
            }
        }

        private void SendDLMModleToForm(MsgDLM model)
        {
            if (tPDLM.InvokeRequired)
            {
                Invoke(new EventHandler(delegate { SendDLMModleToForm(model); }));
            }
            else
            {
                int MsgID = int.Parse(model.MsgID) % 4 + 1;
                string strChA = model.Channel;
                string stxt_StartSlot_Ch = "txt_StartSlot_Ch" + (model.Channel + MsgID.ToString());
                string scbx_Incerment_Ch = "cbx_Incerment_Ch" + (model.Channel + MsgID.ToString());
                string stxt_SlotCounts_Ch = "txt_SlotCounts_Ch" + (model.Channel + MsgID.ToString());
                string scbx_Owner_Ch = "cbx_Owner_Ch" + (model.Channel + MsgID.ToString());
                string stxt_TimeOut_Ch = "txt_TimeOut_Ch" + (model.Channel + MsgID.ToString());
                TextBox txt_StartSlot_Ch = this.tPDLM.Controls.Find(stxt_StartSlot_Ch, true)[0] as TextBox;
                ComboBox cbx_Incerment_Ch = this.tPDLM.Controls.Find(scbx_Incerment_Ch, true)[0] as ComboBox;
                TextBox txt_SlotCounts_Ch = this.tPDLM.Controls.Find(stxt_SlotCounts_Ch, true)[0] as TextBox;
                ComboBox cbx_Owner_Ch = this.tPDLM.Controls.Find(scbx_Owner_Ch, true)[0] as ComboBox;
                TextBox txt_TimeOut_Ch = this.tPDLM.Controls.Find(stxt_TimeOut_Ch, true)[0] as TextBox;

                txt_StartSlot_Ch.Text = model.StartSlot;
                cbx_Incerment_Ch.Text = model.SlotIncrement;
                txt_SlotCounts_Ch.Text = model.SlotCounts;
                cbx_Owner_Ch.Text = GetOwer_CH(model.Owner);
                txt_TimeOut_Ch.Text = model.Timeout;
            }
        }

        private string GetOwer_CH(string OwnerShip)
        {
            switch (OwnerShip)
            {
                case "C":
                    return "Clear";
                case "L":
                    return "Local";
                case "R":
                    return "Remote";
            }
            return "";
        }

        private void cbxDLMIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            SendDLMToForm();
        }

        #endregion

        #region VSI\FSR
        private void DeCodeSPO(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 16)
                {
                    return;
                }
                SPO model = new SPO();
                model.BaseID = strArray[1];
                model.SelectChannel = strArray[2];
                model.RecvSingalStrengthVDL = strArray[3];
                model.FisrtSlotNumForFirstRecvMsg = strArray[4];
                model.TimeOfMsgArrival = strArray[5];
                model.SingalToNoiseRatio = strArray[6];
                model.PreFrameCHLoad = strArray[7];
                model.NumOfBadCRC = strArray[8];
                model.ForecastCHLoad = strArray[9];
                model.AverageNoiseLevel = strArray[10];
                model.RecvSingalStrength = strArray[11];
                model.ProVSISens4VDM = strArray[12];
                model.ProVSISens4VDO = strArray[13];
                model.ProFSRSens = strArray[14];
                SendSPOToFrom(model);
            }
            catch
            {
                ShowError("解析SPO报文出错");
            }
        }

        private void SendSPOToFrom(SPO model)
        {
            if (cbx_SPO_Channel.InvokeRequired)
            {
                Invoke(new EventHandler(delegate { SendSPOToFrom(model); }));
            }
            else
            {
                cbx_SPO_Channel.SelectedIndex = GetSPOChannelIndex(model.SelectChannel);

                ckb_VSI4VDM.Checked = model.ProVSISens4VDM == "1" ? true : false;
                ckb_VSI4VDO.Checked = model.ProVSISens4VDO == "1" ? true : false;
                ckb_SingalStrength.Checked = model.RecvSingalStrengthVDL == "1" ? true : false;
                ckb_FisrtSlotNumForFirstRecvMsg.Checked = model.FisrtSlotNumForFirstRecvMsg == "1" ? true : false;
                ckb_TimeOfMsgArrival.Checked = model.TimeOfMsgArrival == "1" ? true : false;

                ckb_ProFSRSens.Checked = model.ProFSRSens == "1" ? true : false;
                ckb_PreFrameCHLoad.Checked = model.PreFrameCHLoad == "1" ? true : false;
                ckb_NumOfBadCRC.Checked = model.NumOfBadCRC == "1" ? true : false;
                ckb_ForecastCHLoad.Checked = model.ForecastCHLoad == "1" ? true : false;
                ckb_AverageNoiseLevel.Checked = model.AverageNoiseLevel == "1" ? true : false;
                ckb_RecvSingalStrength.Checked = model.RecvSingalStrength == "1" ? true : false;
            }

        }

        private int GetSPOChannelIndex(string Ch)
        {
            switch (Ch)
            {
                case "A":
                    return 0;
                case "B":
                    return 1;
                case "E":
                    return 2;
                case "N":
                    return 3;
                default:
                    return -1;
            }
        }

        #endregion

        #region 虚拟航标
        int AtoN_SelectedIndex = -1;

        private void DeCodeATN(string strCMD)
        {
            try
            {
                string[] strArray = strCMD.Split(new char[] { ',', '*' });
                if (strArray.Length != 26)
                {
                    return;
                }
                ATN modelTemp = GetATN(strArray);
                if (Bmodel.listATN == null)
                {
                    Bmodel.listATN = new List<ATN>();
                    Bmodel.listATN.Add(modelTemp);
                }
                else
                {
                    int iIndex = Bmodel.listATN.FindIndex(model => model.Seq == modelTemp.Seq);
                    if (iIndex == -1)
                    {
                        Bmodel.listATN.Add(modelTemp);
                    }
                    else
                    {
                        Bmodel.listATN[iIndex] = modelTemp;
                    }
                }
                Invoke(new EventHandler(delegate
                {
                    if (modelTemp.Enable == "1")
                    {
                        SetATNBtnStatus(int.Parse(modelTemp.Seq) + 1, Color.Green);
                    }
                    else
                    {
                        SetATNBtnStatus(int.Parse(modelTemp.Seq) + 1, Color.Transparent);
                    }

                    if (AtoN_SelectedIndex == int.Parse(modelTemp.Seq))
                    {
                        SendATNToPage(modelTemp);
                    }
                }));
            }
            catch
            {
                throw;
            }
        }


        private void SetATNBtnStatus(int seq, Color BackColor)
        {
            string ctrbtnAtoN = "btn_AtoN_" + seq;
            Button btnAtoN = this.tPVtoN.Controls.Find(ctrbtnAtoN, true)[0] as Button;
            if (btnAtoN != null)
            {
                btnAtoN.BackColor = BackColor;
                btnAtoN.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private void SetATNBtnBorder(int seq, Color BackColor)
        {
            for (int i = 1; i < 33; i++)
            {
                if (i == seq)
                {
                    continue;
                }
                Button btn = this.tPVtoN.Controls.Find("btn_AtoN_" + i, true)[0] as Button;
                btn.FlatAppearance.BorderColor = Color.Black;
            }
            Button btnSelected = this.tPVtoN.Controls.Find("btn_AtoN_" + seq, true)[0] as Button;
            btnSelected.FlatAppearance.BorderColor = BackColor;
        }

        private void txt_AtoN_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char KeyChar = e.KeyChar;
            int TextLength = ((TextBox)sender).TextLength;
            if ((KeyChar <= 0x5F && KeyChar >= 0x40) || (KeyChar <= 0x3F && KeyChar >= 0x20))
            {
                if ((((TextBox)sender).SelectedText.Length == TextLength) && (TextLength > 0))
                {
                    e.Handled = false;
                    return;
                }
            }
            else
            {   // 回删操作
                if (KeyChar == '\b')
                {
                    if (TextLength == 0)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_AtoN_Name_TextChanged(object sender, EventArgs e)
        {
            string str = txt_AtoN_Name.Text.Trim();
            for (int i = 0; i < str.Length; i++)
            {
                char KeyChar = str[i];
                if ((KeyChar <= 0x5F && KeyChar >= 0x40) || (KeyChar <= 0x3F && KeyChar >= 0x20))
                {
                    continue;
                }
                else
                {
                    MessageBox.Show("有非规则字符" + str[i] + ",请检查后重新输入");
                    return;
                }
            }
        }

        private void ckb_AtoN_VirtualATN_CheckedChanged(object sender, EventArgs e)
        {
            bool bChecked = ckb_AtoN_VirtualATN.Checked;
            this.txtSizeA.Enabled = !bChecked;
            this.txtSizeB.Enabled = !bChecked;
            this.txtSizeC.Enabled = !bChecked;
            this.txtSizeD.Enabled = !bChecked;
            if (bChecked)
            {
                this.txtSizeA.Text = "0";
                this.txtSizeB.Text = "0";
                this.txtSizeC.Text = "0";
                this.txtSizeD.Text = "0";
            }
        }

        private ATN GetATN(string[] strArray)
        {
            ATN Model = new ATN();
            try
            {
                Model.Seq = strArray[1];
                Model.Enable = strArray[2];
                Model.StartSlotA = strArray[3];
                Model.SendIntervalA = strArray[4];
                //Model.StartSlotB = strArray[3];
                //Model.SendIntervalB = strArray[4];
                Model.MMSI = strArray[5];
                Model.Type = strArray[6];
                Model.Name = strArray[7];
                Model.PosAccuracy = strArray[8];
                Model.Latitude = strArray[9];
                Model.NS = strArray[10];
                Model.Longitude = strArray[11];
                Model.EW = strArray[12];
                Model.Size_A = strArray[13];
                Model.Size_B = strArray[14];
                Model.Size_C = strArray[15];
                Model.Size_D = strArray[16];
                Model.PosDeviceType = strArray[17];
                Model.TimeStamp = strArray[18];
                Model.OffPos_Indicator = strArray[19];
                Model.AtoNStatus = strArray[20];
                Model.RAIM_Flag = strArray[21];
                Model.Virtual_AtoN_Flag = strArray[22];
                Model.Assigned_Model_Flag = strArray[23];
                Model.Spare = strArray[24];

                return Model;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void SendATNToPage(ATN model)
        {
            try
            {
                if (int.Parse(model.Seq) != AtoN_SelectedIndex)
                {
                    return;
                }
                if (txt_AtoN_MMSI.InvokeRequired)
                {
                    Invoke(new EventHandler(delegate { SendATNToPage(model); }));
                }
                else
                {
                    ckb_AtoN_Enable.Checked = model.Enable == "1" ? true : false;
                    txt_AtoN_MMSI.Text = model.MMSI;

                    try
                    {
                        cbxAtoNType.SelectedIndex = int.Parse(model.Type);
                    }
                    catch (Exception)
                    {
                        cbxAtoNType.SelectedIndex = 0;
                    }
                    txt_AtoN_Name.Text = model.Name;
                    try
                    {
                        cbx_AtoN_PosDeviceType.SelectedIndex = int.Parse(model.PosDeviceType);
                    }
                    catch (Exception)
                    {
                        cbx_AtoN_PosDeviceType.SelectedIndex = 0;
                    }
                    txt_ATN_StartSlotChA.Text = model.StartSlotA;
                    txt_AtoN_SendIntervalChA.Text = model.SendIntervalA;
                    //txt_ATN_StartSlotChB.Text = model.StartSlotB;
                    //txt_AtoN_SendIntervalChB.Text = model.SendIntervalB;
                    txt_AtoN_TimeStamp.Text = model.TimeStamp;
                    txt_ATN_UpdateTime.Text = "";//??
                    ckb_AtoN_VirtualATN.Checked = model.Virtual_AtoN_Flag == "1" ? true : false;
                    ckb_ATN_PosAccuray.Checked = model.PosAccuracy == "1" ? true : false;
                    ckb_ATN_OffPos.Checked = model.OffPos_Indicator == "1" ? true : false;
                    ckb_ATN_RAIM_Flag.Checked = model.RAIM_Flag == "1" ? true : false;
                    ckb_ATN_SingedMode.Checked = model.Assigned_Model_Flag == "1" ? true : false;
                    SendATNPosToForm(model);
                    txtSizeA.Text = model.Size_A;
                    txtSizeB.Text = model.Size_B;
                    txtSizeC.Text = model.Size_C;
                    txtSizeD.Text = model.Size_D;
                }
            }
            catch (Exception)
            {
            }
        }

        private void SendATNPosToForm(ATN model)
        {
            try
            {
                if (!string.IsNullOrEmpty(model.Longitude))
                {
                    txt_ATN_LongDu.Text = model.Longitude.Substring(0, 3);
                    txt_ATN_LongFen.Text = model.Longitude.Substring(3, 2);
                    txt_ATN_LongSeconds.Text = model.Longitude.Substring(6, model.Longitude.Length - 6);
                }
                else
                {
                    txt_ATN_LongDu.Text = "";
                    txt_ATN_LongFen.Text = "";
                    txt_ATN_LongSeconds.Text = "";
                }
                ckb_ATN_EW.Text = model.EW;
                if (!string.IsNullOrEmpty(model.Latitude))
                {
                    txt_ATN_LatDu.Text = model.Latitude.Substring(0, 2);
                    txt_ATN_LatFen.Text = model.Latitude.Substring(2, 2);
                    txt_ATN_LatSecond.Text = model.Latitude.Substring(5, model.Latitude.Length - 5);
                }
                else
                {
                    txt_ATN_LatDu.Text = "";
                    txt_ATN_LatFen.Text = "";
                    txt_ATN_LatSecond.Text = "";
                }
                ckb_ATN_NS.Text = model.NS;
            }
            catch (Exception)
            {
                MessageBox.Show("经纬度格式解析出错！");
            }
        }

        private void ckb_AtoN_Enable_CheckedChanged(object sender, EventArgs e)
        {
            pAtoN.Enabled = ckb_AtoN_Enable.Checked;
        }
        #endregion


        #endregion

        #region 公用串口操作

        private void SendCMDToBase(string cmd)
        {
            try
            {
                if (connImpl != null)
                {
                    DTAEventArgs e = new DTAEventArgs();
                    e.FrameArray = new string[] { cmd };
                    connImpl.OnRecvRouteDataEventHandle((IntPtr)connImpl.GetHashCode(), e);
                    ShowSendData(cmd);
                }
            }
            catch (Exception ex)
            {
                ShowError("SendCMDToBase:" + ex.ToString());
            }
        }

        private void ShowError()
        {
            if (listError != null && listError.Count > 0)
            {
                string showMsg = "";
                for (int i = 0; i < listError.Count; i++)
                {
                    showMsg += listError[i];
                }
                MessageBox.Show(showMsg);
            }
        }

        private void ShowError(string errorMsg)
        {
            MessageBox.Show(errorMsg);
        }

        private void OnErrorReport(object obj, int errorCode, string errorMsg)
        {
            try
            {
                ConnImpl conn = obj as ConnImpl;
                switch (conn.CType)
                {
                    case ConnType.Serial:
                        this.Invoke((EventHandler)(delegate
                        {
                            ShowError(errorMsg);
                        }));
                        break;
                    default:
                        break;
                }
                MessageBox.Show(errorMsg, errorCode.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void OnStop(object obj)
        {
            try
            {
                ConnImpl conn = obj as ConnImpl;
                switch (conn.CType)
                {
                    case ConnType.Serial:
                        break;
                    case ConnType.TcpCli:
                        Timer_1s.Enabled = false;
                        (connImpl as TcpCliImpl).ConnectedServer -= TCPCli_ConnectedServer;
                        (connImpl as TcpCliImpl).DisConnectedServer -= TCPCli_DisConnectedServer;
                        break;
                    default:
                        break;
                }
                connImpl.onErrorReportHandle -= OnErrorReport;
                connImpl.onStopHandle -= OnStop;
                connImpl.onRoute_OutEventHandle -= DeCodeMsg;
                connImpl.onRoute_OutEventHandle -= ShowRecvData;
                connImpl = null;
                this.Invoke(new EventHandler(delegate
                {
                    SetStatus();
                }));

                SetBTNStatus(false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void SetBTNStatus(bool bFlag)
        {
            if (btn_QueryCMD.InvokeRequired)
            {
                btn_QueryCMD.Invoke(new EventHandler(delegate { SetBTNStatus(bFlag); }));
            }
            else
            {
                btn_QueryCMD.Enabled = bFlag;
                btn_SetCMD.Enabled = bFlag;
            }
        }

        #endregion

        #region 查询操作

        private void btn_QueryCMD_Click(object sender, EventArgs e)
        {
            SendQueryCMD();
        }
        private void SendQueryCMD()
        {
            int iIndex = TabControlALL.SelectedIndex;
            switch (iIndex)
            {
                case 0:
                    SendGeneralQuery();
                    break;
                case 1:
                    ClearAll();
                    SendNetQuery();
                    break;
                case 2:
                    SendTimeSlotMgtQuery();
                    break;
                case 3:
                    SendDataLinkMgtQuery();
                    break;
                case 4:
                    SendVSIFSRMgtQuery();
                    break;
                case 5:
                    SendAtoNQuery();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 基本配置查询
        /// </summary>
        private void SendGeneralQuery()
        {
            //	$xxABQ,VER*hh
            //	$xxABQ,BCF* hh
            string strABQ = "$xxABQ,VER";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
            strABQ = "$xxABQ,BCF";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
            strABQ = "$xxABQ,BCE";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
            strABQ = "$xxABQ,CAB";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
            strABQ = "$xxABQ,MTP";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
        }


        /// <summary>
        /// 时隙分配查询
        /// </summary>
        private void SendTimeSlotMgtQuery()
        {
            string strABQ = "$xxABQ,ECB";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
        }

        /// <summary>
        /// 数据链路管理
        /// </summary>
        private void SendDataLinkMgtQuery()
        {
            string strABQ = "$xxABQ,DLM";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
        }

        /// <summary>
        /// VSI　FSR语句查询管理
        /// </summary>
        private void SendVSIFSRMgtQuery()
        {
            string strABQ = "$xxABQ,SPO";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
        }
        private void SendAtoNQuery()
        {
            string strABQ = "$xxABQ,ATN";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
        }

        private void InitBtnAtoNClick()
        {
            for (int i = 1; i <= 32; i++)
            {
                Button btn = this.tPVtoN.Controls.Find("btn_AtoN_" + i, true)[0] as Button;
                btn.Click += new System.EventHandler(this.btn_AtoN_Click);
            }
        }

        private void btn_AtoN_Click(object sender, EventArgs e)
        {
            Button btn = (sender as Button);
            int iTemp = int.Parse(btn.Text);
            AtoN_SelectedIndex = iTemp - 1;
            SetATNBtnBorder(iTemp, Color.Red);
            if (Bmodel != null && Bmodel.listATN != null && Bmodel.listATN.Count >= iTemp)
            {
                int iIndex = Bmodel.listATN.FindIndex(model => model.Seq == AtoN_SelectedIndex.ToString("00"));
                if (iIndex != -1)
                {
                    ATN model = Bmodel.listATN[iIndex];
                    if (model != null)
                    {
                        SendATNToPage(model);
                    }
                }
            }
        }

        private void InitBtnAtoNStyle(int iTemp)
        {
            for (int i = 1; i < 33; i++)
            {
                if (i == iTemp)
                {
                    continue;
                }
                Button btn = this.tPVtoN.Controls.Find("btn_AtoN_" + i, true)[0] as Button;
                btn.BackColor = Color.Transparent;
            }
            Button btnSelected = this.tPVtoN.Controls.Find("btn_AtoN_" + iTemp, true)[0] as Button;
            btnSelected.BackColor = Color.ForestGreen;
        }

        private void SendAGAQuery()
        {
            string strABQ = "$xxABQ,AGA";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
        }

        private void SendACAQuery()
        {
            string strABQ = "$xxABQ,ACA";
            strABQ += CommHelp.Get0xHH(strABQ);
            SendCMDToBase(strABQ);
        }

        #endregion

        #region 界面变量显示
        private void SetStatus()
        {
            if (connImpl == null)
            {
                this.tsslConnMode.BackColor = Color.Red;
                this.tsslConnMode.Text = "未连接";
                this.tsslConnStatus.Text = "";
                this.网口连接ToolStripMenuItem.Enabled = true;
                this.串口配置ToolStripMenuItem.Enabled = true;
                return;
            }
            switch (connImpl.CType)
            {
                case ConnType.Serial:
                    this.网口连接ToolStripMenuItem.Enabled = false;
                    this.tsslConnMode.BackColor = Color.Green;
                    this.tsslConnMode.Text = "串口连接";
                    this.tsslConnStatus.Text = connImpl.GetConnDesc();
                    break;
                case ConnType.TcpCli:
                    this.串口配置ToolStripMenuItem.Enabled = false;
                    this.tsslConnMode.BackColor = Color.Green;
                    this.tsslConnMode.Text = "TCP客户端连接";
                    this.tsslConnStatus.Text = connImpl.GetConnDesc();
                    break;
                case ConnType.TcpSvr:
                    break;
                case ConnType.Udp:
                    break;
                case ConnType.Session:
                    break;
                default:
                    break;
            }
        }

        private void ShowRecvData(object obj, DTAEventArgs e)
        {
            try
            {
                foreach (var item in e.FrameArray)
                {
                    if (showMsgHandle != null)
                    {
                        showMsgHandle(System.DateTime.Now.ToString("HH:mm:ss.fff") + "[<<---]:" + item);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("ShowRecvData:" + ex.ToString());
            }
        }

        private void ShowSendData(string item)
        {
            try
            {
                if (showMsgHandle != null)
                {
                    showMsgHandle(System.DateTime.Now.ToString("HH:mm:ss.fff") + "[--->>]:" + item);
                }
            }
            catch (Exception ex)
            {
                ShowError("ShowSendData:" + ex.ToString());
            }
        }

        #endregion

        private void btn_SetCMD_Click(object sender, EventArgs e)
        {
            int iIndex = TabControlALL.SelectedIndex;
            switch (iIndex)
            {
                case 0:
                    SendSID();
                    SendBCF();
                    SendBCE();
                    SendCAB();
                    break;
                case 1:
                    SendIPM();
                    break;
                case 2:
                    SendTimeSlot();
                    break;
                case 3:
                    SendDataLinkMgt();
                    break;
                case 4:
                    SendVSIFSRMgt();
                    break;
                case 5:
                    SendAtoN();
                    break;
                default:
                    break;
            }
        }

        #region 基本配置

        #region  SID
        private bool CheckSID()
        {
            listError.Clear();
            uint uMMSI;
            bool bFlag;
            bFlag = uint.TryParse(txt_MMSI.Text.Trim(), out uMMSI);
            if (!bFlag)
            {
                listError.Add("MMSI只能是不超过9位长度的数字组成！\r\n");
            }
            bFlag = RegexName(txt_BaseNum.Text.Trim());
            if (!bFlag)
            {
                listError.Add("基站编号只能是长度不小于15的字母(a~z A~Z)数字(0~9)符号（_ -）组成！\r\n");
            }
            if (listError != null && listError.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool RegexName(string str)
        {
            bool flag = Regex.IsMatch(str, @"^[a-zA-Z0-9_-]*$");
            return flag;
        }

        private string EnCodeSID()
        {
            if (!CheckSID())
            {
                ShowError();
                return "";
            }
            try
            {
                if (Bmodel.SidModel == null)
                {
                    ShowError("请先查询基站配置后再进行设置操作！");
                    return "";
                }
                SID sid = new SID();
                sid = Bmodel.SidModel;
                //基站编号
                string newUnID = txt_BaseNum.Text.Trim();
                if (Bmodel.SidModel.UniqueID_Cur == newUnID)
                {
                    sid.UniqueID_New = "";
                }
                else
                {
                    sid.UniqueID_New = newUnID;
                }
                //MMSI
                string uMMSI = txt_MMSI.Text.Trim();
                if (uMMSI == Bmodel.SidModel.MMSI_Cur)
                {
                    sid.MMSI_Cur = uMMSI;
                    sid.MMSI_New = uMMSI;
                }
                else
                {
                    sid.MMSI_New = uMMSI;
                }
                return sid.GetSidCmd();
            }
            catch (Exception)
            {
                ShowError("EnCodeSID出错！");
                return "";
            }
        }

        private void SendSID()
        {
            string CMD = EnCodeSID();
            if (CMD == "")
            {
                return;
            }
            SendCMDToBase(CMD);
        }

        #endregion

        #region BCF
        private bool CheckBCF()
        {
            listError.Clear();
            uint uMMSI;
            bool bFlag;
            bFlag = uint.TryParse(txt_MMSI.Text.Trim(), out uMMSI);
            if (!bFlag)
            {
                listError.Add("MMSI只能是不超过9位长度的数字组成！\r\n");
            }
            CheckBasePostion();
            if (!uint.TryParse(txt_MsgRetires.Text.Trim(), out uMMSI))
            {
                listError.Add("消息重复数应由数据组成！\r\n");
            }
            if (!uint.TryParse(txt_RepeatIndicator.Text.Trim(), out uMMSI))
            {
                listError.Add("消息转发指示应由数据组成！\r\n");
            }
            if (listError != null && listError.Count > 0)
            {
                return false;
            }
            return true;
        }

        private void CheckBasePostion()
        {
            //经度
            if (!string.IsNullOrEmpty(txtLongDu.Text.Trim()) || !string.IsNullOrEmpty(txtLongFen1.Text.Trim()) || !string.IsNullOrEmpty(txtLongFen2.Text.Trim()))
            {
                if (string.IsNullOrEmpty(cbxEW.Text.Trim()))
                {
                    listError.Add("请确定选择东西经！\r\n");
                }
                uint LongDu = 0;
                if (!string.IsNullOrEmpty(txtLongDu.Text.Trim()))
                {
                    if (!uint.TryParse(txtLongDu.Text.Trim(), out LongDu))
                    {
                        listError.Add("经度的度取值范围是【0~180】{181为默认值不可用}！\r\n");
                    }
                    else if (LongDu > 181)
                    {
                        listError.Add("经度的度取值范围是【0~180】{181为默认值不可用}！\r\n");
                    }
                }
                uint LongFen = 0;
                if (!string.IsNullOrEmpty(txtLongFen1.Text.Trim()))
                {
                    if (!uint.TryParse(txtLongFen1.Text.Trim(), out LongFen))
                    {
                        listError.Add("经度的分整数取值范围是【0~59】！\r\n");
                    }
                    else if (LongFen > 59)
                    {
                        listError.Add("经度的分整数取值范围是【0~59】！\r\n");
                    }
                }
                double LongSeconds = 0;
                if (!string.IsNullOrEmpty(txtLongFen2.Text.Trim()))
                {
                    if (!double.TryParse(txtLongFen2.Text.Trim(), out LongSeconds))
                    {
                        listError.Add("经度的分小数取值范围是【0~9999】！\r\n");
                    }
                    else if (LongSeconds > 9999)
                    {
                        listError.Add("经度的分小数取值范围是【0~9999】！\r\n");
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtLatDu.Text.Trim()) || !string.IsNullOrEmpty(txtLatFen1.Text.Trim()) || !string.IsNullOrEmpty(txtLatFen2.Text.Trim()))
            {
                //纬度
                uint LatDu = 0;
                if (!string.IsNullOrEmpty(txtLatDu.Text.Trim()))
                {
                    if (!uint.TryParse(txtLatDu.Text.Trim(), out LatDu))
                    {
                        listError.Add("纬度的度取值范围是【0~90】{91为默认值不可用}！\r\n");
                    }
                    else if (LatDu > 91)
                    {
                        listError.Add("纬度的度取值范围是【0~90】{91为默认值不可用}！\r\n");
                    }
                }
                uint LatFen = 0;
                if (!string.IsNullOrEmpty(txtLatFen1.Text.Trim()))
                {
                    if (!uint.TryParse(txtLatFen1.Text.Trim(), out LatFen))
                    {
                        listError.Add("纬度的分整数取值范围是【0~59】！\r\n");
                    }
                    else if (LatFen > 59)
                    {
                        listError.Add("纬度的分整数取值范围是【0~59】！\r\n");
                    }
                }
                int LatSeconds = 0;
                if (!string.IsNullOrEmpty(txtLatFen2.Text.Trim()))
                {
                    if (!int.TryParse(txtLatFen2.Text.Trim(), out LatSeconds))
                    {
                        listError.Add("纬度的分小数取值范围是【0~9999】！\r\n");
                    }
                    else if (LatSeconds > 9999)
                    {
                        listError.Add("纬度的分小数取值范围是【0~9999】！\r\n");
                    }
                }
                if (string.IsNullOrEmpty(cbxSN.Text.Trim()))
                {
                    listError.Add("请确定选择南北纬！\r\n");
                }
            }
        }

        private string EnCodeBCF()
        {
            if (!CheckBCF())
            {
                ShowError();
                return "";
            }
            try
            {
                if (Bmodel.SidModel == null)
                {
                    ShowError("请先查询基站配置后再进行设置操作！");
                    return "";
                }
                BCF bcf = new BCF();
                bcf.MMSI = txt_MMSI.Text.Trim();
                bcf.PositionSource = GetPostionSource().ToString();
                bcf.Longitude = GetPostionToDuFen(txtLongDu.Text.Trim(), txtLongFen1.Text.Trim(), txtLongFen2.Text.Trim(), "Long");
                bcf.EW = cbxEW.Text;
                bcf.Latitude = GetPostionToDuFen(txtLatDu.Text.Trim(), txtLatFen1.Text.Trim(), txtLatFen2.Text.Trim(), "Lat");
                bcf.NS = cbxSN.Text;
                bcf.PositionAccuracy = ckbPosAccuary.Checked ? "1" : "0";
                bcf.RxA = int.Parse(txt_RxA.Text.Trim()).ToString();
                bcf.RxB = int.Parse(txt_RxB.Text.Trim()).ToString();
                bcf.TxA = int.Parse(txt_TxA.Text.Trim()).ToString();
                bcf.TxB = int.Parse(txt_TxB.Text.Trim()).ToString();
                bcf.PowerLevelA = ckb_TxA_Powerlevel.Checked ? "1" : "0";
                bcf.PowerLevelB = ckb_TxB_Powerlevel.Checked ? "1" : "0";
                bcf.MsgRetries = int.Parse(txt_MsgRetires.Text.Trim()).ToString();
                bcf.MsgRepeatIndicator = txt_RepeatIndicator.Text;
                bcf.BaseTalkerID = txt_TalkerID.Text.Trim();
                return bcf.GetBCFCmd();
            }
            catch (Exception ex)
            {
                ShowError("EnCodeBCF出错！");
                return "";
            }
        }

        private string GetPostionToDuFen(string Du, string Fen1, string Fen2, string LongOrLat)
        {
            if (string.IsNullOrEmpty(Du) && string.IsNullOrEmpty(Fen1) && string.IsNullOrEmpty(Fen2))
            {
                return "";
            }
            string strPos = "";
            switch (LongOrLat)
            {
                case "Long":
                    if (string.IsNullOrEmpty(Du))
                    {
                        strPos += "000";
                    }
                    else
                    {
                        strPos += Du.PadLeft(3, '0');
                    }
                    break;
                case "Lat":
                    if (string.IsNullOrEmpty(Du))
                    {
                        strPos += "00";
                    }
                    else
                    {
                        strPos += Du.PadLeft(2, '0');
                    }
                    break;
                default:
                    break;
            }
            if (string.IsNullOrEmpty(Fen1))
            {
                strPos += "00";
            }
            else
            {
                strPos += Fen1.PadLeft(2, '0');
            }
            if (string.IsNullOrEmpty(Fen2))
            {
                strPos += ".0000";
            }
            else
            {
                strPos += "." + Fen2.PadRight(4, '0');
            }
            return strPos;
        }

        private string GetPostionToDuFen(int Du, int Fen, double Seconds, string LongOrLat)
        {
            string strPos = "";
            switch (LongOrLat)
            {
                case "Long":
                    double dFen2 = (Seconds / 60);
                    strPos = Du.ToString().PadLeft(3, '0') + Fen.ToString().PadLeft(2, '0') + dFen2.ToString("f2").Substring(1).PadRight(2, '0');
                    break;
                case "Lat":
                    strPos = Du.ToString().PadLeft(2, '0') + Fen.ToString().PadLeft(2, '0') + (Seconds / 60).ToString("f2").Substring(1).PadRight(2, '0');
                    break;
                default:
                    break;
            }
            return strPos;
        }

        private int GetPostionSource()
        {
            if (radioButton_Sur.Checked)
            {
                return 0;
            }
            if (radioButton_In.Checked)
            {
                return 1;
            }
            if (radioButton_Ex.Checked)
            {
                return 2;
            }
            if (radioButton_In_Sur.Checked)
            {
                return 3;
            }
            if (radioButton_In_Ex.Checked)
            {
                return 4;
            }
            if (radioButton_Ex_Sur.Checked)
            {
                return 5;
            }
            if (radioButton_Ex_In.Checked)
            {
                return 6;
            }
            return 0;
        }

        private void SendBCF()
        {
            string CMD = EnCodeBCF();
            if (CMD == "")
            {
                return;
            }
            SendCMDToBase(CMD);
        }

        #endregion

        #region BCE
        private bool CheckBCE()
        {
            listError.Clear();
            bool bFlag;
            bFlag = RegexName(txt_BaseNum.Text.Trim());
            if (!bFlag)
            {
                listError.Add("基站编号只能是长度不小于15的字母(a~z A~Z)数字(0~9)符号（_ -）组成！\r\n");
            }
            int iTemp;
            bFlag = int.TryParse(txt_ADSInterval.Text.Trim(), out iTemp);
            if (!bFlag)
            {
                listError.Add("ADS报告间隔格式有误，只能是数字！\r\n");
            }

            if (listError != null && listError.Count > 0)
            {
                return false;
            }
            return true;
        }

        private string EnCodeBCE()
        {
            if (!CheckBCE())
            {
                ShowError();
                return "";
            }
            try
            {
                if (Bmodel.SidModel == null)
                {
                    ShowError("请先查询基站配置后再进行设置操作！");
                    return "";
                }
                BCE bce = new BCE();
                bce = Bmodel.BCEModel;
                //基站编号
                bce.BaseID = txt_BaseNum.Text.Trim();
                bce.RATDMA = ckb_RATDMA.Checked ? "1" : "0";
                bce.UTCSoure = "I";//无选择项目，默认
                bce.ADSInterval = uint.Parse(txt_ADSInterval.Text.Trim()).ToString();
                bce.BlockControl = "0";
                return bce.GetCMD();
            }
            catch (Exception)
            {
                ShowError("EnCodeBCE出错！");
                return "";
            }
        }

        private void SendBCE()
        {
            string CMD = EnCodeBCE();
            if (CMD == "")
            {
                return;
            }
            SendCMDToBase(CMD);
        }

        #endregion

        #region CAB

        private string EnCodeCAB()
        {
            CAB cab = new CAB();
            cab.Tx_A = ckb_TxA_Enable.Checked ? "1" : "0";
            cab.Tx_B = ckb_TxB_Enable.Checked ? "1" : "0";
            cab.Reboot = "";
            cab.Reset = "";
            return cab.GetCMD();
        }

        private void SendCAB()
        {
            string CMD = EnCodeCAB();
            if (CMD == "")
            {
                return;
            }
            SendCMDToBase(CMD);
        }
        #endregion

        #endregion

        #region 网络

        #region 查询

        /// <summary>
        /// 基本配置查询
        /// </summary>
        private void SendNetQuery()
        {
            string ABQ = string.Format("$--ABQ,{0}", "IPM");
            ABQ += CommHelp.Get0xHH(ABQ);
            SendCMDToBase(ABQ);
        }

        private void ClearAll()
        {
            if (txtWired_IP.InvokeRequired)
            {
                txtWired_IP.Invoke(new EventHandler(delegate { ClearAll(); }));
            }
            else
            {
                this.txtWired_IP.Text = "";
                this.txtWired_SubNetMask.Text = "";
                this.txtWired_Gateway.Text = "";
                this.txtWired_MAC.Text = "";
                this.txtAddr_IP_0.Text = "";
                this.txtDesPort_0.Text = "";
                this.txtLocalPort_0.Text = "";
                this.txtAddr_IP_1.Text = "";
                this.txtDesPort_1.Text = "";
                this.txtLocalPort_1.Text = "";
                this.txtAddr_IP_2.Text = "";
                this.txtDesPort_2.Text = "";
                this.txtLocalPort_2.Text = "";
                this.txtAddr_IP_3.Text = "";
                this.txtDesPort_3.Text = "";
                this.txtLocalPort_3.Text = "";
                this.txtLocalCFGPort.Text = "";
                this.txtLocalDataPort.Text = "";
            }
        }

        //$ABIPM,192.168.16.253,4507,4577,255.255.255.0,192.168.16.1,ec.24.b8.5e.bc.60,192.168.1.15,4001,5001,192.168.16.56,4002,5002,192.168.16.100,4003,5003,192.168.1.13,4004,5004,0,0*6E
        private void DecodeIPM(string strFrame)
        {
            try
            {
                if (this.gpNet0.InvokeRequired)
                {
                    Invoke(new EventHandler(delegate { DecodeIPM(strFrame); }));
                }
                else
                {
                    string[] strTempArray = strFrame.Split(new char[] { ',', '*' });
                    this.Invoke((EventHandler)(delegate
                    {
                        try
                        {
                            this.txtWired_IP.Text = ConvertFrameToString(strTempArray[1]);
                            this.txtWired_SubNetMask.Text = ConvertFrameToString(strTempArray[4]);
                            this.txtWired_Gateway.Text = ConvertFrameToString(strTempArray[5]);
                            this.txtWired_MAC.Text = strTempArray[6];
                            this.txtLocalCFGPort.Text = strTempArray[2];
                            this.txtLocalDataPort.Text = strTempArray[3];
                            this.txtAddr_IP_0.Text = ConvertFrameToString(strTempArray[7]);
                            this.txtDesPort_0.Text = strTempArray[8];
                            this.txtLocalPort_0.Text = strTempArray[9];
                            this.txtAddr_IP_1.Text = ConvertFrameToString(strTempArray[10]);
                            this.txtDesPort_1.Text = strTempArray[11];
                            this.txtLocalPort_1.Text = strTempArray[12];
                            this.txtAddr_IP_2.Text = ConvertFrameToString(strTempArray[13]);
                            this.txtDesPort_2.Text = strTempArray[14];
                            this.txtLocalPort_2.Text = strTempArray[15];
                            this.txtAddr_IP_3.Text = ConvertFrameToString(strTempArray[16]);
                            this.txtDesPort_3.Text = strTempArray[17];
                            this.txtLocalPort_3.Text = strTempArray[18];

                        }
                        catch (Exception)
                        {

                        }
                    }));
                }
            }
            catch
            {

            }
        }

        private string ConvertFrameToString(string strIP)
        {
            try
            {
                string[] strTempArray = strIP.Split(new char[] { '.' });
                if (strTempArray.Length != 4)
                {
                    return string.Empty;
                }
                string strReturn = string.Format("{0}.{1}.{2}.{3}"
                    , int.Parse(strTempArray[0])
                    , int.Parse(strTempArray[1])
                    , int.Parse(strTempArray[2])
                    , int.Parse(strTempArray[3]));
                return strReturn;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private string ConvertStringToFrame(string strIP)
        {
            try
            {
                string[] strTempArray = strIP.Split(new char[] { '.' });
                if (strTempArray.Length != 4)
                {
                    return string.Empty;
                }
                string strReturn = string.Format("{0}.{1}.{2}.{3}"
                    , strTempArray[0].ToString().PadLeft(3, '0')
                    , strTempArray[1].ToString().PadLeft(3, '0')
                    , strTempArray[2].ToString().PadLeft(3, '0')
                    , strTempArray[3].ToString().PadLeft(3, '0'));
                return strReturn;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }



        #endregion

        #region 设置

        private void SendIPM()
        {
            if (!CheckIPM())
            {
                ShowError();
                return;
            }
            string strCMD = string.Format("$--IPM,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19}",                
                                                 txtWired_IP.Text,
                                                 txtLocalDataPort.Text,
                                                 txtLocalCFGPort.Text,
                                                 txtWired_SubNetMask.Text,
                                                 txtWired_Gateway.Text,
                                                 txtWired_MAC.Text,
                                                 txtAddr_IP_0.Text,
                                                 txtDesPort_0.Text,
                                                 txtLocalPort_0.Text,
                                                 txtAddr_IP_1.Text,
                                                 txtDesPort_1.Text,
                                                 txtLocalPort_1.Text,
                                                 txtAddr_IP_2.Text,
                                                 txtDesPort_2.Text,
                                                 txtLocalPort_2.Text,
                                                 txtAddr_IP_3.Text,
                                                 txtDesPort_3.Text,
                                                 txtLocalPort_3.Text,
                                                 0,
                                                 0
                                                 );

            strCMD += CommHelp.Get0xHH(strCMD);
            SendCMDToBase(strCMD);
            SendNetQuery();
        }


        public static bool ValidateIPAddress(string ipAddress)
        {
            Regex validipregex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            return (ipAddress != "" && validipregex.IsMatch(ipAddress.Trim())) ? true : false;
        }

        public static bool ValidateMAC(string strMAC)
        {
            string s = @"^([0-9a-fA-F]{2})(([/\s.:-][0-9a-fA-F]{2}){5})$";

            Regex r = new Regex(s, RegexOptions.IgnoreCase);

            Match m = r.Match(strMAC.Trim());
            return m.Success;
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            uint uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                return;
            }
            bFlag = uint.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 65536 || uTemp < 0)
            {
                MessageBox.Show("端口应该是（0~65536）或置空！\r\n");
                txt_MMSI.Focus();
            }
        }

        private bool CheckIPM()
        {
            listError.Clear();
            if (!ValidateIPAddress(txtWired_IP.Text))
            {
                listError.Add("IP地址输入错误！\r\n");
            }
            if (!ValidateIPAddress(txtWired_SubNetMask.Text))
            {
                listError.Add("子网掩码输入错误！\r\n");
            }
            if (!ValidateIPAddress(txtWired_Gateway.Text))
            {
                listError.Add("默认网关输入错误！\r\n");
            }
            if (!ValidateMAC(txtWired_MAC.Text))
            {
                listError.Add("MAC地址输入错误！\r\n");
            }
            if (txtAddr_IP_0.Text != "" && !ValidateIPAddress(txtAddr_IP_0.Text))
            {
                listError.Add("目的地址1输入错误！\r\n");
                if (txtDesPort_0.Text.Trim() == "")
                {
                    listError.Add("目的端口1不能为空！\r\n");
                }
            }
            else if (txtAddr_IP_0.Text == "")
            {
                if (txtDesPort_0.Text.Trim() != "" || txtLocalPort_0.Text.Trim() != "")
                {
                    listError.Add("目的地址1为空！\r\n");
                }
            }
            if (txtAddr_IP_1.Text != "" && !ValidateIPAddress(txtAddr_IP_1.Text))
            {
                listError.Add("目的地址2输入错误！\r\n");
                if (txtDesPort_1.Text.Trim() == "")
                {
                    listError.Add("目的端口2不能为空！\r\n");
                }
            }
            else if (txtAddr_IP_1.Text == "")
            {
                if (txtDesPort_1.Text.Trim() != "" || txtLocalPort_1.Text.Trim() != "")
                {
                    listError.Add("目的地址2为空！\r\n");
                }
            }
            if (txtAddr_IP_2.Text != "" && !ValidateIPAddress(txtAddr_IP_2.Text))
            {
                listError.Add("目的地址3输入错误！\r\n");
                if (txtDesPort_2.Text.Trim() == "")
                {
                    listError.Add("目的端口3不能为空！\r\n");
                }
            }
            else if (txtAddr_IP_2.Text == "")
            {
                if (txtDesPort_2.Text.Trim() != "" || txtLocalPort_2.Text.Trim() != "")
                {
                    listError.Add("目的地址3为空！\r\n");
                }
            }
            if (txtAddr_IP_3.Text != "" && !ValidateIPAddress(txtAddr_IP_3.Text))
            {
                listError.Add("目的地址4输入错误！\r\n");
                if (txtDesPort_3.Text.Trim() == "")
                {
                    listError.Add("目的端口4不能为空！\r\n");
                }
            }
            else if (txtAddr_IP_3.Text == "")
            {
                if (txtDesPort_3.Text.Trim() != "" || txtLocalPort_3.Text.Trim() != "")
                {
                    listError.Add("目的地址4为空！\r\n");
                }
            }
            if (listError != null && listError.Count > 0)
            {
                return false;
            }
            return true;
        }

        #endregion

        #endregion

        #region 时隙分配
        private bool CheckECB(int iMsgID)
        {
            string ChAStartTime = "txtChAStartTime" + iMsgID;
            string ChAStartSlot = "txtChAStartSlot" + iMsgID;
            string ChASlotInterval = "txtChASlotInterval" + iMsgID;
            string ChBStartTime = "txtChBStartTime" + iMsgID;
            string ChBStartSlot = "txtChBStartSlot" + iMsgID;
            string ChBSlotInterval = "txtChBSlotInterval" + iMsgID;

            TextBox txtChAStartTime = this.tPTimeSlot.Controls.Find(ChAStartTime, true)[0] as TextBox;
            TextBox txtChAStartSlot = this.tPTimeSlot.Controls.Find(ChAStartSlot, true)[0] as TextBox;
            ComboBox txtChASlotInterval = this.tPTimeSlot.Controls.Find(ChASlotInterval, true)[0] as ComboBox;
            TextBox txtChBStartTime = this.tPTimeSlot.Controls.Find(ChBStartTime, true)[0] as TextBox;
            TextBox txtChBStartSlot = this.tPTimeSlot.Controls.Find(ChBStartSlot, true)[0] as TextBox;
            ComboBox txtChBSlotInterval = this.tPTimeSlot.Controls.Find(ChBSlotInterval, true)[0] as ComboBox;

            listError.Clear();
            bool bFlag;
            int iTemp;
            #region //通道A开始时隙时间
            if (!string.IsNullOrEmpty(txtChAStartTime.Text.Trim()))
            {
                bFlag = int.TryParse(txtChAStartTime.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    listError.Add("消息" + iMsgID + "通道A开始时隙时间有误，只能是数字！\r\n");
                }
                else
                {
                    if (iTemp > 60 || iTemp < 0)
                    {
                        listError.Add("消息" + iMsgID + "通道A开始时隙时间，必须是0到60！\r\n");
                    }
                }
            }
            #endregion
            #region  //通道A开始时隙
            if (!string.IsNullOrEmpty(txtChAStartSlot.Text.Trim()))
            {
                bFlag = int.TryParse(txtChAStartSlot.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    listError.Add("消息" + iMsgID + "通道A开始时隙有误，只能是数字！\r\n");
                }
                else
                {
                    if (iMsgID == 4)
                    {
                        if ((iTemp != -1) && (iTemp > 749 || iTemp < 1))
                        {
                            listError.Add("消息" + iMsgID + "通道A开始时隙，必须是1到749 或者(-1表示中断广播)!\r\n");
                        }
                    }
                    else
                    {
                        if (iTemp > 2249 || iTemp < -1)
                        {
                            listError.Add("消息" + iMsgID + "通道A开始时隙，必须是-1到2249！\r\n");
                        }
                    }
                }
            }
            #endregion
            #region  //通道A开始时隙间隔
            if (!string.IsNullOrEmpty(txtChASlotInterval.Text.Trim()))
            {
                if (txtChASlotInterval.Text.Trim() != string.Empty)
                {
                    bFlag = int.TryParse(txtChASlotInterval.Text.Trim(), out iTemp);
                    if (!bFlag)
                    {
                        listError.Add("消息" + iMsgID + "通道A开始时隙间隔有误，只能是数字！\r\n");
                    }
                    else
                    {
                        if (iTemp > 13500 || iTemp < 0)
                        {
                            listError.Add("消息" + iMsgID + "通道A开始时隙间隔，必须是0到13500！\r\n");
                        }
                    }
                }
            }
            #endregion
            #region //通道B开始时隙时间
            if (!string.IsNullOrEmpty(txtChBStartTime.Text.Trim()))
            {
                bFlag = int.TryParse(txtChBStartTime.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    listError.Add("消息" + iMsgID + "通道B开始时隙时间有误，只能是数字！\r\n");
                }
                else
                {
                    if (iTemp > 60 || iTemp < 0)
                    {
                        listError.Add("消息" + iMsgID + "通道B开始时隙时间，必须是0到60！\r\n");
                    }
                }
            }
            #endregion
            #region  //通道B开始时隙
            if (!string.IsNullOrEmpty(txtChBStartSlot.Text.Trim()))
            {
                bFlag = int.TryParse(txtChBStartSlot.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    listError.Add("消息" + iMsgID + "通道B开始时隙有误，只能是数字！\r\n");
                }
                else
                {
                    if (iMsgID == 4)
                    {
                        if ((iTemp != -1) && (iTemp > 749 || iTemp < 1))
                        {
                            listError.Add("消息" + iMsgID + "通道B开始时隙，必须是1到749 或者(-1表示中断广播)!\r\n");
                        }
                    }
                    else
                    {
                        if (iTemp > 2249 || iTemp < -1)
                        {
                            listError.Add("消息" + iMsgID + "通道B开始时隙，必须是-1到2249！\r\n");
                        }
                    }
                }
            }
            #endregion
            #region  //通道B开始时隙间隔
            if (!string.IsNullOrEmpty(txtChBSlotInterval.Text.Trim()))
            {
                if (txtChBSlotInterval.Text.Trim() != string.Empty)
                {
                    bFlag = int.TryParse(txtChBSlotInterval.Text.Trim(), out iTemp);
                    if (!bFlag)
                    {
                        listError.Add("消息" + iMsgID + "通道B开始时隙间隔有误，只能是数字！\r\n");
                    }
                    else
                    {
                        if (iTemp > 13500 || iTemp < 0)
                        {
                            listError.Add("消息" + iMsgID + "通道B开始时隙间隔，必须是0到13500！\r\n");
                        }
                    }
                }
            }
            #endregion
            #region 17号报文时隙总数
            if (iMsgID == 17)
            {
                if (!string.IsNullOrEmpty(txtChBSlotCounts17.Text.Trim()))
                {
                    bFlag = int.TryParse(txtChASlotCounts17.Text.Trim(), out iTemp);
                    if (!bFlag)
                    {
                        listError.Add("消息" + iMsgID + "通道A时隙总数有误，只能是数字！\r\n");
                    }
                    else
                    {
                        if (iTemp > 4 || iTemp < 1)
                        {
                            listError.Add("消息" + iMsgID + "通道A时隙总数有误，必须是1到4！\r\n");
                        }
                    }
                }
                if (!string.IsNullOrEmpty(txtChBSlotCounts17.Text.Trim()))
                {
                    bFlag = int.TryParse(txtChBSlotCounts17.Text.Trim(), out iTemp);
                    if (!bFlag)
                    {
                        listError.Add("消息" + iMsgID + "通道B时隙总数有误，只能是数字！\r\n");
                    }
                    else
                    {
                        if (iTemp > 4 || iTemp < 1)
                        {
                            listError.Add("消息" + iMsgID + "通道B时隙总数有误，必须是1到4！\r\n");
                        }
                    }
                }
            }
            #endregion
            if (listError != null && listError.Count > 0)
            {
                return false;
            }
            return true;

        }

        private string EnCodeECB(int iMsgID)
        {
            if (!CheckECB(iMsgID))
            {
                ShowError();
                return "";
            }
            try
            {
                if (Bmodel.VerModel == null)
                {
                    ShowError("基站编号为空，请先查询基站基本配置后再进行设置操作！");
                    return "";
                }
                if (Bmodel.msg4 == null)
                {
                    ShowError("请先查询基站配置后再进行设置操作！");
                    return "";
                }
                string ChAStartTime = "txtChAStartTime" + iMsgID;
                string ChAStartSlot = "txtChAStartSlot" + iMsgID;
                string ChASlotInterval = "txtChASlotInterval" + iMsgID;
                string ChBStartTime = "txtChBStartTime" + iMsgID;
                string ChBStartSlot = "txtChBStartSlot" + iMsgID;
                string ChBSlotInterval = "txtChBSlotInterval" + iMsgID;

                TextBox txtChAStartTime = this.tPTimeSlot.Controls.Find(ChAStartTime, true)[0] as TextBox;
                TextBox txtChAStartSlot = this.tPTimeSlot.Controls.Find(ChAStartSlot, true)[0] as TextBox;
                ComboBox txtChASlotInterval = this.tPTimeSlot.Controls.Find(ChASlotInterval, true)[0] as ComboBox;
                TextBox txtChBStartTime = this.tPTimeSlot.Controls.Find(ChBStartTime, true)[0] as TextBox;
                TextBox txtChBStartSlot = this.tPTimeSlot.Controls.Find(ChBStartSlot, true)[0] as TextBox;
                ComboBox txtChBSlotInterval = this.tPTimeSlot.Controls.Find(ChBSlotInterval, true)[0] as ComboBox;
                MsgTimeSlotCFG model = new MsgTimeSlotCFG();
                model.BaseID = Bmodel.VerModel.StationID;
                model.MsgType = iMsgID.ToString();
                model.ChAStartTime = txtChAStartTime.Text.Trim();
                model.ChAStartSlot = txtChAStartSlot.Text.Trim();
                model.ChASlotInterval = txtChASlotInterval.Text.Trim();
                model.ChBStartTime = txtChBStartTime.Text.Trim();
                model.ChBStartSlot = txtChBStartSlot.Text.Trim();
                model.ChBSlotInterval = txtChBSlotInterval.Text.Trim();
                model.ChASlotCounts = "";
                model.ChBSlotCounts = "";
                if (iMsgID == 17)
                {
                    model.ChASlotCounts = txtChASlotCounts17.Text.Trim();
                    model.ChBSlotCounts = txtChBSlotCounts17.Text.Trim();
                }

                return model.GetCMD();
            }
            catch (Exception)
            {
                ShowError("EnCodeECB出错！");
                return "";
            }
        }

        private string SendECB(int iMsgID)
        {
            string CMD = EnCodeECB(iMsgID);
            return CMD;
        }

        private void SendTimeSlot()
        {
            string ECB4 = SendECB(4);
            string ECB17 = SendECB(17);
            string ECB20 = SendECB(20);
            string ECB21 = SendECB(22);
            string ECB22 = SendECB(23);
            if (ECB4 == "" || ECB17 == "" || ECB20 == "" || ECB21 == "" || ECB22 == "")
            {
                return;
            }
            SendCMDToBase(ECB4);
            SendCMDToBase(ECB17);
            SendCMDToBase(ECB20);
            SendCMDToBase(ECB21);
            SendCMDToBase(ECB22);
            SendTimeSlotMgtQuery();
        }

        #endregion

        #region 数据链路管理
        private bool CheckDLM(int iIndexTemp, string Channel)
        {
            string strIndex = (iIndexTemp % 4 + 1).ToString();
            string stxt_StartSlot_Ch = "txt_StartSlot_Ch" + Channel + strIndex;
            string scbx_Incerment_Ch = "cbx_Incerment_Ch" + Channel + strIndex;
            string stxt_SlotCounts_Ch = "txt_SlotCounts_Ch" + Channel + strIndex;
            string scbx_Owner_Ch = "cbx_Owner_Ch" + Channel + strIndex;
            string stxt_TimeOut_Ch = "txt_TimeOut_Ch" + Channel + strIndex;
            TextBox txt_StartSlot_Ch = this.tPDLM.Controls.Find(stxt_StartSlot_Ch, true)[0] as TextBox;
            ComboBox cbx_Incerment_Ch = this.tPDLM.Controls.Find(scbx_Incerment_Ch, true)[0] as ComboBox;
            TextBox txt_SlotCounts_Ch = this.tPDLM.Controls.Find(stxt_SlotCounts_Ch, true)[0] as TextBox;
            ComboBox cbx_Owner_Ch = this.tPDLM.Controls.Find(scbx_Owner_Ch, true)[0] as ComboBox;
            TextBox txt_TimeOut_Ch = this.tPDLM.Controls.Find(stxt_TimeOut_Ch, true)[0] as TextBox;


            listError.Clear();
            bool bFlag;
            int iTemp;
            //起始时隙
            if (!string.IsNullOrWhiteSpace(txt_StartSlot_Ch.Text))
            {
                bFlag = int.TryParse(txt_StartSlot_Ch.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    listError.Add("通道" + Channel + " 设置项 " + iIndexTemp + 1 + "起始时隙有误，只能是数字（0~2249）！\r\n");
                }
                else
                {
                    if (iTemp > 2249 || iTemp < 0)
                    {
                        listError.Add("通道" + Channel + " 设置项 " + iIndexTemp + 1 + "起始时隙有误，只能是数字（0~2249）！\r\n");
                    }
                }
            }
            //增量
            if (!string.IsNullOrWhiteSpace(cbx_Incerment_Ch.Text))
            {
                bFlag = int.TryParse(cbx_Incerment_Ch.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    listError.Add("通道" + Channel + " 设置项 " + iIndexTemp + 1 + "增量有误，只能是数字（0~2249）！\r\n");
                }
                else
                {
                    if (iTemp > 1125 || iTemp < 0)
                    {
                        listError.Add("通道" + Channel + " 设置项 " + iIndexTemp + 1 + "增量有误，只能是数字（0~1125）！\r\n");
                    }
                }
            }
            //时隙数量
            if (!string.IsNullOrWhiteSpace(txt_SlotCounts_Ch.Text))
            {
                bFlag = int.TryParse(txt_SlotCounts_Ch.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    listError.Add("通道" + Channel + " 设置项 " + iIndexTemp + 1 + "时隙数量有误，只能是数字（1~5）！\r\n");
                }
                else
                {
                    if (iTemp > 5 || iTemp < 1)
                    {
                        listError.Add("通道" + Channel + " 设置项 " + iIndexTemp + 1 + "时隙数量有误，只能是数字（1~5）！\r\n");
                    }
                }
            }
            //超时
            if (!string.IsNullOrWhiteSpace(txt_TimeOut_Ch.Text))
            {
                bFlag = int.TryParse(txt_TimeOut_Ch.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    listError.Add("通道" + Channel + " 设置项 " + iIndexTemp + 1 + "超时有误，只能是数字（0~7）！\r\n");
                }
                else
                {
                    if (iTemp > 7 || iTemp < 0)
                    {
                        listError.Add("通道" + Channel + " 设置项 " + iIndexTemp + 1 + "超时有误，只能是数字（0~7）！\r\n");
                    }
                }
            }
            if (listError != null && listError.Count > 0)
            {
                return false;
            }
            return true;

        }

        private string EnCodeDLM(string Channel)
        {
            int iSelectedIndex = cbxDLMIndex.SelectedIndex;
            if (Bmodel.listDLM == null)
            {
                ShowError("请先查询数据链路管理后再进行设置操作！");
                return "";
            }
            try
            {
                List<MsgDLM> listDLMTemp = new List<MsgDLM>();
                for (int i = 0; i < 4; i++)
                {
                    if (!CheckDLM(iSelectedIndex * 4 + i, Channel))
                    {
                        ShowError();
                        return "";
                    }
                    string stxt_StartSlot_Ch = "txt_StartSlot_Ch" + Channel + (i + 1);
                    string scbx_Incerment_Ch = "cbx_Incerment_Ch" + Channel + (i + 1);
                    string stxt_SlotCounts_Ch = "txt_SlotCounts_Ch" + Channel + (i + 1);
                    string scbx_Owner_Ch = "cbx_Owner_Ch" + Channel + (i + 1);
                    string stxt_TimeOut_Ch = "txt_TimeOut_Ch" + Channel + (i + 1);
                    TextBox txt_StartSlot_Ch = this.tPDLM.Controls.Find(stxt_StartSlot_Ch, true)[0] as TextBox;
                    ComboBox cbx_Incerment_Ch = this.tPDLM.Controls.Find(scbx_Incerment_Ch, true)[0] as ComboBox;
                    TextBox txt_SlotCounts_Ch = this.tPDLM.Controls.Find(stxt_SlotCounts_Ch, true)[0] as TextBox;
                    ComboBox cbx_Owner_Ch = this.tPDLM.Controls.Find(scbx_Owner_Ch, true)[0] as ComboBox;
                    TextBox txt_TimeOut_Ch = this.tPDLM.Controls.Find(stxt_TimeOut_Ch, true)[0] as TextBox;

                    MsgDLM model = new MsgDLM();
                    model.MsgID = (4 * iSelectedIndex + i).ToString();
                    model.Channel = Channel;
                    model.StartSlot = txt_StartSlot_Ch.Text.Trim();
                    model.SlotIncrement = cbx_Incerment_Ch.Text.Trim();
                    model.SlotCounts = txt_SlotCounts_Ch.Text.Trim();
                    model.Owner = cbx_Owner_Ch.Text.Trim().Length > 1 ? cbx_Owner_Ch.Text.Trim().Substring(0, 1) : cbx_Owner_Ch.Text.Trim();
                    model.Timeout = txt_TimeOut_Ch.Text.Trim();
                    listDLMTemp.Add(model);
                }
                return MsgDLM.GetCMD(iSelectedIndex, Channel, listDLMTemp);
            }
            catch (Exception)
            {
                ShowError("EnCodeDLM出错！");
                return "";
            }

        }

        private string SendDLM(string Channel)
        {
            string CMD = EnCodeDLM(Channel);
            return CMD;
        }

        private void SendDataLinkMgt()
        {
            string DLMA = SendDLM("A");
            string DLMB = SendDLM("B");
            if (DLMA == "" || DLMB == "")
            {
                return;
            }
            else
            {
                SendCMDToBase(DLMA);
                SendCMDToBase(DLMB);
                SendDataLinkMgtQuery();
            }
        }

        #endregion

        #region VSI FSR语句管理 
        private bool CheckSPO()
        {
            return true;
        }

        private string EnCodeSPO()
        {
            try
            {
                if (Bmodel.SidModel == null)
                {
                    ShowError("请先查询基站配置后再进行设置操作！");
                    return "";
                }
                SPO Model = new SPO();
                Model.BaseID = Bmodel.SidModel.UniqueID_Cur;
                Model.SelectChannel = cbx_SPO_Channel.Text.Substring(cbx_SPO_Channel.Text.Length - 1, 1);
                Model.RecvSingalStrengthVDL = ckb_SingalStrength.Checked ? "1" : "0";
                Model.FisrtSlotNumForFirstRecvMsg = ckb_FisrtSlotNumForFirstRecvMsg.Checked ? "1" : "0";
                Model.TimeOfMsgArrival = ckb_TimeOfMsgArrival.Checked ? "1" : "0";
                Model.SingalToNoiseRatio = ckb_SNR.Checked ? "1" : "0";
                Model.PreFrameCHLoad = ckb_PreFrameCHLoad.Checked ? "1" : "0";
                Model.NumOfBadCRC = ckb_NumOfBadCRC.Checked ? "1" : "0";
                Model.ForecastCHLoad = ckb_ForecastCHLoad.Checked ? "1" : "0";
                Model.AverageNoiseLevel = ckb_AverageNoiseLevel.Checked ? "1" : "0";
                Model.RecvSingalStrength = ckb_RecvSingalStrength.Checked ? "1" : "0";
                Model.ProVSISens4VDM = ckb_VSI4VDM.Checked ? "1" : "0";
                Model.ProVSISens4VDO = ckb_VSI4VDO.Checked ? "1" : "0";
                Model.ProFSRSens = ckb_ProFSRSens.Checked ? "1" : "0";
                return Model.GetCMD();
            }
            catch (Exception)
            {
                ShowError("EnCodeSPO出错！");
                return "";
            }
        }

        private void SendVSIFSRMgt()
        {
            string CMD = EnCodeSPO();
            if (CMD == "")
            {
                return;
            }
            SendCMDToBase(CMD);
            SendVSIFSRMgtQuery();
        }

        #endregion

        #region  虚拟航标管理
        private bool CheckATN()
        {
            listError.Clear();
            uint iTemp;
            bool bFlag;
            bFlag = uint.TryParse(txt_AtoN_MMSI.Text.Trim(), out iTemp);
            if (!bFlag)
            {
                listError.Add("MMSI只能是不超过9位长度的数字组成！\r\n");
            }
            //类型
            if (cbxAtoNType.Text == "")
            {
                listError.Add("AtoN类型不能为空！\r\n");
            }
            bFlag = RegexName2(txt_AtoN_Name.Text.Trim());
            if (!bFlag)
            {
                listError.Add("AtoN名称由大写字母A_Z和数据0_9组成！\r\n");
            }
            if (cbx_AtoN_PosDeviceType.Text == "")
            {
                listError.Add("FPFS不能为空！\r\n");
            }
            bFlag = uint.TryParse(txt_AtoN_SendIntervalChA.Text.Trim(), out iTemp);
            if (!bFlag)
            {
                listError.Add("报告间隔应该是1~179之间的数字！\r\n");
            }
            else
            {
                if (iTemp > 179 || iTemp < 1)
                {
                    listError.Add("报告间隔应该是1~179之间的数字！\r\n");
                }

            }
            bFlag = uint.TryParse(txt_AtoN_TimeStamp.Text.Trim(), out iTemp);
            if (!bFlag)
            {
                listError.Add("时戳应该是0~63之间的数字！\r\n");
            }
            else
            {
                if (iTemp > 63 || iTemp < 0)
                {
                    listError.Add("时戳应该是0~63之间的数字！\r\n");
                }
            }
            //bFlag = uint.TryParse(txt_ATN_UpdateTime.Text.Trim(), out iTemp);
            //if (!bFlag)
            //{
            //    listError.Add("更新时间应该是0~63之间的数字！\r\n");
            //}
            //else
            //{
            //    if (iTemp > 63 || iTemp < 0)
            //    {
            //        listError.Add("更新时间应该是0~63之间的数字！\r\n");
            //    }
            //}
            CheckATNBasePostion();
            //尺寸
            if (!UInt32.TryParse(txtSizeA.Text.Trim(), out iTemp) || iTemp > 511)
            {
                listError.Add("尺寸A输入不正确\r\n");
            }
            if (!UInt32.TryParse(txtSizeB.Text.Trim(), out iTemp) || iTemp > 511)
            {
                listError.Add("尺寸B输入不正确\r\n");
            }
            if (!UInt32.TryParse(txtSizeC.Text.Trim(), out iTemp) || iTemp > 63)
            {
                listError.Add("尺寸C输入不正确\r\n");
            }
            if (!UInt32.TryParse(txtSizeD.Text.Trim(), out iTemp) || iTemp > 63)
            {
                listError.Add("尺寸D输入不正确\r\n");
            }
            if (listError != null && listError.Count > 0)
            {
                return false;
            }
            return true;
        }
        private void CheckATNBasePostion()
        {
            //经度
            if (!string.IsNullOrEmpty(txt_ATN_LongDu.Text.Trim()) || !string.IsNullOrEmpty(txt_ATN_LongFen.Text.Trim()) || !string.IsNullOrEmpty(txt_ATN_LongSeconds.Text.Trim()))
            {
                if (string.IsNullOrEmpty(ckb_ATN_EW.Text.Trim()))
                {
                    listError.Add("请确定选择东西经！\r\n");
                }
                uint LongDu = 0;
                if (!string.IsNullOrEmpty(txt_ATN_LongDu.Text.Trim()))
                {
                    if (!uint.TryParse(txt_ATN_LongDu.Text.Trim(), out LongDu))
                    {
                        listError.Add("经度的度取值范围是【0~180】！\r\n");
                    }
                    else if (LongDu > 182)
                    {
                        listError.Add("经度的度取值范围是【0~180】{181为默认值不可用}！\r\n");
                    }
                }
                uint LongFen = 0;
                if (!string.IsNullOrEmpty(txt_ATN_LongFen.Text.Trim()))
                {
                    if (!uint.TryParse(txt_ATN_LongFen.Text.Trim(), out LongFen))
                    {
                        listError.Add("经度的分整数取值范围是【0~59】！\r\n");
                    }
                    else if (LongFen > 59)
                    {
                        listError.Add("经度的分整数取值范围是【0~59】！\r\n");
                    }
                }
                double LongSeconds = 0;
                if (!string.IsNullOrEmpty(txt_ATN_LongSeconds.Text.Trim()))
                {
                    if (!double.TryParse(txt_ATN_LongSeconds.Text.Trim(), out LongSeconds))
                    {
                        listError.Add("经度的分小数取值范围是【0~9999】！\r\n");
                    }
                    else if (LongSeconds > 9999)
                    {
                        listError.Add("经度的分小数取值范围是【0~9999】！\r\n");
                    }
                }
            }
            if (!string.IsNullOrEmpty(txt_ATN_LatDu.Text.Trim()) || !string.IsNullOrEmpty(txt_ATN_LatFen.Text.Trim()) || !string.IsNullOrEmpty(txt_ATN_LatSecond.Text.Trim()))
            {
                //纬度
                uint LatDu = 0;
                if (!string.IsNullOrEmpty(txt_ATN_LatDu.Text.Trim()))
                {
                    if (!uint.TryParse(txt_ATN_LatDu.Text.Trim(), out LatDu))
                    {
                        listError.Add("纬度的度取值范围是【0~90】{91为默认值不可用}！\r\n");
                    }
                    else if (LatDu > 90)
                    {
                        listError.Add("纬度的度取值范围是【0~90】{91为默认值不可用}！\r\n");
                    }
                }
                uint LatFen = 0;
                if (!string.IsNullOrEmpty(txt_ATN_LatFen.Text.Trim()))
                {
                    if (!uint.TryParse(txt_ATN_LatFen.Text.Trim(), out LatFen))
                    {
                        listError.Add("纬度的分取值范围是【0~59】！\r\n");
                    }
                    else if (LatFen > 59)
                    {
                        listError.Add("纬度的分取值范围是【0~59】！\r\n");
                    }
                }
                int LatSeconds = 0;
                if (!string.IsNullOrEmpty(txt_ATN_LatSecond.Text.Trim()))
                {
                    if (!int.TryParse(txt_ATN_LatSecond.Text.Trim(), out LatSeconds))
                    {
                        listError.Add("纬度的分小数取值范围是【0~9999】！\r\n");
                    }
                    else if (LatSeconds > 9999)
                    {
                        listError.Add("纬度的分小数取值范围是【0~9999】！\r\n");
                    }
                }
                if (string.IsNullOrEmpty(ckb_ATN_NS.Text.Trim()))
                {
                    listError.Add("请确定选择南北纬！\r\n");
                }
            }
        }
        public bool RegexName2(string str)
        {
            bool flag = Regex.IsMatch(str, @"^[A-Z0-9\s]+$");
            return flag;
        }

        private string EnCodeATN()
        {
            if (!CheckATN())
            {
                ShowError();
                return "";
            }
            try
            {
                if (Bmodel.listATN == null)
                {
                    ShowError("请先查询基站虚拟航标配置后再进行设置操作！");
                    return "";
                }
                ATN model = new ATN();
                model.Seq = AtoN_SelectedIndex.ToString("00");
                model.Enable = ckb_AtoN_Enable.Checked ? "1" : "0";
                model.StartSlotA = txt_ATN_StartSlotChA.Text.Trim().PadLeft(4, '0');//??
                model.SendIntervalA = txt_AtoN_SendIntervalChA.Text.Trim();
                //model.StartSlotB = txt_ATN_StartSlotChB.Text.Trim().PadLeft(4, '0');
                //model.SendIntervalB = txt_AtoN_SendIntervalChB.Text.Trim();
                model.MMSI = txt_AtoN_MMSI.Text.Trim();
                model.Type = cbxAtoNType.SelectedIndex.ToString();
                model.Name = txt_AtoN_Name.Text.Trim();
                model.PosAccuracy = ckb_ATN_PosAccuray.Checked ? "1" : "0";
                model.Latitude = GetPostionToDuFen(txt_ATN_LatDu.Text.Trim(), txt_ATN_LatFen.Text.Trim(), txt_ATN_LatSecond.Text.Trim(), "Lat");
                model.Longitude = GetPostionToDuFen(txt_ATN_LongDu.Text.Trim(), txt_ATN_LongFen.Text.Trim(), txt_ATN_LongSeconds.Text.Trim(), "Long");
                model.NS = ckb_ATN_NS.Text.Trim();
                model.EW = ckb_ATN_EW.Text.Trim();
                model.Size_A = txtSizeA.Text.Trim().PadLeft(3, '0');
                model.Size_B = txtSizeB.Text.Trim().PadLeft(3, '0');
                model.Size_C = txtSizeC.Text.Trim().PadLeft(2, '0');
                model.Size_D = txtSizeD.Text.Trim().PadLeft(2, '0');
                model.PosDeviceType = cbx_AtoN_PosDeviceType.SelectedIndex.ToString("00");
                model.TimeStamp = txt_AtoN_TimeStamp.Text.Trim();
                model.OffPos_Indicator = ckb_ATN_OffPos.Checked ? "1" : "0";
                model.AtoNStatus = "0";//?
                model.RAIM_Flag = ckb_ATN_RAIM_Flag.Checked ? "1" : "0";
                model.Virtual_AtoN_Flag = ckb_AtoN_VirtualATN.Checked ? "1" : "0";
                model.Assigned_Model_Flag = ckb_ATN_SingedMode.Checked ? "1" : "0";
                model.Spare = "0";
                return model.GetCMD_ATN();
            }
            catch (Exception)
            {
                ShowError("EnCodeBCE出错！");
                return "";
            }
        }


        private void SendAtoN()
        {
            string strCMD_ATN = EnCodeATN();
            if (strCMD_ATN == "")
            {
                return;
            }
            SendCMDToBase(strCMD_ATN);
            SendAtoNQuery();
        }

        private void txt_AtoN_SendIntervalChA_TextChanged(object sender, EventArgs e)
        {
            int uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (!ckb_AtoN_Enable.Checked)
            {
                return;
            }
            if (txt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("报告间隔应该是（1~179）！\r\n");
                return;
            }
            bFlag = int.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 179 || uTemp < 1)
            {
                MessageBox.Show("报告间隔应该是（1~179）！\r\n");
                txt_MMSI.Focus();
            }
        }
        private void txt_AtoN_TimeStamp_TextChanged(object sender, EventArgs e)
        {
            int uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (!ckb_AtoN_Enable.Checked)
            {
                return;
            }
            if (txt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("时戳应该是（0~63）！\r\n");
                return;
            }
            bFlag = int.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 63 || uTemp < 0)
            {
                MessageBox.Show("时戳应该是（0~63）！\r\n");
                txt_MMSI.Focus();
            }
        }
        #endregion


        #region 数据监视窗体
        private delegate void ShowMsgEventHandle(string Msg);

        private ShowMsgEventHandle showMsgHandle;

        FormDataDisplay frmDisplay;

        private void btn_DataMonitor_Click(object sender, EventArgs e)
        {
            if (frmDisplay == null)
            {
                frmDisplay = new FormDataDisplay();
                frmDisplay.FormDisplayClosedHandle += FormDisplayClosed;
                showMsgHandle += frmDisplay.ShowData;
                frmDisplay.Owner = this;
                frmDisplay.StartPosition = FormStartPosition.CenterScreen;
                frmDisplay.Show();
            }
            frmDisplay.WindowState = FormWindowState.Normal;
            //frmDisplay.Activate();
        }

        private void FormDisplayClosed()
        {
            frmDisplay.FormDisplayClosedHandle -= FormDisplayClosed;
            showMsgHandle -= frmDisplay.ShowData;
            frmDisplay.Dispose();
            frmDisplay = null;
        }
        #endregion

        private void InitQuery()
        {
            SendGeneralQuery();
            ClearAll();
            SendNetQuery();
            SendTimeSlotMgtQuery();
            SendDataLinkMgtQuery();
            SendAGAQuery();
            SendACAQuery();
            SendAtoNQuery();
        }

        #region 公共校验代码
        private void txt_InputNUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            char KeyChar = e.KeyChar;
            int TextLength = ((TextBox)sender).TextLength;
            if (Regex.Match(KeyChar.ToString(), "[0-9]").Success)
            {
                if ((((TextBox)sender).SelectedText.Length == TextLength) && (TextLength > 0))
                {
                    e.Handled = false;
                    return;
                }
            }
            else
            {   // 回删操作
                if (KeyChar == '\b')
                {
                    if (TextLength == 0)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_MMSI_TextChanged(object sender, EventArgs e)
        {
            uint uMMSI;
            bool bFlag;
            if (txt_MMSI.Text.Trim() == string.Empty)
            {
                return;
            }
            bFlag = uint.TryParse(txt_MMSI.Text.Trim(), out uMMSI);
            if (!bFlag)
            {
                MessageBox.Show("MMSI只能是不超过9位长度的数字组成！\r\n");
                txt_MMSI.Focus();
            }
        }

        private void txt_InputNUMChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char KeyChar = e.KeyChar;
            int TextLength = ((TextBox)sender).TextLength;
            if (Regex.Match(KeyChar.ToString(), "[0-9a-zA-Z]").Success)
            {
                if ((((TextBox)sender).SelectedText.Length == TextLength) && (TextLength > 0))
                {
                    e.Handled = false;
                    return;
                }
            }
            else
            {   // 回删操作
                if (KeyChar == '\b')
                {
                    if (TextLength == 0)
                    {
                        e.Handled = true;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_InputNUMStartSlot_KeyPress(object sender, KeyPressEventArgs e)
        {
            char KeyChar = e.KeyChar;
            int TextLength = ((TextBox)sender).TextLength;
            // 回删操作
            if (KeyChar == '\b')
            {
                if (TextLength == 0)
                {
                    e.Handled = true;
                }
                return;
            }
            if (((TextBox)sender).Text == "-1")
            {
                e.Handled = true;
                return;
            }
            if (KeyChar == '-')
            {
                if (TextLength == 0 || (((TextBox)sender).SelectedText.Length == TextLength))
                {
                    e.Handled = false;
                    return;
                }
                else
                {
                    e.Handled = true;
                    return;
                }
            }
            if (Regex.Match(KeyChar.ToString(), "[0-9]").Success)
            {
                if ((((TextBox)sender).SelectedText.Length == TextLength) && (TextLength > 0))
                {
                    e.Handled = false;
                    return;
                }
            }

        }

        #region 时隙分配
        private void txtChStartTime_TextChanged(object sender, EventArgs e)
        {
            int uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                return;
            }
            bFlag = int.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 60 || uTemp < -1)
            {
                MessageBox.Show("通道开始时隙时间应该是（0~60）或置空！\r\n");
                txt_MMSI.Focus();
            }
        }

        private void txtChSlotCounts17_TextChanged(object sender, EventArgs e)
        {
            uint uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                return;
            }
            bFlag = uint.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 4 || uTemp < 1)
            {
                MessageBox.Show("时隙总数应该是（1~4）或置空！\r\n");
                txt_MMSI.Focus();
            }
        }

        private void txtChStartSlot_TextChanged(object sender, EventArgs e)
        {
            int uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                return;
            }
            if (txt.Text.Trim() == "-")
            {
                return;
            }
            bFlag = int.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 2249 || uTemp < -1)
            {
                MessageBox.Show("时隙起始应该是（-1~2249）或置空！\r\n");
                txt_MMSI.Focus();
            }
        }

        private void txtChStartSlot4_TextChanged(object sender, EventArgs e)
        {
            int uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                return;
            }
            if (txt.Text.Trim() == "-")
            {
                return;
            }
            bFlag = int.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 749 || uTemp < -1)
            {
                MessageBox.Show("时隙起始应该是（-1~749）或置空！\r\n");
                txt_MMSI.Focus();
            }
        }

        #endregion

        #endregion

        #region DLM

        private void txt_StartSlot_Ch_TextChanged(object sender, EventArgs e)
        {
            int uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                return;
            }
            bFlag = int.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 749 || uTemp < 0)
            {
                MessageBox.Show("起始时隙应该是（0~2249）或置空！\r\n");
                txt_MMSI.Focus();
            }
        }

        private void txt_SlotCounts_Ch_TextChanged(object sender, EventArgs e)
        {
            int uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                return;
            }
            bFlag = int.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 5 || uTemp < 1)
            {
                MessageBox.Show("时隙数量应该是（1~5）或置空！\r\n");
                txt_MMSI.Focus();
            }
        }

        private void txt_TimeOut_Ch_TextChanged(object sender, EventArgs e)
        {
            int uTemp;
            bool bFlag;
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                return;
            }
            bFlag = int.TryParse(txt.Text.Trim(), out uTemp);
            if (!bFlag || uTemp > 7 || uTemp < 0)
            {
                MessageBox.Show("超时值应该是（0~7）或置空！\r\n");
                txt_MMSI.Focus();
            }
        }



        #endregion


    }
}
