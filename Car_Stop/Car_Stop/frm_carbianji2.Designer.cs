namespace Car_Stop
{
    partial class frm_carbianji2
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
            this.txt_type = new System.Windows.Forms.TextBox();
            this.btn_quxiao = new System.Windows.Forms.Button();
            this.btn_sure = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.dtp_chutime = new System.Windows.Forms.DateTimePicker();
            this.dtp_rutime = new System.Windows.Forms.DateTimePicker();
            this.lbl_chutime = new System.Windows.Forms.Label();
            this.lbl_rutime = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.lbl_money = new System.Windows.Forms.Label();
            this.txt_carno = new System.Windows.Forms.TextBox();
            this.lbl_carno = new System.Windows.Forms.Label();
            this.grb_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_info
            // 
            this.grb_info.Controls.Add(this.txt_type);
            this.grb_info.Controls.Add(this.btn_quxiao);
            this.grb_info.Controls.Add(this.btn_sure);
            this.grb_info.Controls.Add(this.btn_select);
            this.grb_info.Controls.Add(this.dtp_chutime);
            this.grb_info.Controls.Add(this.dtp_rutime);
            this.grb_info.Controls.Add(this.lbl_chutime);
            this.grb_info.Controls.Add(this.lbl_rutime);
            this.grb_info.Controls.Add(this.lbl_type);
            this.grb_info.Controls.Add(this.txt_time);
            this.grb_info.Controls.Add(this.lbl_time);
            this.grb_info.Controls.Add(this.txt_money);
            this.grb_info.Controls.Add(this.lbl_money);
            this.grb_info.Controls.Add(this.txt_carno);
            this.grb_info.Controls.Add(this.lbl_carno);
            this.grb_info.Location = new System.Drawing.Point(27, 74);
            this.grb_info.Name = "grb_info";
            this.grb_info.Size = new System.Drawing.Size(727, 402);
            this.grb_info.TabIndex = 1;
            this.grb_info.TabStop = false;
            this.grb_info.Text = "出场信息";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(122, 223);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(406, 25);
            this.txt_type.TabIndex = 22;
            // 
            // btn_quxiao
            // 
            this.btn_quxiao.Location = new System.Drawing.Point(592, 304);
            this.btn_quxiao.Name = "btn_quxiao";
            this.btn_quxiao.Size = new System.Drawing.Size(75, 23);
            this.btn_quxiao.TabIndex = 21;
            this.btn_quxiao.Text = "取消";
            this.btn_quxiao.UseVisualStyleBackColor = true;
            this.btn_quxiao.Click += new System.EventHandler(this.btn_quxiao_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(592, 207);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(75, 23);
            this.btn_sure.TabIndex = 20;
            this.btn_sure.Text = "确认";
            this.btn_sure.UseVisualStyleBackColor = true;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(592, 102);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 19;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // dtp_chutime
            // 
            this.dtp_chutime.Location = new System.Drawing.Point(122, 338);
            this.dtp_chutime.Name = "dtp_chutime";
            this.dtp_chutime.Size = new System.Drawing.Size(406, 25);
            this.dtp_chutime.TabIndex = 17;
            // 
            // dtp_rutime
            // 
            this.dtp_rutime.Location = new System.Drawing.Point(122, 283);
            this.dtp_rutime.Name = "dtp_rutime";
            this.dtp_rutime.Size = new System.Drawing.Size(406, 25);
            this.dtp_rutime.TabIndex = 16;
            // 
            // lbl_chutime
            // 
            this.lbl_chutime.AutoSize = true;
            this.lbl_chutime.Location = new System.Drawing.Point(31, 348);
            this.lbl_chutime.Name = "lbl_chutime";
            this.lbl_chutime.Size = new System.Drawing.Size(82, 15);
            this.lbl_chutime.TabIndex = 14;
            this.lbl_chutime.Text = "出场时间：";
            // 
            // lbl_rutime
            // 
            this.lbl_rutime.AutoSize = true;
            this.lbl_rutime.Location = new System.Drawing.Point(31, 294);
            this.lbl_rutime.Name = "lbl_rutime";
            this.lbl_rutime.Size = new System.Drawing.Size(82, 15);
            this.lbl_rutime.TabIndex = 12;
            this.lbl_rutime.Text = "入场时间：";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(31, 233);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(82, 15);
            this.lbl_type.TabIndex = 10;
            this.lbl_type.Text = "费用类型：";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(122, 169);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(406, 25);
            this.txt_time.TabIndex = 9;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(31, 172);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(52, 15);
            this.lbl_time.TabIndex = 8;
            this.lbl_time.Text = "时长：";
            // 
            // txt_money
            // 
            this.txt_money.Location = new System.Drawing.Point(122, 107);
            this.txt_money.Name = "txt_money";
            this.txt_money.Size = new System.Drawing.Size(406, 25);
            this.txt_money.TabIndex = 7;
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.Location = new System.Drawing.Point(31, 110);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(52, 15);
            this.lbl_money.TabIndex = 6;
            this.lbl_money.Text = "费用：";
            // 
            // txt_carno
            // 
            this.txt_carno.Location = new System.Drawing.Point(122, 50);
            this.txt_carno.Name = "txt_carno";
            this.txt_carno.Size = new System.Drawing.Size(406, 25);
            this.txt_carno.TabIndex = 5;
            // 
            // lbl_carno
            // 
            this.lbl_carno.AutoSize = true;
            this.lbl_carno.Location = new System.Drawing.Point(31, 53);
            this.lbl_carno.Name = "lbl_carno";
            this.lbl_carno.Size = new System.Drawing.Size(67, 15);
            this.lbl_carno.TabIndex = 4;
            this.lbl_carno.Text = "车牌号：";
            // 
            // frm_carbianji2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 550);
            this.Controls.Add(this.grb_info);
            this.Name = "frm_carbianji2";
            this.Text = "停车信息编辑";
            this.grb_info.ResumeLayout(false);
            this.grb_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_info;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Button btn_quxiao;
        private System.Windows.Forms.Button btn_sure;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.DateTimePicker dtp_chutime;
        private System.Windows.Forms.DateTimePicker dtp_rutime;
        private System.Windows.Forms.Label lbl_chutime;
        private System.Windows.Forms.Label lbl_rutime;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.TextBox txt_carno;
        private System.Windows.Forms.Label lbl_carno;
    }
}