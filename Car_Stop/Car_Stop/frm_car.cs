using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Stop
{
    public partial class frm_car : Form
    {
        public frm_car()
        {
            InitializeComponent();
        }

        private void frm_car_Load(object sender, EventArgs e)
        {
            string a = string.Format("select CarNo,Model,Color,ExpiryDate,CarOwner,Tel,PositionId,UpdateTime from Car");
            DataSet b = DBHelper.Select(a);
            DataTable c = b.Tables[0];
            dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewMethod();
        }
        private void NewMethod()
        {
            string a = textBox1.Text.Trim();
            string b = textBox2.Text.Trim();
            string c = string.Format("select * from Car where CarNo like '%{0}%' and CarOwner like '%{1}%'", a, b);
            DataSet d = DBHelper.Select(c);
            DataTable e = d.Tables[0];
            this.dataGridView1.DataSource = e;

        }
        public static int AAA = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            string c = string.Format("select CarNo,Model,Color,ExpiryDate,CarOwner,Tel,PositionId,UpdateTime from Car");
            DataSet d = DBHelper.Select(c);
            DataTable ee = d.Tables[0];
            this.dataGridView1.DataSource = ee;
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_add.Start();
            frm_carTianjia a = new frm_carTianjia();
            a.Show();
            if (AAA == 1)
            {
                string c = string.Format("select * from Car");
                DataSet d = DBHelper.Select(c);
                DataTable ee = d.Tables[0];
                this.dataGridView1.DataSource = ee;
            }
        }
        public static string CPH;
        public static string CLXH;
        public static string YS;
        public static DateTime YXQ;
        public static string CZ;
        public static string DH;
        public static string CW;
        public static DateTime GXSJ;

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_xiugai.Start();
            CPH = dataGridView1.SelectedRows[0].Cells["CarNo"].Value.ToString();
            CLXH = dataGridView1.SelectedRows[0].Cells["Model"].Value.ToString();
            YS = dataGridView1.SelectedRows[0].Cells["Color"].Value.ToString();
            YXQ = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["ExpiryDate"].Value.ToString());

            CZ = dataGridView1.SelectedRows[0].Cells["CarOwner"].Value.ToString();
            DH = dataGridView1.SelectedRows[0].Cells["Tel"].Value.ToString();
            CW = dataGridView1.SelectedRows[0].Cells["PositionId"].Value.ToString();
            GXSJ = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["UpdateTime"].Value.ToString());

            frm_carShanchu a = new frm_carShanchu();
            a.Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.SelectedRows[0].Cells["CarOwner"].Value.ToString();
            string a = string.Format("delete from Car where CarOwner='{0}'", name);
            bool T = DBHelper.NonSelect(a);
            if (T)
            {
                MessageBox.Show("删除成功");
                string aa = string.Format("select CarNo,Model,Color,ExpiryDate,CarOwner,Tel,PositionId,UpdateTime from Car");
                DataSet b = DBHelper.Select(aa);
                DataTable c = b.Tables[0];
                dataGridView1.AutoGenerateColumns = false;
                this.dataGridView1.DataSource = c;
             }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void timer_add_Tick(object sender, EventArgs e)
        {
            string a = string.Format("select CarNo,Model,Color,ExpiryDate,CarOwner,Tel,PositionId,UpdateTime from Car");
            DataSet b = DBHelper.Select(a);
            DataTable c = b.Tables[0];
            this.dataGridView1.DataSource = c;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            timer_add.Stop();
            timer_xiugai.Stop();
        }

        private void timer_xiugai_Tick(object sender, EventArgs e)
        {
            string a = string.Format("select CarNo,Model,Color,ExpiryDate,CarOwner,Tel,PositionId,UpdateTime from Car");
            DataSet b = DBHelper.Select(a);
            DataTable c = b.Tables[0];
            this.dataGridView1.DataSource = c;
        }
    }
}
