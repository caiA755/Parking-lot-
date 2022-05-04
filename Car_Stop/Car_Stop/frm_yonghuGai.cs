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
    public partial class frm_yonghuGai : Form
    {
        public frm_yonghuGai()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string userID;
        private void btn_ok_Click(object sender, EventArgs e)
        {

            
                string sql2 = string.Format("update UserInfo set UserName='{0}',UserAccount='{1}',UserStatus='{2}' where UserID='{3}'", txt_name.Text, txt_account.Text, txt_zhuangtai.Text, userID);
                bool result = DBHelper.NonSelect(sql2);
                if (result)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
         

        private void frm_yonghuGai_Load(object sender, EventArgs e)
        {
            txt_account.Text = frm_yonghu.useraccount;
            txt_name.Text = frm_yonghu.username;
            txt_zhuangtai.Text = frm_yonghu.userzhuangtai;
            if (txt_account.Text != "1234567")
            {
                string sql = string.Format("select UserID from UserInfo where UserName='{0}' and UserAccount='{1}'", txt_name.Text, txt_account.Text);
                DataSet ds = DBHelper.Select(sql);
                userID = ds.Tables[0].Rows[0]["UserID"].ToString();
            }
            else
            {
                txt_account.Enabled = false;
            }
        }
    }
}
