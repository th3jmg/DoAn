using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnDatHang.BLL;

namespace DOAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BLL_Login.Instance.checkUsernameAndPassword(textBox1.Text, textBox2.Text) != -1)
            {
                MessageBox.Show("Dang nhap");
            }
            else MessageBox.Show("Sai tai khoan hoac mat khau");
        }
    }
}
