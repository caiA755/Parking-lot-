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
    public partial class frm_zhiFeiGai : Form
    {
        public frm_zhiFeiGai()
        {
            InitializeComponent();
        }

        private void frm_zhiFeiGai_Load(object sender, EventArgs e)
        {
            txt_danwei.Text = frm_ziFei.unit;
            txt_type.Text = frm_ziFei.type;
        }

        private void btn_修改_Click(object sender, EventArgs e)
        {
            string sql=string.Format("update rate set Postage='{0}' where type='{1}' and unit='{2}'",txt_price.Text.Trim(),txt_type.Text,txt_danwei.Text);
            bool result = DBHelper.NonSelect(sql);
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
    }
}
