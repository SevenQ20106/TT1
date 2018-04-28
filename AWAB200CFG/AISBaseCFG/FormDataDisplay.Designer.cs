namespace AISBaseCFG
{
    partial class FormDataDisplay
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
            this.btnClearDiaplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbClearData = new System.Windows.Forms.CheckBox();
            this.rtb_Display = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearDiaplay
            // 
            this.btnClearDiaplay.Location = new System.Drawing.Point(12, 3);
            this.btnClearDiaplay.Name = "btnClearDiaplay";
            this.btnClearDiaplay.Size = new System.Drawing.Size(74, 26);
            this.btnClearDiaplay.TabIndex = 4;
            this.btnClearDiaplay.Text = "清空窗口";
            this.btnClearDiaplay.UseVisualStyleBackColor = true;
            this.btnClearDiaplay.Click += new System.EventHandler(this.btnClearDisplay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "保存窗口";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // ckbClearData
            // 
            this.ckbClearData.AutoSize = true;
            this.ckbClearData.Location = new System.Drawing.Point(402, 9);
            this.ckbClearData.Name = "ckbClearData";
            this.ckbClearData.Size = new System.Drawing.Size(72, 16);
            this.ckbClearData.TabIndex = 6;
            this.ckbClearData.Text = "自动清空";
            this.ckbClearData.UseVisualStyleBackColor = true;
            this.ckbClearData.CheckedChanged += new System.EventHandler(this.ckbClearData_CheckedChanged);
            // 
            // rtb_Display
            // 
            this.rtb_Display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Display.Location = new System.Drawing.Point(0, 35);
            this.rtb_Display.Name = "rtb_Display";
            this.rtb_Display.Size = new System.Drawing.Size(483, 325);
            this.rtb_Display.TabIndex = 7;
            this.rtb_Display.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 26);
            this.button2.TabIndex = 8;
            this.button2.Text = "暂停显示";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormDataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rtb_Display);
            this.Controls.Add(this.ckbClearData);
            this.Controls.Add(this.btnClearDiaplay);
            this.Controls.Add(this.button1);
            this.Name = "FormDataDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "通讯数据监视";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDataDisplay_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearDiaplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbClearData;
        private System.Windows.Forms.RichTextBox rtb_Display;
        private System.Windows.Forms.Button button2;
    }
}