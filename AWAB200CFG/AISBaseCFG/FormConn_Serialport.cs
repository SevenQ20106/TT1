using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace AISBaseCFG
{
    public partial class FormConn_Serialport : Form
    {
        public SerialImpl comm { get; set; }

        public FormConn_Serialport()
        {
            InitializeComponent();
            InitComList();
        }
        public FormConn_Serialport(SerialImpl conn)
        {
            InitializeComponent();
            InitComList();
            comm = conn;
            this.cbxPortName.Text = comm.comm.PortName;
            this.cbxBaudList.Text = comm.comm.BaudRate.ToString();
            this.button1.Text = "关闭";
        }


        static string[] DelRepeatData(string[] a)
        {
            int len = 0;
            string[] b = new string[a.Length];
            for (int i = 0; i < a.Length; i++, len++)
            {
                b[len] = a[i];
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        len--; break;
                    }
                }
            }
            string[] new_a = new string[len];
            for (int k = 0; k < len; k++)
            {
                new_a[k] = b[k];
            }
            return new_a;
        }

        private void InitComList()
        {
            cbxPortName.Items.Clear();
            //初始化下拉串口名称列表框
            string[] ports = SerialPort.GetPortNames();
            string[] portsTemp = DelRepeatData(ports);
            Array.Sort(portsTemp);
            cbxPortName.Items.AddRange(portsTemp);
            cbxPortName.SelectedIndex = cbxPortName.Items.Count > 0 ? 0 : -1;
            cbxBaudList.SelectedIndex = cbxBaudList.Items.IndexOf("115200");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "关闭")
            {
                try
                {
                    HandleRst rst = comm.OnStop();
                    comm.Dispose();
                    comm = null;
                }
                catch (Exception)
                {
                    throw;
                }
                button1.Text = "打开";
            }
            else
            {
                string portName = cbxPortName.SelectedItem.ToString();
                if (string.IsNullOrEmpty(portName))
                {
                    MessageBox.Show("请选择一个串口！！！");
                    return;
                }
                int BaudRate;
                if (!int.TryParse(cbxBaudList.Text, out BaudRate))
                {
                    MessageBox.Show("请选择一个波特率！！！");
                    return;
                }
                comm = new SerialImpl(portName, BaudRate);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
