//using DT.Comlib;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;

namespace AISBaseCFG
{
    public class SerialImpl : ConnImpl
    {
        #region 串口变量
        /// <summary>
        /// 串口声明
        /// </summary>
        public SerialPort comm;

        private string ComName { get; set; }

        private  int ComBaud { get; set; }

        private StringBuilder builder = new StringBuilder();

        bool bListening = false;
        bool bCloseing = false;

        #endregion

        public SerialImpl(string Com_Name, int Com_Baud)
        {
            ComName = Com_Name;
            ComBaud = Com_Baud;
            InitComm();
            this.CId = (IntPtr)this.GetHashCode();
        }

        ~SerialImpl()
        {
            Dispose();
        }

        private void InitComm()
        {
            try
            {
                comm = new SerialPort();
                comm.PortName = ComName;
                comm.BaudRate = ComBaud;
                //初始化SerialPort对象
                comm.NewLine = "\r\n";
                comm.RtsEnable = true;//根据实际情况吧。
                comm.DtrEnable = true;
            }
            catch (Exception ex)
            {
                if (onErrorReportHandle != null)
                {
                    onErrorReportHandle(this, 101, ex.Message);
                }
            }
        }

        //7月修改
        private OptDataType _optdataType = OptDataType.StringArray;
        void comm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            try
            {
                if (bCloseing)
                {
                    return;
                }
                bListening = true;
                int n = comm.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致
                byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据
                comm.Read(buf, 0, n);//读取缓冲数据
                switch (_optdataType)
                {
                    case OptDataType.StringArray:
                        //直接按ASCII规则转换成字符串
                        string strRecv = Encoding.ASCII.GetString(buf);
                        if (strRecv == null || strRecv.Length < 1)
                        {
                            return;
                        }
                        builder.Append(strRecv);
                        string bulidString = builder.ToString();
                        builder.Remove(0, builder.Length);//清除字符串构造器的内容
                        string[] strDataArray = CommHelp.Resolve(ref bulidString);
                        if (onRoute_OutEventHandle != null)
                        {
                            DTAEventArgs args = new DTAEventArgs();
                            args.FrameArray = strDataArray;
                            onRoute_OutEventHandle((IntPtr)this.GetHashCode(), args);
                        }
                        builder.Append(bulidString);
                        break;
                    case OptDataType.ByteArray:
                        string[] strDataArray2 = new string[] { Encoding.ASCII.GetString(buf) };
                        if (onRoute_OutEventHandle != null)
                        {
                            DTAEventArgs args = new DTAEventArgs();
                            args.FrameArray = strDataArray2;
                            onRoute_OutEventHandle((IntPtr)this.GetHashCode(), args);
                        }
                        break;
                    default:
                        break;
                }
                bListening = false;
            }
            catch (Exception ex)
            {
                if (onErrorReportHandle != null)
                {
                    onErrorReportHandle(this, 102, ex.Message);
                }
            }
        }

        public override void Dispose()
        {
            //调用带参数的Dispose方法，释放托管和非托管资源
            Dispose(true);
            //手动调用了Dispose释放资源，那么析构函数就是不必要的了，这里阻止GC调用析构函数
            System.GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                comm.Dispose();
            }
            ///TODO:在这里加入清理"非托管资源"的代码
        }

        public override string GetConnDesc()
        {
            return ComName + ":" + ComBaud.ToString();
        }

        public override void OnRecvRouteDataEventHandle(object obj, DTAEventArgs e)
        {
            try
            {
                if (this.CIO == DataDriection.In)
                {
                    return;
                }
                if (comm != null && comm.IsOpen)
                {
                    foreach (var item in e.FrameArray)
                    {
                        comm.Write(item);
                    }
                }
            }
            catch (Exception ex)
            {
                if (onErrorReportHandle != null)
                {
                    onErrorReportHandle(this, 103, ex.Message);
                }
            }
        }

        public override HandleRst OnStart()
        {
            try
            {
                if (!comm.IsOpen)
                {
                    ///当为输出模式时，忽悠接收数据
                    if (this.CIO != DataDriection.Out)
                    {
                        comm.DataReceived += comm_DataReceived;
                    }
                    bCloseing = false;
                    comm.Open();
                    this.CStatus = ConnStatus.Started;
                    return HandleRst.Ok;
                }
                else
                {
                    return HandleRst.Ignore;
                }
            }
            catch (Exception ex)
            {
                this.CStatus = ConnStatus.Error;
                if (onErrorReportHandle != null)
                {
                    onErrorReportHandle(this, 104, ex.Message);
                }
                return HandleRst.Error;
            }
        }

        public override HandleRst OnStop()
        {
            try
            {
                //根据当前串口对象，来判断操作
                if (comm.IsOpen)
                {
                    bCloseing = true;
                    while (bListening)
                    {
                        System.Windows.Forms.Application.DoEvents();
                    }
                    ///当为输出模式时，忽悠接收数据
                    if (this.CIO != DataDriection.Out)
                    {
                        comm.DataReceived -= comm_DataReceived;
                    }
                    //打开时点击，则关闭串口
                    comm.Close();
                    this.CStatus = ConnStatus.Closed;
                    if (onStopHandle!=null)
                    {
                        onStopHandle(this);
                    }
                    return HandleRst.Ok;
                }
                else
                {
                    return HandleRst.Ignore;
                }
            }
            catch (Exception ex)
            {
                this.CStatus = ConnStatus.Error;
                if (onErrorReportHandle != null)
                {
                    onErrorReportHandle(this, 105, ex.Message);
                }
                return HandleRst.Error;
            }
        }
    }
}
//串口操作错误代码
//**************************
//* 101 串口初始化出错
//* 102 串口接收事件出错
//* 103 串口路由数据实现出错
//* 104 开启串口出错
//* 105 关闭串口出错
//*
//*
//**************************

