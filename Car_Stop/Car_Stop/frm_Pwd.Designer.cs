namespace Car_Stop
{
    partial class frm_Pwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_yuan = new System.Windows.Forms.TextBox();
            this.txt_que = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_geng = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_geng);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_que);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_yuan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(69, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "密码修改";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始密码：";
            // 
            // txt_yuan
            // 
            this.txt_yuan.Location = new System.Drawing.Point(196, 82);
            this.txt_yuan.Name = "txt_yuan";
            this.txt_yuan.Size = new System.Drawing.Size(296, 25);
            this.txt_yuan.TabIndex = 1;
            this.txt_yuan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_que
            // 
            this.txt_que.Location = new System.Drawing.Point(196, 200);
            this.txt_que.Name = "txt_que";
            this.txt_que.Size = new System.Drawing.Size(296, 25);
            this.txt_que.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "确认密码：";
            // 
            // txt_geng
            // 
            this.txt_geng.Location = new System.Drawing.Point(196, 143);
            this.txt_geng.Name = "txt_geng";
            this.txt_geng.Size = new System.Drawing.Size(296, 25);
            this.txt_geng.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "更新密码：";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(274, 443);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 41);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(426, 443);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 41);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "取消";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_Pwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 576);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Pwd";
            this.Text = "停车信息管理系统";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_yuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_geng;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_que;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
    }
}