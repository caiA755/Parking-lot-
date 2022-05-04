namespace Car_Stop
{
    partial class frm_Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_zi = new System.Windows.Forms.Button();
            this.btn_yong = new System.Windows.Forms.Button();
            this.btn_che = new System.Windows.Forms.Button();
            this.btn_ting = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(460, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前用户为：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btn_zi);
            this.groupBox1.Controls.Add(this.btn_yong);
            this.groupBox1.Controls.Add(this.btn_che);
            this.groupBox1.Controls.Add(this.btn_ting);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(99, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "菜单";
            // 
            // btn_zi
            // 
            this.btn_zi.Location = new System.Drawing.Point(407, 169);
            this.btn_zi.Name = "btn_zi";
            this.btn_zi.Size = new System.Drawing.Size(185, 33);
            this.btn_zi.TabIndex = 5;
            this.btn_zi.Text = "资费信息管理";
            this.btn_zi.UseVisualStyleBackColor = true;
            this.btn_zi.Click += new System.EventHandler(this.btn_zi_Click);
            // 
            // btn_yong
            // 
            this.btn_yong.Location = new System.Drawing.Point(127, 169);
            this.btn_yong.Name = "btn_yong";
            this.btn_yong.Size = new System.Drawing.Size(185, 33);
            this.btn_yong.TabIndex = 4;
            this.btn_yong.Text = "用户信息管理";
            this.btn_yong.UseVisualStyleBackColor = true;
            this.btn_yong.Click += new System.EventHandler(this.btn_yong_Click);
            // 
            // btn_che
            // 
            this.btn_che.Location = new System.Drawing.Point(407, 90);
            this.btn_che.Name = "btn_che";
            this.btn_che.Size = new System.Drawing.Size(185, 33);
            this.btn_che.TabIndex = 3;
            this.btn_che.Text = "车辆信息管理";
            this.btn_che.UseVisualStyleBackColor = true;
            this.btn_che.Click += new System.EventHandler(this.btn_che_Click);
            // 
            // btn_ting
            // 
            this.btn_ting.Location = new System.Drawing.Point(127, 90);
            this.btn_ting.Name = "btn_ting";
            this.btn_ting.Size = new System.Drawing.Size(185, 33);
            this.btn_ting.TabIndex = 2;
            this.btn_ting.Text = "停车信息管理";
            this.btn_ting.UseVisualStyleBackColor = true;
            this.btn_ting.Click += new System.EventHandler(this.btn_ting_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_user.ForeColor = System.Drawing.Color.Navy;
            this.lbl_user.Location = new System.Drawing.Point(649, 55);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(23, 24);
            this.lbl_user.TabIndex = 3;
            this.lbl_user.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(830, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "密码修改";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_close
            // 
            this.lbl_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_close.Location = new System.Drawing.Point(798, 460);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(58, 24);
            this.lbl_close.TabIndex = 5;
            this.lbl_close.Text = "退出";
            this.lbl_close.Click += new System.EventHandler(this.label4_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car_Stop.Properties.Resources.car6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 503);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Main";
            this.Text = "停车管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_zi;
        private System.Windows.Forms.Button btn_yong;
        private System.Windows.Forms.Button btn_che;
        private System.Windows.Forms.Button btn_ting;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_close;
    }
}