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
    public partial class frm_yonghu : Form
    {
        public frm_yonghu()
        {
            InitializeComponent();
        }
        public static string username, useraccount, userzhuangtai;
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_add.Start();
            frm_yonghuAdd ff = new frm_yonghuAdd();
            ff.Show();
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer_gai.Start();
            useraccount = dataGridView1.SelectedRows[0].Cells["colUserAccount"].Value.ToString();
            username = dataGridView1.SelectedRows[0].Cells["colUserName"].Value.ToString();
            userzhuangtai = dataGridView1.SelectedRows[0].Cells["colStatus"].Value.ToString();
            frm_yonghuGai ff = new frm_yonghuGai();
            ff.Show();
        }
        private void dfg()
        {
             string bb = "select userpassword ,UserAccount,userdelete,userstatus,userName from UserInfo";
             DataSet aa = DBHelper.Select(bb);
             DataTable bs = aa.Tables[0];
             dataGridView1.AutoGenerateColumns = false;
             dataGridView1.DataSource = bs;
              for (int i = 0; i < bs.Rows.Count; i++)
              {
                  string name = bs.Rows[i]["UserStatus"].ToString();
                  string id = bs.Rows[i]["UserAccount"].ToString();
                  if (name.Equals("False"))
                  {
                      dataGridView1.Rows[i].Cells["colStatus2"].Value = "未禁用";
                  }
                  else
                  {
                      dataGridView1.Rows[i].Cells["colStatus2"].Value = "已禁用";
                  }
              }
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string bb = textBox1.Text.Trim();
            string aa = string.Format("select * from UserInfo where UserName like '%{0}%'", bb);
            DataSet boy = DBHelper.Select(aa);
            DataTable ds = boy.Tables[0];
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ds;
            for (int i = 0; i < ds.Rows.Count; i++)
            {
                string name = ds.Rows[i]["UserStatus"].ToString();
                if (name.Equals("False"))
                {
                    dataGridView1.Rows[i].Cells["colStatus2"].Value = "未禁用";
                }
                else
                {
                    dataGridView1.Rows[i].Cells["colStatus2"].Value = "已禁用";
                }
            }
        }

        private void frm_yonghu_Load(object sender, EventArgs e)
        {
            dfg();
           
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult aa = MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (aa == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string b = dataGridView1.SelectedRows[0].Cells["colUserAccount"].Value.ToString();
                    string sql = "delete from UserInfo where UserAccount='" + b + "'";
                    bool c = DBHelper.NonSelect(sql);
                    if (c)
                    {
                        MessageBox.Show("删除成功");
                        dfg();
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                }
                dfg();
            }
        }

        private void timer_add_Tick(object sender, EventArgs e)
        {
            dfg();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            timer_add.Stop();
            timer_gai.Stop();
        }

        private void timer_gai_Tick(object sender, EventArgs e)
        {
            dfg();
        }
    }
}
