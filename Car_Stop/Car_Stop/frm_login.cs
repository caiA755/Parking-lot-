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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        public static string username;
        public static string userAccount;
        private void btn_login_Click(object sender, EventArgs e)
        {
            //查询是否存在此人
            string sql = string.Format("select count(*) from UserInfo where UserAccount='{0}' and UserPassword='{1}'",txt_account.Text.Trim(),txt_pwd.Text.Trim());
            //判断是否被禁用
            string sql2 = string.Format("select UserStatus,UserName,UserAccount from UserInfo where UserAccount='{0}' and UserPassword='{1}'", txt_account.Text.Trim(), txt_pwd.Text.Trim());
            DataSet ds = DBHelper.Select(sql2);
            bool userStatus;
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("你输入的信息有误，请确认！");
            }
            else
            {
               userStatus = Convert.ToBoolean(ds.Tables[0].Rows[0]["UserStatus"]);
               username = ds.Tables[0].Rows[0]["UserName"].ToString();
               userAccount = ds.Tables[0].Rows[0]["UserAccount"].ToString();
               if (userStatus)
               {
                   MessageBox.Show("该用户已被禁用");
               }
               else
               {
                   bool result = Convert.ToBoolean(DBHelper.ExecuteScalar(sql));
                   if (result == true)
                   {
                       MessageBox.Show("登录成功");
                       new frm_Main().ShowDialog();
                       this.Close();
                   }
                   else
                   {
                       MessageBox.Show("登录失败,请确认信息");
                   }
               }
            }
    
         
        }
    }
}
