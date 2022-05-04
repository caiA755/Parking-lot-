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
    public partial class frm_carTianjia : Form
    {
        public frm_carTianjia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cp = textBox1.Text.Trim();
            string clxh = textBox2.Text.Trim();
            string ys = textBox3.Text.Trim();
            DateTime yxq = Convert.ToDateTime(dateTimePicker1.Text.Trim());
            string cz = textBox5.Text.Trim();
            string dh = textBox6.Text.Trim();
            string cw = textBox7.Text.Trim();
            DateTime gxsj = Convert.ToDateTime(dateTimePicker2.Text.Trim());

            string gan = string.Format("insert into Car(CarNo,Model,Color,ExpiryDate,CarOwner,Tel,PositionId,UpdateTime) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", cp, clxh, ys, yxq, cz, dh, cw, gxsj);
            bool a = DBHelper.NonSelect(gan);
            if (a)
            {
                MessageBox.Show("添加成功了哦~~~~~~~~~~~~~~~~~~", "提示");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                dateTimePicker1.Text = "";
                dateTimePicker2.Text = "";
                frm_car.AAA = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
