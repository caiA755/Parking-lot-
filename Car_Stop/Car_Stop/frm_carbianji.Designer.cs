namespace Car_Stop
{
    partial class frm_carbianji
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
            this.grb_info = new System.Windows.Forms.GroupBox();
            this.btn_sure = new System.Windows.Forms.Button();
            this.txt_carno = new System.Windows.Forms.TextBox();
            this.lbl_carno = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_info
            // 
            this.grb_info.Controls.Add(this.button1);
            this.grb_info.Controls.Add(this.btn_sure);
            this.grb_info.Controls.Add(this.txt_carno);
            this.grb_info.Controls.Add(this.lbl_carno);
            this.grb_info.Location = new System.Drawing.Point(36, 157);
            this.grb_info.Name = "grb_info";
            this.grb_info.Size = new System.Drawing.Size(723, 199);
            this.grb_info.TabIndex = 1;
            this.grb_info.TabStop = false;
            this.grb_info.Text = "入场信息";
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(157, 132);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(107, 32);
            this.btn_sure.TabIndex = 4;
            this.btn_sure.Text = "确认";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // txt_carno
            // 
            this.txt_carno.Location = new System.Drawing.Point(157, 59);
            this.txt_carno.Name = "txt_carno";
            this.txt_carno.Size = new System.Drawing.Size(495, 25);
            this.txt_carno.TabIndex = 3;
            // 
            // lbl_carno
            // 
            this.lbl_carno.AutoSize = true;
            this.lbl_carno.Location = new System.Drawing.Point(66, 62);
            this.lbl_carno.Name = "lbl_carno";
            this.lbl_carno.Size = new System.Drawing.Size(67, 15);
            this.lbl_carno.TabIndex = 2;
            this.lbl_carno.Text = "车牌号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "取消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_carbianji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 513);
            this.Controls.Add(this.grb_info);
            this.Name = "frm_carbianji";
            this.Text = "停车信息编辑";
            this.grb_info.ResumeLayout(false);
            this.grb_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_info;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.TextBox txt_carno;
        private System.Windows.Forms.Label lbl_carno;
        private System.Windows.Forms.Button button1;
    }
}