﻿using System;
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
