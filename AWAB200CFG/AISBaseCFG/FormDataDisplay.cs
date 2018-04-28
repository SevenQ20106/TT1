using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AISBaseCFG
{
    public partial class FormDataDisplay : Form
    {
        public FormDataDisplay()
        {
            InitializeComponent();
        }

        public  void ShowData(string Msg)
        {
            if (!bShowData)
            {
                return;
            }
            if (rtb_Display.InvokeRequired)
            {
                rtb_Display.Invoke(new EventHandler(delegate { ShowData(Msg); }));
            }
            else
            {
                if (bAutoClearData && rtb_Display.Lines.Length > 100)
                {
                    rtb_Display.Clear();
                }
                else if (rtb_Display.Lines.Length > 500)
                {
                    rtb_Display.Clear();
                }
                //让文本框获取焦点 
                //rtb_Display.Focus();
                //设置光标的位置到文本尾 
                rtb_Display.Select(rtb_Display.TextLength, 0);
                //滚动到控件光标处 
                rtb_Display.ScrollToCaret();
                rtb_Display.AppendText(Msg);
            }
        }

        public bool bShowData = true;
        private void button2_Click(object sender, EventArgs e)
        {
            bShowData = !bShowData;
            button2.Text = bShowData ? "暂停显示" : "继续显示";
        }

        private bool bAutoClearData = false;
        private void ckbClearData_CheckedChanged(object sender, EventArgs e)
        {
            bAutoClearData = ckbClearData.Checked;
        }

        private void btnClearDisplay_Click(object sender, EventArgs e)
        {
            rtb_Display.Clear();
        }

        public delegate void FormDisplayClosedEventHandle();

        public FormDisplayClosedEventHandle FormDisplayClosedHandle;

        private void FormDataDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormDisplayClosedHandle!=null)
            {
                FormDisplayClosedHandle();
            }
        }

      
    }
}
