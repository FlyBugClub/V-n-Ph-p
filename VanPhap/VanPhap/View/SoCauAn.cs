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

        public void CheckGioiTinh()
        {
            if (rbm_Man.Checked)
            {
                txt_gioi_tinh.Text = "Nam";
            }
            else if (rbm_Woman.Checked)
            {
                txt_gioi_tinh.Text = "Nữ";
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (rbm_Man.Checked)
            {
                txt_gioi_tinh.Text = "Nam";
            }
            else if (rbm_Woman.Checked)
            {
                txt_gioi_tinh.Text = "Nữ";
            }
            else
            {
                MessageBox.Show("Xin Lỗi Bạn!");
            }
            ChiTietSo newHuman = new ChiTietSo()
            {

                
                GioiTinh = txt_gioi_tinh.Text.Trim(),
                IDNamSinh = int.Parse(txt_birthday.Text.Trim()),
                HoTen = txt_name.Text.Trim(),
                PhapDanh = txt_nickname.Text.Trim(),
                Tuoi = txt_tuoi.Text.Trim(),
                Sao = txt_sao.Text.Trim(),
                Han = txt_han.Text.Trim(),

                ID = 0,
            };
            bool result = new VanPhapBUS().AddNew(newHuman);
            if (result)
            {
                List<ChiTietSo> humans = new VanPhapBUS().GetAll();
                dgv_list.DataSource = humans;
                MessageBox.Show("Thêm Thành Công.");
                clear();

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
                int id = int.Parse(dgv_list.SelectedRows[0].Cells["ID"].Value.ToString());
                ChiTietSo human = new VanPhapBUS().GetDetails(id);
                if (human != null)
                {
                    txt_id.Text = human.ID.ToString();
                    txt_name.Text = human.HoTen;
                    txt_nickname.Text = human.PhapDanh;
                    txt_birthday.Text = human.IDNamSinh.ToString();
                    txt_tuoi.Text = human.Tuoi;
                    txt_sao.Text = human.Sao;
                    txt_han.Text = human.Han;
                    txt_gioi_tinh.Text = human.GioiTinh.ToString();
                    if (txt_gioi_tinh.Text.Equals("Nam"))
                    {
                        rbm_Man.Checked = true;
                    } else if (txt_gioi_tinh.Text.Equals("Nữ"))
                    {
                        rbm_Woman.Checked = true;
                    }
                    
                }

            }
        }

        public void clear()
        {
            txt_birthday.Text = "";
            rbm_Man.Checked = true;
            txt_name.Text = "";
            txt_nickname.Text = "";
            txt_luutru.Text = "";
            txt_han.Text = "";
            txt_tuoi.Text = "";
            txt_sao.Text = "";

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

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (rbm_Man.Checked)
            {
                txt_gioi_tinh.Text = "Nam";
            }
            else if (rbm_Woman.Checked)
            {
                txt_gioi_tinh.Text = "Nữ";
            }
            else
            {
                MessageBox.Show("Xin Lỗi Bạn!");
            }
            ChiTietSo newHuman = new ChiTietSo()
            {


                GioiTinh = txt_gioi_tinh.Text.Trim(),
                IDNamSinh = int.Parse(txt_birthday.Text.Trim()),
                HoTen = txt_name.Text.Trim(),
                PhapDanh = txt_nickname.Text.Trim(),
                Tuoi = txt_tuoi.Text.Trim(),
                Sao = txt_sao.Text.Trim(),
                Han = txt_han.Text.Trim(),

                ID = 0,
            };
            bool result = new VanPhapBUS().AddNew(newHuman);
            if (result)
            {
                List<ChiTietSo> humans = new VanPhapBUS().GetAll();
                dgv_list.DataSource = humans;
                MessageBox.Show("Thêm Thành Công.");
                clear();

            }
            else { MessageBox.Show("Xin Lỗi Bạn!"); }


        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Không?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ChiTietSo human = new ChiTietSo();
                int code = int.Parse(txt_id.Text.Trim());
                bool result = new VanPhapBUS().Delete(code);
                if (result)
                {

                    List<ChiTietSo> humans = new VanPhapBUS().GetAll();
                    dgv_list.DataSource = humans;
                    MessageBox.Show("Xóa thành công !");
                }
                else { MessageBox.Show("Vui lòng chọn 1 người cần xóa"); }
            }
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            String keyword = txt_search.Text.Trim();

            if(txt_search.Text.Equals(""))
            {
                List<ChiTietSo> human = new VanPhapBUS().GetAll();
                dgv_list.DataSource = human;
            }
            else
            {
                List<ChiTietSo> humans = new VanPhapBUS().SearchByKeyWord(keyword);

                dgv_list.DataSource = humans;
            }
           
        }

        private void btn_findIcon_Click(object sender, EventArgs e)
        {
            String keyword = txt_search.Text.Trim();

            if (txt_search.Text.Equals(""))
            {
                List<ChiTietSo> human = new VanPhapBUS().GetAll();
                dgv_list.DataSource = human;
            }
            else
            {
                List<ChiTietSo> humans = new VanPhapBUS().SearchByKeyWord(keyword);

                dgv_list.DataSource = humans;
                
            }

        }

        private void txt_namsinh_leave(object sender, EventArgs e)
        {
            int namHienTai = 2023;
            int namSinh = int.Parse(txt_birthday.Text.Trim());
            int Tuoi;
            Tuoi = namHienTai - namSinh;
            txt_sao.Text = Tuoi.ToString();
        }

        private void txt_birthday_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
