using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Car_Stop
{
    public partial class frm_Pwd : Form
    {
        public frm_Pwd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string userAccount = frm_login.userAccount;
            string sql = string.Format("select * from UserInfo where UserAccount='{0}'",userAccount);
            DataSet ds = DBHelper.Select(sql);
            string pwd = ds.Tables[0].Rows[0]["UserPassword"].ToString();
            if (txt_yuan.Text.Trim() != pwd)
            {
                MessageBox.Show("原始密码错误");
            }
            else
            {
                if (txt_que.Text.Trim()!=txt_geng.Text.Trim())
                {
                    MessageBox.Show("两次输入的新密码不一致");
                }
                else 
                {
                    string sql3 = string.Format("update UserInfo set UserPassword='{0}' where UserAccount='{1}'",txt_que.Text.Trim(),userAccount);
                    bool result = DBHelper.NonSelect(sql3);
                    if (result)
                    {
                        MessageBox.Show("修改成功");
                        new frm_login().Show();
                     }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
            }
        }
    }
}
