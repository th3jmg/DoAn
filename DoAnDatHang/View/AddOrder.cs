using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnDatHang;

namespace DOAN.View
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DoAnEntities a = new DoAnEntities();
            List<Khach> khach = a.Khaches.ToList();
            listView1.Columns.Add("Mã món");
            listView1.Columns.Add("Tên món");
            listView1.Columns.Add("Số lượng");
            listView1.Columns.Add("Thành tiền");
            listView1.GridLines = true;
            foreach(Khach i in khach)
            {
                listView1.Items.Add(new ListViewItem(new string[]
                {
                    i.MaKhachHang.ToString(),
                    i.HoTen,
                    i.CMND.ToString(),
                    (i.CMND * i.MaKhachHang).ToString()
                }));
            };
            dataGridView1.DataSource = a.Khaches.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
