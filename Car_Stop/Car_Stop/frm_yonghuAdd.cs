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
    public partial class frm_yonghuAdd : Form
    {
        public frm_yonghuAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into UserInfo(UserAccount,UserName,Userpassword,userdelete,userStatus) values('{0}','{1}','{2}','{3}','{4}')", textBox1.Text.Trim(), textBox2.Text.Trim(),"123456","False",comboBox1.Text.Trim());
            bool boy = DBHelper.NonSelect(sql);
            if (boy)
            {
                MessageBox.Show("添加成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
