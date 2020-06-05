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
    public partial class FormDMS : Form
    {
        public FormDMS()
        {
            InitializeComponent();
        }

        public int LongDu, LongMin, LatDu, LatMin;
        public float LongSec, LatSec;

        private void txt_InputNUM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //只允许输入数字，粘贴数字
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == (char)8 || e.KeyChar == (char)3 || e.KeyChar == (char)22 || e.KeyChar == (char)32))
            {
                e.Handled = true;
            }
            e.KeyChar = char.ToUpper(e.KeyChar);
            try
            {
                if (e.KeyChar == (char)22)
                {
                    Convert.ToInt64(Clipboard.GetText());  //检查是否数字
                    Clipboard.SetText(Clipboard.GetText().Trim()); //去空格
                }
            }
            catch (Exception)
            {
                e.Handled = true;
                //throw;
            }
        }

        private void txt_ATN_LongDu_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            bool bFlag;
            float iTemp;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                bFlag = float.TryParse(txtBox.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    MessageBox.Show("经度：度只能是【0到181之间】！\r\n");
                    txtBox.Focus();
                }
                else
                {
                    if (iTemp < 0 || iTemp > 181)
                    {
                        MessageBox.Show("经度：度只能是【0到181之间】！\r\n");
                        txtBox.Focus();
                        txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
                    }
                    if (iTemp == 181)
                    {
                        txt_ATN_LongDu.Text = "0";
                    }
                }
            }
        }

        private void txt_ATN_LatDu_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            bool bFlag;
            float iTemp;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                bFlag = float.TryParse(txtBox.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    MessageBox.Show("纬度：度只能是【0到91之间】！\r\n");
                    txtBox.Focus();
                }
                else
                {
                    if (iTemp < 0 || iTemp > 91)
                    {
                        MessageBox.Show("纬度：度只能是【0到91之间】！\r\n");
                        txtBox.Focus();
                        txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
                    }
                    if (iTemp == 181)
                    {
                        txt_ATN_LatDu.Text = "0";
                    }
                }
            }
        }

        private void txt_ATN_LongFen_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            bool bFlag;
            float iTemp;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                bFlag = float.TryParse(txtBox.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    MessageBox.Show("分只能是【0到60之间）！\r\n");
                    txtBox.Focus();
                }
                else
                {
                    if (iTemp < 0 || iTemp >= 60)
                    {
                        MessageBox.Show("分只能是【0到60之间）！\r\n");
                        txtBox.Focus();
                        txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
                    }
                }
            }
        }

        private void txt_ATN_LatFen_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            bool bFlag;
            float iTemp;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                bFlag = float.TryParse(txtBox.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    MessageBox.Show("分只能是【0到60之间）！\r\n");
                    txtBox.Focus();
                }
                else
                {
                    if (iTemp < 0 || iTemp >= 60)
                    {
                        MessageBox.Show("分只能是【0到60之间）！\r\n");
                        txtBox.Focus();
                        txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
                    }
                }
            }
        }

        private void txt_ATN_LongSeconds_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            bool bFlag;
            float iTemp;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                bFlag = float.TryParse(txtBox.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    MessageBox.Show("秒只能是【0到60之间）！\r\n");
                    txtBox.Focus();
                }
                else
                {
                    if (iTemp < 0 || iTemp >= 60)
                    {
                        MessageBox.Show("秒只能是【0到60之间）！\r\n");
                        txtBox.Focus();
                        txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
                    }
                }
            }
        }

        private void txt_ATN_LatSecond_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            bool bFlag;
            float iTemp;
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                bFlag = float.TryParse(txtBox.Text.Trim(), out iTemp);
                if (!bFlag)
                {
                    MessageBox.Show("秒只能是【0到60之间）！\r\n");
                    txtBox.Focus();
                }
                else
                {
                    if (iTemp < 0 || iTemp >= 60)
                    {
                        MessageBox.Show("秒只能是【0到60之间）！\r\n");
                        txtBox.Focus();
                        txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
                    }
                }
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            string strLong = "";
            if (string.IsNullOrEmpty(txt_ATN_LongDu.Text.Trim()))
            {
                LongDu = 0;
            }
            else
            {
                LongDu = int.Parse(txt_ATN_LongDu.Text.Trim());
            }
            if (string.IsNullOrEmpty(txt_ATN_LongFen.Text.Trim()))
            {
                LongMin = 0;
            }
            else
            {
                LongMin = int.Parse(txt_ATN_LongFen.Text.Trim());
            }
            if (string.IsNullOrEmpty(txt_ATN_LongSeconds.Text.Trim()))
            {
                LongSec = 0;
            }
            else
            {
                LongSec = float.Parse(txt_ATN_LongSeconds.Text.Trim());
            }


            if (string.IsNullOrEmpty(txt_ATN_LatDu.Text.Trim()))
            {
                LatDu = 0;
            }
            else
            {
                LatDu  = int.Parse(txt_ATN_LatDu.Text.Trim());
            }
            if (string.IsNullOrEmpty(txt_ATN_LatFen.Text.Trim()))
            {
                LatMin = 0;
            }
            else
            {
                LatMin = int.Parse(txt_ATN_LatFen.Text.Trim());
            }

            if (string.IsNullOrEmpty(txt_ATN_LatSecond.Text.Trim()))
            {
                LongSec = 0;
            }
            else
            {
                LongSec = float.Parse(txt_ATN_LongSeconds.Text.Trim());
            }

            DialogResult = DialogResult.OK;
        }


    }
}
