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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (frm_login.userAccount == "1234567")
            {
                //lbl_user.Text = frm_login.username;
                lbl_user.Text = "超级管理员";
            }
            else {
                lbl_user.Text = "管理员";
                btn_yong.Enabled = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new frm_login().Show();
           // this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_Pwd pwd = new frm_Pwd();
            pwd.ShowDialog();
            this.Close();
        }

        private void btn_yong_Click(object sender, EventArgs e)
        {
            //if (lbl_user.Text == "管理员")
            //{
            //    MessageBox.Show("管理员无该项权限");
            //}
            //else
            //{
                new frm_yonghu().Show();
            //}
        }

        private void btn_che_Click(object sender, EventArgs e)
        {
            frm_car car = new frm_car();
            car.Show();
        }

        private void btn_ting_Click(object sender, EventArgs e)
        {
            frm_stopcar stop = new frm_stopcar();
            stop.Show();
        }

        private void btn_zi_Click(object sender, EventArgs e)
        {
            new frm_ziFei().Show();
        }
    }
}
