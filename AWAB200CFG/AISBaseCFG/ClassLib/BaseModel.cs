using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AISBaseCFG
{
    public class BaseModel
    {
        public SID SidModel { get; set; }
        public VER VerModel { get; set; }
        public BCF BCFModel { get; set; }
        public BCE BCEModel { get; set; }
        public NETCFG IPMModel { get; set; }
        public MsgTimeSlotCFG msg4 { get; set; }
        public MsgTimeSlotCFG msg17 { get; set; }
        public MsgTimeSlotCFG msg20 { get; set; }
        public MsgTimeSlotCFG msg22 { get; set; }
        public MsgTimeSlotCFG msg23 { get; set; }
        public List<MsgDLM> listDLM { get; set; }

        public List<ATN> listATN { get; set; }
    }

    /// <summary>
    /// 基站ID设置报文
    /// </summary>
    public class SID
    {
        public string UniqueID_Cur { get; set; }
        public string UniqueID_New { get; set; }
        public string MMSI_Cur { get; set; }
        public string MMSI_New { get; set; }
        public string GetSidCmd()
        {
            string sid = string.Format("$--SID,{0},{1},{2},{3}",
                UniqueID_Cur,
                UniqueID_New,
                MMSI_Cur,
                MMSI_New);
            sid += CommHelp.Get0xHH(sid);
            return sid;
        }
    }

    public class VER
    {
        public string DeviceType { get; set; }
        public string FacID { get; set; }
        public string StationID { get; set; }
        public string DeviceNum { get; set; }
        public string ModelType { get; set; }
        public string SoftVersion { get; set; }
        public string HardVersion { get; set; }
    }

    public class BCF
    {
        public string MMSI { get; set; }
        public string PositionSource { get; set; }
        public string Latitude { get; set; }
        public string NS { get; set; }
        public string Longitude { get; set; }
        public string EW { get; set; }
        public string PositionAccuracy { get; set; }
        public string RxA { get; set; }
        public string RxB { get; set; }
        public string TxA { get; set; }
        public string TxB { get; set; }
        public string PowerLevelA { get; set; }
        public string PowerLevelB { get; set; }
        public string MsgRetries { get; set; }
        public string MsgRepeatIndicator { get; set; }
        public string BaseTalkerID { get; set; }
        public string GetBCFCmd()
        {
            string bcf = string.Format("$--BCF,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15}",
                MMSI,
                PositionSource,
                Latitude,
                NS,
                Longitude,
                EW,
                PositionAccuracy,
                RxA,
                RxB,
                TxA,
                TxB,
                PowerLevelA,
                PowerLevelB,
                MsgRetries,
                MsgRepeatIndicator,
                BaseTalkerID
                );
            bcf += CommHelp.Get0xHH(bcf);
            return bcf;
        }
    }

    public class BCE
    {
        public string BaseID { get; set; }
        public string RATDMA { get; set; }
        public string UTCSoure { get; set; }
        public string ADSInterval { get; set; }
        public string BlockControl { get; set; }
        public string GetCMD()
        {
            string strCMD = string.Format("$--BCE,{0},{1},{2},{3},{4}",
            BaseID,
            RATDMA,
            UTCSoure,
            ADSInterval,
            BlockControl);
            strCMD += CommHelp.Get0xHH(strCMD);
            return strCMD;
        }

    }

    public class CAB
    {
        public string Tx_A { get; set; }
        public string Tx_B { get; set; }
        public string Reboot { get; set; }
        public string Reset { get; set; }
        public string GetCMD()
        {
            string strCMD = string.Format("$--CAB,{0},{1},{2},{3}",
            Tx_A,
            Tx_B,
            Reboot,
            Reset);
            strCMD += CommHelp.Get0xHH(strCMD);
            return strCMD;
        }
    }

    public class NETCFG
    {
        public string LocalNetIP { get; set; }
        public string LocalNetMask { get; set; }
        public string LocalNetGateway { get; set; }
        public string LocalNetMAC { get; set; }
        public string DataSvrPort { get; set; }
        public string ConfigSvrPort { get; set; }
        public string DestIP1 { get; set; }
        public string DestPort1 { get; set; }
        public string LocalPort1 { get; set; }
        public string DestIP2 { get; set; }
        public string DestPort2 { get; set; }
        public string LocalPort2 { get; set; }
        public string DestIP3 { get; set; }
        public string DestPort3 { get; set; }
        public string LocalPort3 { get; set; }
        public string DestIP4 { get; set; }
        public string DestPort4 { get; set; }
        public string LocalPort4 { get; set; }

        public string GetCMD()
        {
            string strTemp = string.Format("$--IPM,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17}",
              LocalNetIP,
              DataSvrPort,
              ConfigSvrPort,
              LocalNetMask,
              LocalNetGateway,
              LocalNetMAC,
              DestIP1,
              DestPort1,
              LocalPort1,
                DestIP2,
              DestPort2,
              LocalPort2,
                DestIP3,
              DestPort3,
              LocalPort3,
                DestIP4,
              DestPort4,
              LocalPort4
              );
            strTemp += CommHelp.Get0xHH(strTemp);
            return strTemp;
        }

    }

    public class MsgTimeSlotCFG
    {
        public string BaseID { get; set; }
        public string MsgType { get; set; }
        public string ChAStartTime { get; set; }
        public string ChAStartSlot { get; set; }
        public string ChASlotInterval { get; set; }
        public string ChASlotCounts { get; set; }
        public string ChBStartTime { get; set; }
        public string ChBStartSlot { get; set; }
        public string ChBSlotInterval { get; set; }
        public string ChBSlotCounts { get; set; }

        internal string GetCMD()
        {
            string strTemp = string.Format("$--ECB,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}",
               BaseID,
               MsgType,
               ChAStartTime,
               ChAStartSlot,
               ChASlotInterval,
               ChASlotCounts,
               ChBStartTime,
               ChBStartSlot,
               ChBSlotInterval,
               ChBSlotCounts
               );
            strTemp += CommHelp.Get0xHH(strTemp);
            return strTemp;
        }
    }

    public class MsgDLM
    {
        /// <summary>
        /// 消息号0~40
        /// </summary>
        public string MsgID { get; set; }//
        public string Channel { get; set; }//A/B
        public string Owner { get; set; }//L,R,C
        public string StartSlot { get; set; }//0~2249
        public string SlotIncrement { get; set; }
        public string SlotCounts { get; set; }
        public string Timeout { get; set; }

        public static string GetCMD(int Seq, string Channel, List<MsgDLM> listTemp)
        {
            try
            {
                string strCMD = string.Format("$--DLM,{0},{1}", Seq, Channel);
                for (int i = 0; i < listTemp.Count; i++)
                {
                    strCMD += "," + listTemp[i].Owner;
                    strCMD += "," + listTemp[i].StartSlot;
                    strCMD += "," + listTemp[i].SlotCounts;
                    strCMD += "," + listTemp[i].Timeout;
                    strCMD += "," + listTemp[i].SlotIncrement;
                }
                strCMD += CommHelp.Get0xHH(strCMD);
                return strCMD;
            }
            catch (Exception)
            {
                return "";
            }

        }
    }

    public class SPO
    {
        //$ABSPO,XiaoHeKou01,E,1,1,1,0,1,1,1,1,1,1,1,1*49
        public string BaseID { get; set; }
        public string SelectChannel { get; set; }
        public string RecvSingalStrengthVDL { get; set; }
        public string FisrtSlotNumForFirstRecvMsg { get; set; }
        public string TimeOfMsgArrival { get; set; }
        public string SingalToNoiseRatio { get; set; }
        public string PreFrameCHLoad { get; set; }
        public string NumOfBadCRC { get; set; }
        public string ForecastCHLoad { get; set; }
        public string AverageNoiseLevel { get; set; }
        public string RecvSingalStrength { get; set; }
        public string ProVSISens4VDM { get; set; }
        public string ProVSISens4VDO { get; set; }
        public string ProFSRSens { get; set; }

        public string GetCMD()
        {
            try
            {
                string strCMD = string.Format("$--SPO,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
                    BaseID,
                    SelectChannel,
                    RecvSingalStrengthVDL,
                    FisrtSlotNumForFirstRecvMsg,
                    TimeOfMsgArrival,
                    SingalToNoiseRatio,
                    PreFrameCHLoad,
                    NumOfBadCRC,
                    ForecastCHLoad,
                    AverageNoiseLevel,
                    RecvSingalStrength,
                    ProVSISens4VDM,
                    ProVSISens4VDO,
                    ProFSRSens);
                strCMD += CommHelp.Get0xHH(strCMD);
                return strCMD;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }

    public class ATN
    {
        public string Seq { get; set; }
        public string Enable { get; set; }
        public string StartSlotA { get; set; }
        public string SendIntervalA { get; set; }
        public string StartSlotB { get; set; }
        public string SendIntervalB { get; set; }
        public string MMSI { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string PosAccuracy { get; set; }
        public string Latitude { get; set; }
        public string NS { get; set; }
        public string Longitude { get; set; }
        public string EW { get; set; }
        public string Size_A { get; set; }
        public string Size_B { get; set; }
        public string Size_C { get; set; }
        public string Size_D { get; set; }
        public string PosDeviceType { get; set; }
        public string TimeStamp { get; set; }
        public string OffPos_Indicator { get; set; }
        public string AtoNStatus { get; set; }
        public string RAIM_Flag { get; set; }
        public string Virtual_AtoN_Flag { get; set; }
        public string Assigned_Model_Flag { get; set; }
        /// <summary>
        /// 备用
        /// </summary>
        public string Spare { get; set; }

        public string GetCMD_ATN()
        {
            try
            {
                string strCMD = string.Format("$--ATN,{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23}",
                                                Seq,
                                                Enable,
                                                StartSlotA,
                                                SendIntervalA,
                                                //StartSlotB,
                                                //SendIntervalB,
                                                MMSI,
                                                Type,
                                                Name,
                                                PosAccuracy,
                                                Latitude,
                                                NS,
                                                Longitude,
                                                EW,
                                                Size_A,
                                                Size_B,
                                                Size_C,
                                                Size_D,
                                                PosDeviceType,
                                                TimeStamp,
                                                OffPos_Indicator,
                                                AtoNStatus,
                                                RAIM_Flag,
                                                Virtual_AtoN_Flag,
                                                Assigned_Model_Flag,
                                                Spare
                                                );
                strCMD += CommHelp.Get0xHH(strCMD);
                return strCMD;
            }
            catch (Exception)
            {
                return "";
            }
        }

    }

}
