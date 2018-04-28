//using DT.Comlib;
using System;
using System.Collections.Generic;
using System.Text;

namespace AISBaseCFG
{
    public delegate void OnRouteEventHandle(object obj, DTAEventArgs e);

    public delegate void OnErrorReport(object obj, int errorCode, string errorMsg);

    //public delegate void OnAccpetClientEventHandle(object obj, Session pClient);

    /// <summary>
    /// 断开通讯连接
    /// </summary>
    public delegate void OnStopEventHandle(object obj);

    public delegate void OnConnSvrEventHandle(object obj, IntPtr pServer);

    public abstract class ConnImpl : IDisposable
    {
        #region 属性定义
        /// <summary>
        /// 连接编号
        /// </summary>
        public IntPtr CId
        {
            get; set;
        }

        /// <summary>
        /// 连接名称
        /// </summary>
        public string CName
        {
            get; set;
        }

        /// <summary>
        /// 连接方式
        /// </summary>
        public ConnType CType
        {
            get;
            set;
        }

        /// <summary>
        /// 连接状态
        /// </summary>
        public ConnStatus CStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 数据方向
        /// </summary>
        public DataDriection CIO
        {
            get; set;
        }

        #endregion

        #region 事件声明
        /// <summary>
        /// 连接接收数据对外路由事件
        /// </summary>
        public OnRouteEventHandle onRoute_OutEventHandle;

        /// <summary>
        /// 
        /// </summary>
        public OnRouteEventHandle onRoute_InEventHandle;

        /// <summary>
        /// 错误报告
        /// </summary>
        public OnErrorReport onErrorReportHandle;

        public OnStopEventHandle onStopHandle;

        #endregion

        #region 抽象方法
        /// <summary>
        /// 注销释放
        /// </summary>
        public abstract void Dispose();

        /// <summary>
        /// 连接描述
        /// </summary>
        /// <returns></returns>
        public abstract string GetConnDesc();

        /// <summary>
        /// 启动
        /// </summary>
        /// <returns></returns>
        public abstract HandleRst OnStart();

        /// <summary>
        /// 关闭
        /// </summary>
        /// <returns></returns>
        public abstract HandleRst OnStop();

        /// <summary>
        /// 接收路由数据的实现
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        public abstract void OnRecvRouteDataEventHandle(object obj, DTAEventArgs e);


        #endregion

    }

    public class DTAEventArgs : EventArgs
    {
        public string[] FrameArray { get; set; }

        //public byte[] ByteArray { get; set; }
    }

    #region
    public enum ConnType
    {
        Serial,
        TcpCli,
        TcpSvr,
        Udp,
        Session
    }

    public enum ConnStatus
    {
        Null,
        Starting,
        Started,
        Closed,
        Error
    }

    public enum DataDriection
    {
        In,
        Out,
        IO
    }

    /// <summary>
    /// 事件通知处理结果,事件通知的返回值，不同的返回值会影响通信组件的后续行为
    /// </summary>
    public enum HandleRst
    {
        /// <summary>
        /// 成功
        /// </summary>
        Ok = 0,
        /// <summary>
        /// 忽略
        /// </summary>
        Ignore = 1,
        /// <summary>
        /// 错误
        /// </summary>
        Error = 2,
    };
    #endregion

    public enum OptDataType
    {
        StringArray,
        ByteArray
    }
}


