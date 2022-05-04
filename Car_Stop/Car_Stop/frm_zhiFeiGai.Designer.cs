namespace Car_Stop
{
    partial class frm_zhiFeiGai
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
            this.btn_修改 = new System.Windows.Forms.Button();
            this.txt_danwei = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "资费类型：";
            // 
            // btn_修改
            // 
            this.btn_修改.Location = new System.Drawing.Point(190, 273);
            this.btn_修改.Name = "btn_修改";
            this.btn_修改.Size = new System.Drawing.Size(101, 34);
            this.btn_修改.TabIndex = 2;
            this.btn_修改.Text = "修改";
            this.btn_修改.UseVisualStyleBackColor = true;
            this.btn_修改.Click += new System.EventHandler(this.btn_修改_Click);
            // 
            // txt_danwei
            // 
            this.txt_danwei.Enabled = false;
            this.txt_danwei.Location = new System.Drawing.Point(162, 141);
            this.txt_danwei.Name = "txt_danwei";
            this.txt_danwei.Size = new System.Drawing.Size(205, 25);
            this.txt_danwei.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "单位：";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(162, 201);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(205, 25);
            this.txt_price.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "价格：";
            // 
            // txt_type
            // 
            this.txt_type.Enabled = false;
            this.txt_type.Location = new System.Drawing.Point(162, 85);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(205, 25);
            this.txt_type.TabIndex = 7;
            // 
            // frm_zhiFeiGai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 365);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_danwei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_修改);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_zhiFeiGai";
            this.Text = "资费信息修改";
            this.Load += new System.EventHandler(this.frm_zhiFeiGai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_修改;
        private System.Windows.Forms.TextBox txt_danwei;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_type;
    }
}