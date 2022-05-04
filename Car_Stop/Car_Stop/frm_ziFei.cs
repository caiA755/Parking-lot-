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
    public partial class frm_ziFei : Form
    {
        public frm_ziFei()
        {
            InitializeComponent();
        }

        private void frm_ziFei_Load(object sender, EventArgs e)
        {
            XianShi();
        }

        private void XianShi()
        {
            string sql = "select * from rate";
            DataTable dt = DBHelper.Select(sql).Tables[0];
            dgv_ziFei.AutoGenerateColumns = false;
            dgv_ziFei.DataSource = dt;
        }
        public static string type, unit, postage;
        private void btn_xiuGai_Click(object sender, EventArgs e)
        {
            timer_gai.Start();
             type = dgv_ziFei.SelectedRows[0].Cells["colType"].Value.ToString();
             unit = dgv_ziFei.SelectedRows[0].Cells["colDanwei"].Value.ToString();
             postage = dgv_ziFei.SelectedRows[0].Cells["colZiFei"].Value.ToString();
             frm_zhiFeiGai gai = new frm_zhiFeiGai();
             gai.ShowDialog();
        }

        private void timer_gai_Tick(object sender, EventArgs e)
        {
            XianShi();
        }

        private void dgv_ziFei_Click(object sender, EventArgs e)
        {
            timer_gai.Stop();
        }
    }
}
