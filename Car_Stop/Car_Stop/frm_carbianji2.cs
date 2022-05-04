using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;

namespace Car_Stop
{
    public partial class frm_carbianji2 : Form
    {
        public frm_carbianji2()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {

            string carno = txt_carno.Text;
            if (!string.IsNullOrEmpty(carno))
            {
                string sql = string.Format("select * from Park where CarNo='{0}'", carno);
                SqlConnection con = new SqlConnection(DBHelper.strConn);
                con.Open();
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    txt_money.Text = reader["Fee"].ToString();
                    txt_type.Text = reader["RateType"].ToString();
                    dtp_rutime.Text = reader["EnterTime"].ToString();
                    dtp_chutime.Text = reader["LeaveTime"].ToString();
                }
                reader.Close();
                //计算时间差
                txt_time.Text = DateDiff(Convert.ToDateTime(dtp_chutime.Text), Convert.ToDateTime(dtp_rutime.Text));
            }
            else
            {
                MessageBox.Show("车牌号不能为空！", "提示！");
            }

        }
        public string DateDiff(DateTime d1, DateTime d2)
        {
            string datediff = null;
            TimeSpan ts = d1.Subtract(d2).Duration();
            datediff = ts.Days.ToString() + "天" + ts.Hours.ToString() + "小时" + ts.Minutes.ToString() + "分钟" + ts.Seconds.ToString() + "秒";
            return datediff;
        }
        public Tuple<string, double> GetRate(int id)
        {
            string sql = string.Format("select * from Rate where RateId='{0}'", id);
            DataSet ds = new DataSet(sql);
            DataTable dt = ds.Tables[0];
            return new Tuple<string, double>(dt.Rows[0][1].ToString(), Convert.ToDouble(dt.Rows[0][3]));
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            if (txt_carno.Enabled == true)
            {
                string carno = txt_carno.Text.Trim();
                double fee = Convert.ToDouble(txt_money.Text.Trim());

                string type = txt_type.Text;
                DateTime dt = Convert.ToDateTime(dtp_chutime.Text);
                if (!String.IsNullOrEmpty(carno))
                {
                    string sql = string.Format("update Park set LeaveTime='{0}',Fee='{1}',RateType='{2}' where CarNo='{3}'", dt, fee, type, carno);
                    bool result = DBHelper.NonSelect(sql);
                    if (result == true)
                    {
                        MessageBox.Show("车辆数据更新成功！");
                        this.Close();

                    }
                }
            }
        }

        private void btn_quxiao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
