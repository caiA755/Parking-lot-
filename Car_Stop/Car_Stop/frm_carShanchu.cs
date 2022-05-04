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
    public partial class frm_carShanchu : Form
    {
        public frm_carShanchu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string aa = textBox2.Text;
            string aaa = textBox3.Text;
            DateTime b = Convert.ToDateTime(dateTimePicker1.Text);
            string c = textBox5.Text;
            string cc = textBox6.Text;
            string ccc = textBox7.Text;
            DateTime d = Convert.ToDateTime(dateTimePicker2.Text);
            //string xiugai = string.Format("insert into Car(CarNo,Model,Color,ExpiryDate,CarOwner,Tel,PositionId,UpdateTime) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')");
            string xiugai = string.Format("update Car set CarNo='{0}',Model='{1}',Color='{2}',ExpiryDate='{3}',Tel='{4}',PositionId='{5}',UpdateTime='{6}' where CarOwner='{7}'", a, aa, aaa, b, cc, ccc, d, c);
            bool w = DBHelper.NonSelect(xiugai);
            if (w)
            {
                MessageBox.Show("修改成功", "提示");
                this.Close();
            }
            else
            {
                MessageBox.Show("不能修改车主姓名！", "提示");
            }
        }

        private void frm_carShanchu_Load(object sender, EventArgs e)
        {

            textBox1.Text = frm_car.CPH;
            textBox2.Text = frm_car.CLXH;
            textBox3.Text = frm_car.YS;
            dateTimePicker1.Text = frm_car.YXQ.ToString();
            textBox5.Text = frm_car.CZ;
            textBox6.Text = frm_car.DH;
            textBox7.Text = frm_car.CW;
            dateTimePicker2.Text = frm_car.GXSJ.ToString();
        }
    }
}
