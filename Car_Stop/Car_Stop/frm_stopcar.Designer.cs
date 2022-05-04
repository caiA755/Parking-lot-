namespace Car_Stop
{
    partial class frm_stopcar
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_carno = new System.Windows.Forms.TextBox();
            this.lbl_carno = new System.Windows.Forms.Label();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.车辆入场ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.车辆出场ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_select);
            this.groupBox1.Controls.Add(this.txt_carno);
            this.groupBox1.Controls.Add(this.lbl_carno);
            this.groupBox1.Location = new System.Drawing.Point(159, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(664, 25);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 25);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "查询";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_carno
            // 
            this.txt_carno.Location = new System.Drawing.Point(112, 22);
            this.txt_carno.Name = "txt_carno";
            this.txt_carno.Size = new System.Drawing.Size(495, 25);
            this.txt_carno.TabIndex = 1;
            // 
            // lbl_carno
            // 
            this.lbl_carno.AutoSize = true;
            this.lbl_carno.Location = new System.Drawing.Point(21, 25);
            this.lbl_carno.Name = "lbl_carno";
            this.lbl_carno.Size = new System.Drawing.Size(67, 15);
            this.lbl_carno.TabIndex = 0;
            this.lbl_carno.Text = "车牌号：";
            // 
            // dgv_info
            // 
            this.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgv_info.Location = new System.Drawing.Point(52, 157);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowHeadersWidth = 51;
            this.dgv_info.RowTemplate.Height = 27;
            this.dgv_info.Size = new System.Drawing.Size(1051, 331);
            this.dgv_info.TabIndex = 6;
            this.dgv_info.Click += new System.EventHandler(this.dgv_info_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CarNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "车牌号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ParkId";
            this.dataGridViewTextBoxColumn2.HeaderText = "编号";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EnterTime";
            this.dataGridViewTextBoxColumn3.HeaderText = "入场时间";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LeaveTime";
            this.dataGridViewTextBoxColumn4.HeaderText = "出场时间";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fee";
            this.dataGridViewTextBoxColumn5.HeaderText = "费用";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RateType";
            this.dataGridViewTextBoxColumn6.HeaderText = "付费类型";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 车辆入场ToolStripMenuItem
            // 
            this.车辆入场ToolStripMenuItem.Name = "车辆入场ToolStripMenuItem";
            this.车辆入场ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.车辆入场ToolStripMenuItem.Text = "车辆入场";
            this.车辆入场ToolStripMenuItem.Click += new System.EventHandler(this.车辆入场ToolStripMenuItem_Click);
            // 
            // 车辆出场ToolStripMenuItem
            // 
            this.车辆出场ToolStripMenuItem.Name = "车辆出场ToolStripMenuItem";
            this.车辆出场ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.车辆出场ToolStripMenuItem.Text = "车辆出场";
            this.车辆出场ToolStripMenuItem.Click += new System.EventHandler(this.车辆出场ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.车辆入场ToolStripMenuItem,
            this.车辆出场ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1115, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frm_stopcar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 604);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_stopcar";
            this.Text = "停车列表";
            this.Load += new System.EventHandler(this.frm_stopcar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox txt_carno;
        private System.Windows.Forms.Label lbl_carno;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 车辆入场ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 车辆出场ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}