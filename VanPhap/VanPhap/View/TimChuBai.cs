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

            OpenConection();



            OleDbCommand sqlCmd = new OleDbCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "SELECT ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni FROM tblPhatTu where HoTenUni  LIKE '%"+name+"%'";
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
             
                List<string> info = new List<string>();

                

                info.Add(activatedItem.SubItems[1].Text);
                info.Add(activatedItem.SubItems[2].Text);
                info.Add(activatedItem.SubItems[3].Text);

                SoCauAn form2 = new SoCauAn();
                form2.DataFromTimChuBai = info;

                // Hiển thị Form 2
                form2.Show();

            }
        }

        private void lbl_Birthday_Click(object sender, EventArgs e)
        {

        }
    }
}
