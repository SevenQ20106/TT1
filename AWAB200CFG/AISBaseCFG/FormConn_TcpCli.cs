using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISBaseCFG
{
    public partial class FormConn_TcpCli : Form
    {
        public FormConn_TcpCli()
        {
            InitializeComponent();
#if DEBUG
            RemoteIP.Text = "192.168.16.253";
            RemotePort.Text = "4577";
#endif
        }

        public FormConn_TcpCli(TcpCliImpl cliConn)
        {
            InitializeComponent();
            conn = cliConn;
            RemoteIP.Text = ((System.Net.IPEndPoint)conn.ClientSession.ClientSocket.RemoteEndPoint).Address.ToString();
            RemotePort.Text = ((System.Net.IPEndPoint)conn.ClientSession.ClientSocket.RemoteEndPoint).Port.ToString();
            this.btnConn.Text = "断开";
        }

        public TcpCliImpl conn { get; set; }

        private void btnConn_Click(object sender, EventArgs e)
        {
            if (this.btnConn.Text == "断开")
            {
                try
                {
                    HandleRst rst = conn.OnStop();
                    conn.Dispose();
                    conn = null;
                }
                catch (Exception)
                {
                    throw;
                }
                btnConn.Text = "连接";
            }
            else
            {
                string strIP = RemoteIP.Text.Trim();
                try
                {
                    IPAddress ip = IPAddress.Parse(strIP);
                }
                catch (Exception)
                {
                    MessageBox.Show("IP格式有错误，请重新输入！");
                    return;
                }
                int port = 0;
                try
                {
                    bool bflag = int.TryParse(RemotePort.Text.Trim(), out port);
                    if (!bflag)
                    {
                        MessageBox.Show("端口输入有错误，请重新输入！");
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("端口输入有错误，请重新输入！");
                    return;
                }
                conn = new TcpCliImpl(strIP, port);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
