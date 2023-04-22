using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanPhap.Model;

namespace VanPhap.View
{
    public partial class SoCauAn : Form
    {
        public SoCauAn()
        {
            InitializeComponent();
        }

        private void SoCauAn_Load(object sender, EventArgs e)
        {
            List<ChiTietSo> humans = new VanPhapBUS().GetAll();
            dgv_list.DataSource = humans;
        }

        public int CheckGioiTinh(object sender, EventArgs e)
        {
            int Check;
            if (rbm_Man.Checked)
            {
                Check = 1;
            }
            else if (rbm_Woman.Checked)
            {
                Check = 2;
            }
            return 0;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ChiTietSo newHuman = new ChiTietSo()
            {
                ID = 0,
                IDSo = 0,
                HoTen_Unicode = txt_name.Text.Trim(),
                PhapDanh_Unicode = txt_nickname.Text.Trim(),
                NamNu = 0,
                IDNamSinh = int.Parse(txt_birthday.Text.Trim()),
                Tuoi = txt_birthday.Text.Trim(),
                Sao = txt_sao.Text.Trim(),
                Han = txt_han.Text.Trim(),

            };
            bool result = new VanPhapBUS().AddNew(newHuman);
            if (result)
            {
                MessageBox.Show("Them thanh cong");


            }
            else { MessageBox.Show("Xin Lỗi Bạn!"); }
        }

    }
}
