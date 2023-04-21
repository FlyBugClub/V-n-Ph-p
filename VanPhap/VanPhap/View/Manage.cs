using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Policy;
using VanPhap.Model;




namespace VanPhap
{

    public partial class form_manage : Form
    {

        public form_manage()
        {
            InitializeComponent();
        }

        private void Form_SoThongTin_Load(object sender, EventArgs e)
        {
            List<ChiTietSo> humans = new VanPhapBUS().GetAll();
            dgv_list.DataSource = humans;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbm_Man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabale_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {
         
        }
        
        public void TinhTuoiSaoHan()
        {

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

        private void txt_sao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_birthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_han_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_luutru_RegionChanged(object sender, EventArgs e)
        {

        }

        private void txt_tuoi_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
