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
    public partial class frm_stopcar : Form
    {
        public frm_stopcar()
        {
            InitializeComponent();
        }

        private void 车辆入场ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            frm_carbianji b = new frm_carbianji();
            b.Show();
        }

        private void 车辆出场ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Start();
            frm_carbianji2 b = new frm_carbianji2();
            b.Show();
            //DateTime nowtime = System.DateTime.Now;

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            string carno = txt_carno.Text.Trim();
            string sql = string.Format("select * from Park where CarNo like '%{0}%' order by EnterTime desc ", carno);
            DataSet ds = DBHelper.Select(sql);
            DataTable dt = ds.Tables[0];
            dgv_info.DataSource = dt;
            //Type(dt);
        }

        private void frm_stopcar_Load(object sender, EventArgs e)
        {
            string sql = "select * from Park order by EnterTime desc";
            DataSet ds = DBHelper.Select(sql);
            DataTable dt = ds.Tables[0];
            dgv_info.DataSource = dt;
            //Type(dt);
        }

        private void timer_sx_Tick(object sender, EventArgs e)
        {

            string sql = "select * from Park order by EnterTime desc";
            DataSet ds = DBHelper.Select(sql);
            DataTable dt = ds.Tables[0];
            dgv_info.DataSource = dt;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sql = "select * from Park order by EnterTime desc";
            DataSet ds = DBHelper.Select(sql);
            DataTable dt = ds.Tables[0];
            dgv_info.DataSource = dt;
        }

        private void dgv_info_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        //private void Type(DataTable dt)
        //{
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        if (dgv_info.Rows[i].Cells["colratetype"].Value.ToString().Equals("3"))
        //        {
        //            dgv_info.Rows[i].Cells["colType"].Value = "年费车";
        //        }
        //        else
        //        {
        //            dgv_info.Rows[i].Cells["colType"].Value = "临时车";
        //        }
        //    }
        //}
    }
}
