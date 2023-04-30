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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VanPhap.View
{
    public partial class TimChuBai : Form
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
            if (sqlCon.State == ConnectionState.Open && sqlCon != null)
            {
                sqlCon.Close();
            }
        }
        public TimChuBai()
        {
            InitializeComponent();
        }

        private void pnl_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_bo_Click(object sender, EventArgs e)
        {

        }

        private void btn_tim_kiem_Click(object sender, EventArgs e)
        {
            lsv_timchubai.Items.Clear();
            string name = txt_name.Text;
            string diachi1 = txt_diachi.Text;
            string nguyenquan1 = txt_nguyenquan.Text;
            string phapdanh1 = txt_nickname.Text;

            OpenConection();



            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            
            //sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%"+name+"%'";
            sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%" + name + "%'  AND DiaChiUni LIKE '%" + diachi1 + "%' AND NguyenQuanUni LIKE '%" + nguyenquan1 + "%' AND PhapDanhUni LIKE '%" + phapdanh1 + "%' ";
            sqlCmd.Connection = sqlCon;

            OleDbDataReader reader = sqlCmd.ExecuteReader();



            while (reader.Read())
            {

                double idSo = reader.GetDouble(0);
                string hoten = reader.GetString(1);
                string phapdanh = reader.GetString(2);
                string diachi = reader.GetString(3);
                string nguyenquan = reader.GetString(4);




                
                
                ListViewItem lvi = new ListViewItem(idSo.ToString());
                lvi.SubItems.Add(hoten);
                lvi.SubItems.Add(phapdanh);
                lvi.SubItems.Add(diachi);
                lvi.SubItems.Add(nguyenquan);

                lsv_timchubai.Items.Add(lvi);

                
            }
        }
        
        private void TimChuBai_Load(object sender, EventArgs e)
        {
        }

        private void lsv_timchubai_ItemActivate(object sender, EventArgs e)
        {
            if (lsv_timchubai.SelectedItems.Count > 0)
            {
                // Lấy item được kích hoạt (được nhấp vào)
                ListViewItem activatedItem = lsv_timchubai.SelectedItems[0];

                //Hiển thị thông tin từ item vào TextBox
                string id = activatedItem.SubItems[0].Text;
                string chubai  = activatedItem.SubItems[1].Text;
                string phapdanh = activatedItem.SubItems[2].Text;
                string diachi = activatedItem.SubItems[3].Text;
                string nguyenquan = activatedItem.SubItems[4].Text;

                SoCauAn form2 = new SoCauAn();
                form2.id = id;
                form2.chubai = chubai;
                form2.phapdanh = phapdanh;
                form2.diachi = diachi;
                form2.nguyenquan = nguyenquan;

                // Hiển thị Form 2
                form2.Show();

            }
        }

        private void lbl_Birthday_Click(object sender, EventArgs e)
        {

        }

        private void lsv_timchubai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
