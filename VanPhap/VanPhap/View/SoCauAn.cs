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
            this.MaximizeBox = false;

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

                IDSo = 69271, 
                GioiTinh = "Nam",
                IDNamSinh = 1999.0,
                HoTen = "Nguyen Quoc Duy",
                PhapDanh = "Danny Nguyen",
                Tuoi = "Ky Mao",
                Sao = "Ke Do",
                Han = "Chiu",
                IDD = 0,
            };
            bool result = new VanPhapBUS().AddNew(newHuman);
            if (result)
            {
                List<ChiTietSo> humans = new VanPhapBUS().GetAll();
                dgv_list.DataSource = humans;


            }
            else { MessageBox.Show("Xin Lỗi Bạn!"); }
        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dgv_list_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_list.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgv_list.SelectedRows[0].Cells["IDSo"].Value.ToString());
                ChiTietSo human = new VanPhapBUS().GetDetails(id);
                if (human != null)
                {
                    txt_name.Text = human.HoTen;
                    txt_nickname.Text = human.PhapDanh;
                    txt_birthday.Text = human.IDNamSinh.ToString();
                    txt_tuoi.Text = human.Tuoi;
                    txt_sao.Text = human.Sao;
                    txt_han.Text = human.Han;
                    
                }

            }
        }

        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_List_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
