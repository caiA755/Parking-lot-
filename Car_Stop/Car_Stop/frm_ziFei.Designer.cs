namespace Car_Stop
{
    partial class frm_ziFei
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ziFei));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgv_ziFei = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_xiuGai = new System.Windows.Forms.ToolStripButton();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanwei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZifei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_gai = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ziFei)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_xiuGai});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgv_ziFei
            // 
            this.dgv_ziFei.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ziFei.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ziFei.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colType,
            this.colDanwei,
            this.colZifei});
            this.dgv_ziFei.Location = new System.Drawing.Point(46, 84);
            this.dgv_ziFei.Name = "dgv_ziFei";
            this.dgv_ziFei.RowTemplate.Height = 27;
            this.dgv_ziFei.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ziFei.Size = new System.Drawing.Size(686, 348);
            this.dgv_ziFei.TabIndex = 2;
            this.dgv_ziFei.Click += new System.EventHandler(this.dgv_ziFei_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_xiuGai
            // 
            this.btn_xiuGai.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_xiuGai.Image = ((System.Drawing.Image)(resources.GetObject("btn_xiuGai.Image")));
            this.btn_xiuGai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_xiuGai.Name = "btn_xiuGai";
            this.btn_xiuGai.Size = new System.Drawing.Size(43, 24);
            this.btn_xiuGai.Text = "修改";
            this.btn_xiuGai.Click += new System.EventHandler(this.btn_xiuGai_Click);
            // 
            // colType
            // 
            this.colType.DataPropertyName = "type";
            this.colType.HeaderText = "资费类型";
            this.colType.Name = "colType";
            // 
            // colDanwei
            // 
            this.colDanwei.DataPropertyName = "unit";
            this.colDanwei.HeaderText = "单位";
            this.colDanwei.Name = "colDanwei";
            // 
            // colZifei
            // 
            this.colZifei.DataPropertyName = "postage";
            this.colZifei.HeaderText = "资费";
            this.colZifei.Name = "colZifei";
            // 
            // timer_gai
            // 
            this.timer_gai.Tick += new System.EventHandler(this.timer_gai_Tick);
            // 
            // frm_ziFei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 485);
            this.Controls.Add(this.dgv_ziFei);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_ziFei";
            this.Text = "资费列表";
            this.Load += new System.EventHandler(this.frm_ziFei_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ziFei)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_xiuGai;
        private System.Windows.Forms.DataGridView dgv_ziFei;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanwei;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZifei;
        private System.Windows.Forms.Timer timer_gai;

    }
}