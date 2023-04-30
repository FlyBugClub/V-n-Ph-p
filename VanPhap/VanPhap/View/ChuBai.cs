using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanPhap.Controller;

namespace VanPhap.View
{
    public partial class ChuBai : Form
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
        public ChuBai()
        {
            InitializeComponent();
        }

        private void lbl_Birthday_Click(object sender, EventArgs e)
        {

        }

        private void txt_birthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_nguyen_quan_Click(object sender, EventArgs e)
        {

        }

        private void lbl_LuuTru_Click(object sender, EventArgs e)
        {

        }

        private void ChuBai_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            /* if (rbm_Man.Checked)
             {
                 txt_gioi_tinh.Text = "Nam";
             }
             else if (rbm_Woman.Checked)
             {
                 txt_gioi_tinh.Text = "Nữ";
             }
             /*OpenConection();

             OleDbCommand sqlCmd = new OleDbCommand();
             sqlCmd.CommandType = System.Data.CommandType.Text;
             sqlCmd.CommandText = "SELECT MAX(ID) FROM tblphattu";

             sqlCmd.CommandText = "INSERT INTO tblPhatTu (ID, hotenuni, phapdanhuni ,diachiuni, nguyenquanuni, namsinh ) VALUES (@ID, @HoTenUni, @PhapDanhUni, @DiaChiUni,  @NguyenQuanUni,  @NamSinh)";
             sqlCmd.Connection = sqlCon;

             OleDbDataReader reader = sqlCmd.ExecuteReader();
             string id = reader.GetString(0);
             txt_id1.Text = id + 1;

             OleDbParameter  paraId = new OleDbParameter("@ID",OleDbType.Double);
             paraId.Value= txt_id1.Text.Trim();
             sqlCmd.Parameters.Add(paraId);

             OleDbParameter paraHoTenUni = new OleDbParameter("@HoTenUni", OleDbType.);
             paraHoTenUni.Value = txt_name.Text.Trim();
             sqlCmd.Parameters.Add(paraHoTenUni);

             OleDbParameter paraPhapDanhuni = new OleDbParameter("@PhapDanhuni", OleDbType.BSTR);
             paraPhapDanhuni.Value = txt_nickname.Text.Trim();
             sqlCmd.Parameters.Add(paraPhapDanhuni);

             OleDbParameter paraDiaChiUni = new OleDbParameter("@DiaChiUni", OleDbType.BSTR);
             paraDiaChiUni.Value = txt_luutru.Text.Trim();
             sqlCmd.Parameters.Add(paraDiaChiUni);

             OleDbParameter paraNguyenQuanUni = new OleDbParameter("@NguyenQuanUni", OleDbType.BSTR);
             paraNguyenQuanUni.Value = txt_nguyenquan.Text.Trim();
             sqlCmd.Parameters.Add(paraNguyenQuanUni);

             OleDbParameter paraNamSinh = new OleDbParameter("@NamSinh", OleDbType.Double);
             paraNamSinh.Value = txt_birthday.Text.Trim();
             sqlCmd.Parameters.Add(paraNamSinh);

             // Tạo đối tượng Connection
             using (OleDbConnection connection = new OleDbConnection(strCon))
             {
                 try
                 {
                     // Mở kết nối
                     connection.Open();
                     // Tạo câu lệnh SELECT
                     string query1 = "SELECT MAX(ID) FROM tblphattu";
                     using (OleDbCommand command = new OleDbCommand(query1, connection))
                     {


                         using (OleDbDataReader reader = command.ExecuteReader())
                         {
                             // Kiểm tra nếu có dữ liệu trả về
                             if (reader.HasRows)
                             {
                                 while (reader.Read())
                                 {

                                     double value1 = reader.GetDouble(0);  // Lấy giá trị của cột Column1

                                     txt_id1.Text = value1.ToString();

                                 }


                             }
                             else
                             {

                                 MessageBox.Show("Không có dữ liệu trả về từ câu truy vấn SELECT.");
                             }
                         }

                         // Tạo câu lệnh INSE
                         //string query = "INSERT INTO tblPhatTu (ID, HoTen, HoTenUni, PhapDanh, PhapDanhUni, DiaChi, DiaChiUni, NguyenQuan, NguyenQuanUni, NgaySinh, NamSinh, AmLich)  VALUES (@ID, @HoTen,@HoTenUni, @PhapDanh,@PhapDanhUni, @DiaChi ,@DiaChiUni, @NguyenQuan, @NguyenQuanUni, @NgaySinh, @NamSinh, @AmLich)";
                         string query = "INSERT INTO tblhatTu (ID, HoTen, HoTenUni, PhapDanh, PhapDanhUni, DiaChi, DiaChiUni, NguyenQuan, NguyenQuanUni, NgaySinh, NamSinh, AmLich)  VALUES (?,?,?,?,?,?,?,?,?,?,?,?)";

                         /*double id = double.Parse(txt_id1.Text+1) ;
                         txt_id1.Text =id.ToString();
                         string hoten = txt_name.Text;
                         string phapdanh = txt_nickname.Text;
                         string diachi = txt_luutru.Text;
                         string nguyenquan = txt_nguyenquan.Text;
                         double namsinh = double.Parse(txt_birthday1.Text);

                         // Tạo đối tượng Command và liên kết với Connection
                         using (OleDbCommand command1 = new OleDbCommand(query, connection))
                         {
                             // Gán giá trị cho các tham số trong câu lệnh INSERT
                             /*command.Parameters.AddWithValue("@ID", 1);
                             command.Parameters.AddWithValue("@HoTen", "Test");
                             command.Parameters.AddWithValue("@PhapDanh", null);
                             command.Parameters.AddWithValue("@DiaChi", "Test");
                             command.Parameters.AddWithValue("@NguyenQuan", "Test");
                             command.Parameters.AddWithValue("@NgaySinh", null);
                             command.Parameters.AddWithValue("@NamSinh", "-1");
                             command.Parameters.AddWithValue("@AmLich", null);
                             command.Parameters.AddWithValue("@HoTenUni", "Test");

                             command.Parameters.AddWithValue("@PhapDanhUni", "Test");

                             command.Parameters.AddWithValue("@DiaChiUni", null);

                             command.Parameters.AddWithValue("@NguyenQuanUni", "Test");
                             command.Parameters.AddWithValue("?", 1);
                             command.Parameters.AddWithValue("?", "Test");
                             command.Parameters.AddWithValue("?", null);
                             command.Parameters.AddWithValue("?", "Test");
                             command.Parameters.AddWithValue("?", "Test");
                             command.Parameters.AddWithValue("?", null);
                             command.Parameters.AddWithValue("?", "-1");
                             command.Parameters.AddWithValue("?", null);
                             command.Parameters.AddWithValue("?", "Test");

                             command.Parameters.AddWithValue("?", "Test");

                             command.Parameters.AddWithValue("?", null);

                             command.Parameters.AddWithValue("?", "Test");




                             command.Parameters.Add(new OleDbParameter("Warnings", false));


                             // Thực thi câu lệnh INSERT
                             int rowsAffected = command1.ExecuteNonQuery();

                             // Kiểm tra số dòng bị ảnh hưởng
                             if (rowsAffected > 0)
                             {

                                 MessageBox.Show("Dữ liệu đã được thêm thành công vào cơ sở dữ liệu.");
                             }
                             else
                             {
                                 MessageBox.Show("Không thể thêm dữ liệu vào cơ sở dữ liệu.");

                             }
                         }
                     }
                 }
                 catch (OleDbException ex)
                 {
                     MessageBox.Show("Lỗi khi thêm dữ liệu vào cơ sở dữ liệu: " + ex.Message);

                 }
             }*/


       
            using (OleDbConnection connection = new OleDbConnection(strCon))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();
                    string query1 = "SELECT MAX(ID) FROM tblphattu";
                    using (OleDbCommand command = new OleDbCommand(query1, connection))
                    {


                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            // Kiểm tra nếu có dữ liệu trả về
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    double value1 = reader.GetDouble(0);  // Lấy giá trị của cột Column1

                                    txt_id1.Text = value1.ToString();

                                }


                            }
                            else
                            {

                                MessageBox.Show("Không có dữ liệu trả về từ câu truy vấn SELECT.");
                            }
                        }
                    }


                        // Tạo câu lệnh INSERT
                        string query = "INSERT INTO tblPhatTu (ID, HoTenUni,  PhapDanhUni,  DiaChiUni,  NguyenQuanUni)  VALUES (?,?,?,?,?)";
                    double id = double.Parse(txt_id1.Text) + 1;
                    txt_id1.Text = id.ToString();
                    // Tạo đối tượng Command và liên kết với Connection
                    using (OleDbCommand command = new OleDbCommand(query, connection))

                        /*double id = double.Parse(txt_id1.Text+1) ;
                         txt_id1.Text =id.ToString();
                         string hoten = txt_name.Text;
                         string phapdanh = txt_nickname.Text;
                         string diachi = txt_luutru.Text;
                         string nguyenquan = txt_nguyenquan.Text;
                         double namsinh = double.Parse(txt_birthday1.Text);*/
                        
                    {
                        // Gán giá trị cho các tham số trong câu lệnh INSERT
                        command.Parameters.AddWithValue("?", id);
                        command.Parameters.AddWithValue("?", "Test");
                        command.Parameters.AddWithValue("?", "test");
                        command.Parameters.AddWithValue("?", "Test");
                        command.Parameters.AddWithValue("?", "Test");
                        

                        // Thực thi câu lệnh INSERT
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra số dòng bị ảnh hưởng
                        if (rowsAffected > 0)
                        {

                            MessageBox.Show("Dữ liệu đã được thêm thành công vào cơ sở dữ liệu.");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm dữ liệu vào cơ sở dữ liệu.");

                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu vào cơ sở dữ liệu: " + ex.Message);
                }
            }
        }

    }
    }
