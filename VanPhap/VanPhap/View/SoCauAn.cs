using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanPhap.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VanPhap.View
{
    public partial class SoCauAn : Form
    {
        string strCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Git\\V-n-Ph-p\\VanPhap\\VanPhap\\bin\\Debug\\Demo.accdb";
        OleDbConnection sqlCon = null;
        //Hàm mở kết nối db
        public void OpenConection()
        {
            if (sqlCon == null)
            {
                sqlCon = new OleDbConnection(strCon);
            }
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }

        }
        public void CloseConection()
        {
            if(sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close();
            }
        }
        public string id { get; set; }
        public string chubai { get; set; }
        public string phapdanh { get; set; }
        public string diachi { get; set; }
        public string nguyenquan { get; set; }

        public SoCauAn()
        {
            InitializeComponent();
        }

        private void SoCauAn_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            txt_idchubai.Text = id;
            txt_name.Text = chubai;
            txt_nickname.Text = phapdanh;
            txt_diachi.Text = diachi;
            txt_luutru.Text = nguyenquan;



            

        }
        public void HienDanhSachVatTu()
        {
            /*using (OleDbConnection connection = new OleDbConnection(strCon))
            {
                connection.Open();

                // Thực hiện truy vấn SQL để lấy dữ liệu từ bảng
                string sqlQuery = "SELECT * FROM tblChiTietSo";
                using (OleDbCommand command = new OleDbCommand(sqlQuery, connection))
                {
                    // Thực hiện truy vấn và nhận dữ liệu bằng OleDbDataReader
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy giá trị của cột "shortTextField"
                            string shortText = reader.GetString(10);

                            // Sử dụng giá trị shortText theo nhu cầu của bạn
                            ListViewItem lvi = new ListViewItem(shortText);
                            
                            lsv_danhsach_cauan.Items.Add(lvi);

                        }
                    }
                }
            }*/
            OpenConection();



            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "SELECT TOP 5 ID FROM tblphattu ORDER BY ID DESC";
            sqlCmd.Connection = sqlCon;

            OleDbDataReader reader = sqlCmd.ExecuteReader();

            

            while (reader.Read())
            {

                //*double idSo = reader.GetDouble(1);*//*
                double hoten = reader.GetDouble(0);
                /*string phapdanh = reader.GetString(11);
                double gioitinh = reader.GetDouble(4);
                double namsinh = reader.GetDouble(6);
               // string tuoiam = reader.GetString(7);
                string sao = reader.GetString(8);
                string han = reader.GetString(9);*/




                ListViewItem lvi = new ListViewItem(hoten.ToString());
                /*lvi.SubItems.Add(hoten);
                lvi.SubItems.Add(phapdanh);
                lvi.SubItems.Add(gioitinh.ToString());
                lvi.SubItems.Add(namsinh.ToString());
                //lvi.SubItems.Add(tuoiam);
                lvi.SubItems.Add(sao);
                lvi.SubItems.Add(han);*/
                

                lsv_danhsach_cauan.Items.Add(lvi);

            }
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
            NguoiNhanCauAn nnca = new NguoiNhanCauAn();
            nnca.Show();

            //Hiển thị thông tin từ item vào TextBox
            string id = txt_idchubai.Text;
            

            NguoiNhanCauAn formNguoiNhan = new NguoiNhanCauAn();
            formNguoiNhan.DataFromForm1 = id;


        }

    

        
        private void dgv_list_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgv_list.SelectedRows.Count > 0)
            //{
            //    int id = int.Parse(dgv_list.SelectedRows[0].Cells["IDSo"].Value.ToString());
            //    ChiTietSo human = new VanPhapBUS().GetDetails(id);
            //    if (human != null)
            //    {
            //        txt_name.Text = human.HoTen;
            //        txt_nickname.Text = human.PhapDanh;
            //        txt_birthday.Text = human.IDNamSinh.ToString();
            //        txt_gioi_tinh.Text = human.GioiTinh.ToString();
            //        if (txt_gioi_tinh.Text.Equals("Nam"))
            //        {
            //            rbm_Man.Checked = true;
            //        } else if (txt_gioi_tinh.Text.Equals("Nữ"))
            //        {
            //            rbm_Woman.Checked = true;
            //        }
                    
            //    }

            //}
        }

        //public void clear()
        //{
        //    txt_birthday.Text = "";
        //    rbm_Man.Checked = true;
        //    txt_name.Text = "";
        //    txt_nickname.Text = "";
        //    txt_luutru.Text = "";
        //    txt_han.Text = "";
        //    txt_tuoi.Text = "";
        //    txt_sao.Text = "";

        //}

        private void dgv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnl_List_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_MouseHover(object sender, EventArgs e)
        {
            btn_Add.ForeColor = Color.Red;
        }

        private void btn_Add_MouseLeave(object sender, EventArgs e)
        {
            btn_Add.ForeColor =   Color.Black;
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            SoCauAn sca = new SoCauAn();
            sca.Show();
        }

        private void rdbtn_coso_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtn_chua_Click(object sender, EventArgs e)
        {
            ChuBai cb = new ChuBai();
            cb.Show();
        }

        private void rdbtn_coso_Click(object sender, EventArgs e)
        {
            TimChuBai tcb = new TimChuBai();
            tcb.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rdbtn_chua_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_gioi_tinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_luutru_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
