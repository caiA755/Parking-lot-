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

namespace Car_Stop
{
    public partial class frm_carbianji : Form
    {
        public frm_carbianji()
        {
            InitializeComponent();
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            string sql = "";
            string carno = txt_carno.Text.Trim();
            if (String.IsNullOrEmpty(carno))
            {
                MessageBox.Show("车牌号不能为空！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(DBHelper.strConn);
                con.Open();
                string num = "";
                string sql1 = "select CarNo from Park";
                SqlCommand com = new SqlCommand(sql1, con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    num = reader["CarNo"].ToString();

                }
                reader.Close();
                if (num == carno)
                {
                    MessageBox.Show("该车牌号已存在，请重新输入新的车牌号。");
                }
                else
                {

                    //string sql2=string.Format("select count(*) from Car where CarNo='{0}'",txt_carno.Text.Trim());
                    //object ds=DBHelper.ExecuteScalar(sql2);
                    //int result=Convert.ToInt32(ds);
                    //if(result>0)
                    //{
                    //    sql=string.Format("insert into Park(CarNo,EnterTime,fee,ratetype) values ('{0}','{1}','{2}','{3}')", carno, System.DateTime.Now,"0","3");
                    //}
                    //else{
                    sql = string.Format("insert into Park(CarNo,EnterTime) values ('{0}','{1}')", carno, System.DateTime.Now);
                    //}                    }
                    bool a = DBHelper.NonSelect(sql);
                    if (a == true)
                    {
                        MessageBox.Show("车辆入场成功！", "提示", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("车辆入库失败！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }
}
