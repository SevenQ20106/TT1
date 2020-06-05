namespace AISBaseCFG
{
    partial class FormDMS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ATN_LatSecond = new System.Windows.Forms.TextBox();
            this.txt_ATN_LatFen = new System.Windows.Forms.TextBox();
            this.label106 = new System.Windows.Forms.Label();
            this.txt_ATN_LatDu = new System.Windows.Forms.TextBox();
            this.txt_ATN_LongSeconds = new System.Windows.Forms.TextBox();
            this.label109 = new System.Windows.Forms.Label();
            this.txt_ATN_LongFen = new System.Windows.Forms.TextBox();
            this.txt_ATN_LongDu = new System.Windows.Forms.TextBox();
            this.label110 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "位置(度分秒格式)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_ATN_LatSecond);
            this.panel3.Controls.Add(this.txt_ATN_LatFen);
            this.panel3.Controls.Add(this.label106);
            this.panel3.Controls.Add(this.txt_ATN_LatDu);
            this.panel3.Controls.Add(this.txt_ATN_LongSeconds);
            this.panel3.Controls.Add(this.label109);
            this.panel3.Controls.Add(this.txt_ATN_LongFen);
            this.panel3.Controls.Add(this.txt_ATN_LongDu);
            this.panel3.Controls.Add(this.label110);
            this.panel3.Controls.Add(this.label104);
            this.panel3.Controls.Add(this.label103);
            this.panel3.Controls.Add(this.label108);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(190, 69);
            this.panel3.TabIndex = 37;
            // 
            // txt_ATN_LatSecond
            // 
            this.txt_ATN_LatSecond.Location = new System.Drawing.Point(132, 38);
            this.txt_ATN_LatSecond.MaxLength = 5;
            this.txt_ATN_LatSecond.Name = "txt_ATN_LatSecond";
            this.txt_ATN_LatSecond.Size = new System.Drawing.Size(36, 21);
            this.txt_ATN_LatSecond.TabIndex = 44;
            this.txt_ATN_LatSecond.TextChanged += new System.EventHandler(this.txt_ATN_LatSecond_TextChanged);
            // 
            // txt_ATN_LatFen
            // 
            this.txt_ATN_LatFen.Location = new System.Drawing.Point(102, 37);
            this.txt_ATN_LatFen.MaxLength = 2;
            this.txt_ATN_LatFen.Name = "txt_ATN_LatFen";
            this.txt_ATN_LatFen.Size = new System.Drawing.Size(20, 21);
            this.txt_ATN_LatFen.TabIndex = 43;
            this.txt_ATN_LatFen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ATN_LatFen.TextChanged += new System.EventHandler(this.txt_ATN_LatFen_TextChanged);
            this.txt_ATN_LatFen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(7, 38);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(47, 12);
            this.label106.TabIndex = 42;
            this.label106.Text = "纬 度：";
            // 
            // txt_ATN_LatDu
            // 
            this.txt_ATN_LatDu.Location = new System.Drawing.Point(60, 36);
            this.txt_ATN_LatDu.MaxLength = 2;
            this.txt_ATN_LatDu.Name = "txt_ATN_LatDu";
            this.txt_ATN_LatDu.Size = new System.Drawing.Size(28, 21);
            this.txt_ATN_LatDu.TabIndex = 41;
            this.txt_ATN_LatDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ATN_LatDu.TextChanged += new System.EventHandler(this.txt_ATN_LatDu_TextChanged);
            this.txt_ATN_LatDu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txt_ATN_LongSeconds
            // 
            this.txt_ATN_LongSeconds.Location = new System.Drawing.Point(132, 11);
            this.txt_ATN_LongSeconds.MaxLength = 5;
            this.txt_ATN_LongSeconds.Name = "txt_ATN_LongSeconds";
            this.txt_ATN_LongSeconds.Size = new System.Drawing.Size(36, 21);
            this.txt_ATN_LongSeconds.TabIndex = 39;
            this.txt_ATN_LongSeconds.TextChanged += new System.EventHandler(this.txt_ATN_LongSeconds_TextChanged);
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(85, 36);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(17, 12);
            this.label109.TabIndex = 45;
            this.label109.Text = "";
            // 
            // txt_ATN_LongFen
            // 
            this.txt_ATN_LongFen.Location = new System.Drawing.Point(102, 12);
            this.txt_ATN_LongFen.MaxLength = 2;
            this.txt_ATN_LongFen.Name = "txt_ATN_LongFen";
            this.txt_ATN_LongFen.Size = new System.Drawing.Size(20, 21);
            this.txt_ATN_LongFen.TabIndex = 38;
            this.txt_ATN_LongFen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ATN_LongFen.TextChanged += new System.EventHandler(this.txt_ATN_LongFen_TextChanged);
            this.txt_ATN_LongFen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // txt_ATN_LongDu
            // 
            this.txt_ATN_LongDu.Location = new System.Drawing.Point(60, 11);
            this.txt_ATN_LongDu.MaxLength = 3;
            this.txt_ATN_LongDu.Name = "txt_ATN_LongDu";
            this.txt_ATN_LongDu.Size = new System.Drawing.Size(28, 21);
            this.txt_ATN_LongDu.TabIndex = 36;
            this.txt_ATN_LongDu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ATN_LongDu.TextChanged += new System.EventHandler(this.txt_ATN_LongDu_TextChanged);
            this.txt_ATN_LongDu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_InputNUM_KeyPress);
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(7, 13);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(47, 12);
            this.label110.TabIndex = 37;
            this.label110.Text = "经 度：";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(122, 11);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(17, 12);
            this.label104.TabIndex = 50;
            this.label104.Text = "＇";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(122, 38);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(17, 12);
            this.label103.TabIndex = 51;
            this.label103.Text = "＇";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(85, 11);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(17, 12);
            this.label108.TabIndex = 40;
            this.label108.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 52;
            this.label1.Text = "″";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 53;
            this.label2.Text = "″";
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(85, 126);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(75, 23);
            this.BtnSet.TabIndex = 1;
            this.BtnSet.Text = "确认";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // FormDMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 160);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "位置经纬度格式";
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_ATN_LatSecond;
        private System.Windows.Forms.TextBox txt_ATN_LatFen;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.TextBox txt_ATN_LatDu;
        private System.Windows.Forms.TextBox txt_ATN_LongSeconds;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.TextBox txt_ATN_LongFen;
        private System.Windows.Forms.TextBox txt_ATN_LongDu;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSet;
    }
}