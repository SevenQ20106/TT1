using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Runtime.InteropServices;
using System.Reflection;

namespace AISBaseCFG
{
    public class CommHelp
    {
        [DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        private static extern int RegCloseKey(int hKey);

        [DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true, EntryPoint = "RegOpenKeyA")]
        private static extern int RegOpenKey(uint hKey, string lpSubKey, ref int phkResult);

        [DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true, EntryPoint = "RegEnumValueA")]
        private static extern int RegEnumValue(int hKey, int dwIndex, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValueName, ref int lpcbValueName, int lpReserved, int lpType, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpData, ref int lpcbData);

        /// <summary>
        /// 获取当前计算机的串口名称数组
        /// </summary>
        /// <returns></returns>
        public static string[] GetSerialPortNames()
        {
            #region 方式一：调用系统API（DLL文件：advapi32.dll）读取注册表，并处理读取结果的“字符串结束符”
            string[] ports = null;
            List<string> portsList = new List<string>();
            uint HKEY_LOCAL_MACHINE = 0x80000002;
            int hKey = -1;
            int ret = RegOpenKey(HKEY_LOCAL_MACHINE, @"Hardware\DEVICEMAP\SERIALCOMM", ref hKey);
            try
            {
                if (ret == 0)
                {
                    int index = 0;
                    int BufferSize = 255;
                    int ERROR_NO_MORE_ITEMS = 259;
                    string valueName = "".PadRight(BufferSize, ' ');
                    int valueNameLength = BufferSize;
                    int valueLength = BufferSize;
                    string value = "".PadRight(BufferSize, ' ');
                    while (RegEnumValue(hKey, index, ref valueName, ref valueNameLength, 0, 0, ref value, ref valueLength) != ERROR_NO_MORE_ITEMS)
                    {
                        if (valueLength > 0)
                        {
                            if (value[valueLength - 1] == 0)
                                valueLength -= 1;
                            portsList.Add(value.Substring(0, valueLength));
                        }
                        index += 1;
                        valueName = "".PadRight(BufferSize, ' ');
                        valueNameLength = BufferSize;
                        valueLength = BufferSize;
                    }
                }
            }
            catch (Exception)
            {
            }
            finally 
            {
                if (ret == 0)
                    RegCloseKey(hKey);
            }
            if (portsList.Count == 0)
                ports = new string[0];
            else
                ports = portsList.ToArray();
            return ports;
            #endregion

            #region 方式二：C#方式读取注册表后过滤非数字（此方式无法过滤数字，可能造成部分虚拟串口获取错误，例如 COM3 识别为 COM32）
            //HashSet<char> numbers = new HashSet<char>(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            //string[] ports = null;

            //RegistryKey localMachine = null;
            //RegistryKey subKey = null;
            //new RegistryPermission(RegistryPermissionAccess.Read, @"HKEY_LOCAL_MACHINE\HARDWARE\DEVICEMAP\SERIALCOMM").Assert();
            //try
            //{
            //    localMachine = Registry.LocalMachine;
            //    subKey = localMachine.OpenSubKey(@"HARDWARE\DEVICEMAP\SERIALCOMM", false);
            //    if (subKey != null)
            //    {
            //        string[] valueNames = subKey.GetValueNames();
            //        ports = new string[valueNames.Length];
            //        for (int j = 0; j < valueNames.Length; j++)
            //        {
            //            object obj = subKey.GetValue(valueNames[j]);
            //            if (obj == null)
            //                continue;
            //            string str = (string)obj;
            //            if (string.IsNullOrEmpty(str) || str.Length < 4)
            //                continue;

            //            string port = "COM";
            //            char[] cs = str.Substring(3).Replace("\n", "").ToCharArray();
            //            foreach (char c in cs)
            //            {
            //                if (numbers.Contains(c))
            //                    port += c.ToString();
            //                else
            //                    break;
            //            }
            //            ports[j] = port;
            //        }
            //    }
            //}
            //finally
            //{
            //    if (localMachine != null)
            //        localMachine.Close();
            //    if (subKey != null)
            //        subKey.Close();
            //    System.Security.CodeAccessPermission.RevertAssert();
            //}

            //if (ports == null)
            //    ports = new string[0];
            //return ports;
            #endregion
        }

        #region 公共函数
        /// <summary> 
        /// 解析报文 
        /// </summary> 
        /// <param name="rawDatagram">原始数据,返回未使用的报文片断, 
        /// 该片断会保存在Session的Datagram对象中</param> 
        /// <returns>报文数组,原始数据可能包含多个报文</returns> 
        public static string[] Resolve(ref string rawDatagram)
        {
            ArrayList datagrams = new ArrayList();
            //末尾标记位置索引 
            int tagIndex = -1;
            string endTag = "\n";
            while (true)
            {
                tagIndex = rawDatagram.IndexOf(endTag, tagIndex + 1);
                if (tagIndex == -1)
                {
                    break;
                }
                else
                {
                    //按照末尾标记把字符串分为左右两个部分 
                    string newDatagram = rawDatagram.Substring(
                    0, tagIndex + endTag.Length);
                    datagrams.Add(newDatagram);
                    if (tagIndex + endTag.Length >= rawDatagram.Length)
                    {
                        rawDatagram = "";
                        break;
                    }
                    rawDatagram = rawDatagram.Substring(tagIndex + endTag.Length,
                    rawDatagram.Length - newDatagram.Length);
                    //从开始位置开始查找 
                    tagIndex = 0;
                }
            }
            string[] results = new string[datagrams.Count];
            datagrams.CopyTo(results);
            return results;
        }

        /// <summary>
        /// 校验数据
        /// </summary>
        /// <param name="CheckStr"></param>
        /// <returns></returns>
        public static bool CheckData(string CheckStr)
        {
            if (!CheckStr.Contains("!") || !CheckStr.Contains("*") || CheckStr.Length < 10)
            {
                return false;
            }
            string strHead = CheckStr.Substring(3, 3);
            if (strHead != "VDS" && strHead != "CMD" && strHead != "VDM" && strHead != "VDO")
            {
                return false;
            }
            int iPos1 = CheckStr.IndexOf("!");
            int iPos2 = CheckStr.IndexOf("*");
            if (iPos1 == -1 || iPos2 == -1 || iPos1 > iPos2 || iPos2 != CheckStr.Length - 5)
            {
                return false;
            }
            //需要计算校验和部分的报文，*号前所有，除了!
            byte check = 0;
            for (int j = iPos1 + 1; j < iPos2; j++)
            {
                check = (byte)(check ^ (byte)(char)CheckStr[j]);
            }
            byte check_H, check_L;
            check_H = check_L = check;
            check_H = (byte)(check_H >> 4);

            if (check_H > 9)
                check_H = (byte)(check_H + 55);
            else
                check_H = (byte)(check_H + 48);

            check_L = (byte)((check_L & 0x0f));
            if (check_L > 9)
                check_L = (byte)(check_L + 55);
            else
                check_L = (byte)(check_L + 48);

            if ((byte)CheckStr[iPos2 + 1] == check_H && (byte)CheckStr[iPos2 + 2] == check_L)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 获取校验和
        /// </summary>
        /// <param name="FrameMsg"></param>
        /// <returns></returns>
        public static string Get0xHH(string FrameMsg)
        {
            string Reback0xHH = "";
            //需要计算校验和部分的报文，*号钱所有，除了！
            int CheckTextLength = FrameMsg.Length;
            byte check = 0;
            for (int j = 1; j < CheckTextLength; j++)
            {
                check = (byte)(check ^ (byte)(char)FrameMsg[j]);
            }
            byte check_H, check_L;
            check_H = check_L = check;
            check_H = (byte)(check_H >> 4);

            if (check_H > 9)
                check_H = (byte)(check_H + 55);
            else
                check_H = (byte)(check_H + 48);

            check_L = (byte)((check_L & 0x0f));
            if (check_L > 9)
                check_L = (byte)(check_L + 55);
            else
                check_L = (byte)(check_L + 48);
            Reback0xHH += "*";
            char ch = (char)check_H;
            Reback0xHH += ch;
            ch = (char)check_L;
            Reback0xHH += ch;
            Reback0xHH += "\r\n";
            return Reback0xHH;
        }

        #endregion

        #region 方法
        /// <summary>
        /// 比较--两个类型一样的实体类对象的值
        /// </summary>
        /// <param name="oneT"></param>
        /// <returns></returns>
        private bool CompareType<T>(T oneT, T twoT)
        {
            #region
            bool result = true;//两个类型作比较时使用,如果有不一样的就false
            Type typeOne = oneT.GetType();
            Type typeTwo = twoT.GetType();
            //如果两个T类型不一样  就不作比较
            if (!typeOne.Equals(typeTwo)) { return false; }
            PropertyInfo[] pisOne = typeOne.GetProperties(); //获取所有公共属性(Public)
            PropertyInfo[] pisTwo = typeTwo.GetProperties();
            //如果长度为0返回false
            if (pisOne.Length <= 0 || pisTwo.Length <= 0)
            {
                return false;
            }
            //如果长度不一样，返回false
            if (!(pisOne.Length.Equals(pisTwo.Length))) { return false; }
            //遍历两个T类型，遍历属性，并作比较
            for (int i = 0; i < pisOne.Length; i++)
            {
                //获取属性名
                string oneName = pisOne[i].Name;
                string twoName = pisTwo[i].Name;
                //获取属性的值
                object oneValue = pisOne[i].GetValue(oneT, null);
                object twoValue = pisTwo[i].GetValue(twoT, null);
                //比较,只比较值类型
                if ((pisOne[i].PropertyType.IsValueType || pisOne[i].PropertyType.Name.StartsWith("String")) && (pisTwo
[i].PropertyType.IsValueType || pisTwo[i].PropertyType.Name.StartsWith("String")))
                {
                    if (oneName.Equals(twoName))
                    {
                        if (oneValue == null)
                        {
                            if (twoValue != null)
                            {
                                result = false;
                                break; //如果有不一样的就退出循环
                            }
                        }
                        else if (oneValue != null)
                        {
                            if (twoValue != null)
                            {
                                if (!oneValue.Equals(twoValue))
                                {
                                    result = false;
                                    break; //如果有不一样的就退出循环
                                }
                            }
                            else if (twoValue == null)
                            {
                                result = false;
                                break; //如果有不一样的就退出循环
                            }
                        }
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }
                else
                {
                    //如果对象中的属性是实体类对象，递归遍历比较
                    bool b = CompareType(oneValue, twoValue);
                    if (!b) { result = b; break; }
                }
            }
            return result;
            #endregion
        }
        #endregion
    }
}
