namespace VanPhap.View
{
    partial class ChuBai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuBai));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_gioi_tinh = new System.Windows.Forms.TextBox();
            this.lbl_LuuTru = new System.Windows.Forms.Label();
            this.txt_luutru = new System.Windows.Forms.TextBox();
            this.rbm_Woman = new System.Windows.Forms.RadioButton();
            this.rbm_Man = new System.Windows.Forms.RadioButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.lbl_nguyen_quan = new System.Windows.Forms.Label();
            this.txt_nguyenquan = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_id1 = new System.Windows.Forms.TextBox();
            this.txt_birthday1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(280, 10);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(8, 29);
            this.txt_id.TabIndex = 30;
            this.txt_id.Visible = false;
            // 
            // txt_gioi_tinh
            // 
            this.txt_gioi_tinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioi_tinh.Location = new System.Drawing.Point(106, 84);
            this.txt_gioi_tinh.Name = "txt_gioi_tinh";
            this.txt_gioi_tinh.Size = new System.Drawing.Size(10, 29);
            this.txt_gioi_tinh.TabIndex = 29;
            this.txt_gioi_tinh.Visible = false;
            // 
            // lbl_LuuTru
            // 
            this.lbl_LuuTru.AutoSize = true;
            this.lbl_LuuTru.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LuuTru.Location = new System.Drawing.Point(324, 91);
            this.lbl_LuuTru.Name = "lbl_LuuTru";
            this.lbl_LuuTru.Size = new System.Drawing.Size(65, 21);
            this.lbl_LuuTru.TabIndex = 26;
            this.lbl_LuuTru.Text = "Lưu trú";
            this.lbl_LuuTru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_LuuTru.Click += new System.EventHandler(this.lbl_LuuTru_Click);
            // 
            // txt_luutru
            // 
            this.txt_luutru.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luutru.Location = new System.Drawing.Point(436, 83);
            this.txt_luutru.Name = "txt_luutru";
            this.txt_luutru.Size = new System.Drawing.Size(182, 29);
            this.txt_luutru.TabIndex = 5;
            // 
            // rbm_Woman
            // 
            this.rbm_Woman.AutoSize = true;
            this.rbm_Woman.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Woman.Location = new System.Drawing.Point(207, 85);
            this.rbm_Woman.Name = "rbm_Woman";
            this.rbm_Woman.Size = new System.Drawing.Size(51, 25);
            this.rbm_Woman.TabIndex = 24;
            this.rbm_Woman.Text = "Nữ";
            this.rbm_Woman.UseVisualStyleBackColor = true;
            // 
            // rbm_Man
            // 
            this.rbm_Man.AutoSize = true;
            this.rbm_Man.Checked = true;
            this.rbm_Man.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Man.Location = new System.Drawing.Point(130, 85);
            this.rbm_Man.Name = "rbm_Man";
            this.rbm_Man.Size = new System.Drawing.Size(63, 25);
            this.rbm_Man.TabIndex = 22;
            this.rbm_Man.TabStop = true;
            this.rbm_Man.Text = "Nam";
            this.rbm_Man.UseVisualStyleBackColor = true;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(9, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 21);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Chủ bái";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(106, 10);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 29);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(9, 88);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(76, 21);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Giới tính";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(324, 18);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(80, 21);
            this.lbl_Birthday.TabIndex = 12;
            this.lbl_Birthday.Text = "Năm sinh";
            this.lbl_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Birthday.Click += new System.EventHandler(this.lbl_Birthday_Click);
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(9, 53);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(89, 21);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(106, 45);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(182, 29);
            this.txt_nickname.TabIndex = 2;
            // 
            // lbl_nguyen_quan
            // 
            this.lbl_nguyen_quan.AutoSize = true;
            this.lbl_nguyen_quan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nguyen_quan.Location = new System.Drawing.Point(324, 56);
            this.lbl_nguyen_quan.Name = "lbl_nguyen_quan";
            this.lbl_nguyen_quan.Size = new System.Drawing.Size(108, 21);
            this.lbl_nguyen_quan.TabIndex = 33;
            this.lbl_nguyen_quan.Text = "Nguyên quán";
            this.lbl_nguyen_quan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_nguyen_quan.Click += new System.EventHandler(this.lbl_nguyen_quan_Click);
            // 
            // txt_nguyenquan
            // 
            this.txt_nguyenquan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nguyenquan.Location = new System.Drawing.Point(436, 48);
            this.txt_nguyenquan.Name = "txt_nguyenquan";
            this.txt_nguyenquan.Size = new System.Drawing.Size(182, 29);
            this.txt_nguyenquan.TabIndex = 4;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.ImageIndex = 0;
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(659, 19);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(115, 34);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_id1
            // 
            this.txt_id1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id1.Location = new System.Drawing.Point(276, 10);
            this.txt_id1.Name = "txt_id1";
            this.txt_id1.Size = new System.Drawing.Size(10, 29);
            this.txt_id1.TabIndex = 36;
            this.txt_id1.Visible = false;
            // 
            // txt_birthday1
            // 
            this.txt_birthday1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday1.Location = new System.Drawing.Point(436, 10);
            this.txt_birthday1.Name = "txt_birthday1";
            this.txt_birthday1.Size = new System.Drawing.Size(182, 29);
            this.txt_birthday1.TabIndex = 37;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add-icon.png");
            this.imageList1.Images.SetKeyName(1, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(2, "delete-icon.png");
            this.imageList1.Images.SetKeyName(3, "Pencil-icon.png");
            this.imageList1.Images.SetKeyName(4, "search-icon.png");
            this.imageList1.Images.SetKeyName(5, "guide_icon.png");
            this.imageList1.Images.SetKeyName(6, "reload_icon.png");
            this.imageList1.Images.SetKeyName(7, "Button-Refresh-icon.png");
            this.imageList1.Images.SetKeyName(8, "bin.png");
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.txt_birthday1);
            this.pnl_Form.Controls.Add(this.lbl_sex);
            this.pnl_Form.Controls.Add(this.txt_id1);
            this.pnl_Form.Controls.Add(this.rbm_Man);
            this.pnl_Form.Controls.Add(this.rbm_Woman);
            this.pnl_Form.Controls.Add(this.lbl_nguyen_quan);
            this.pnl_Form.Controls.Add(this.txt_luutru);
            this.pnl_Form.Controls.Add(this.txt_nguyenquan);
            this.pnl_Form.Controls.Add(this.lbl_LuuTru);
            this.pnl_Form.Controls.Add(this.txt_name);
            this.pnl_Form.Controls.Add(this.lbl_Birthday);
            this.pnl_Form.Controls.Add(this.txt_id);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Controls.Add(this.txt_gioi_tinh);
            this.pnl_Form.Location = new System.Drawing.Point(12, 12);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(635, 156);
            this.pnl_Form.TabIndex = 67;
            this.pnl_Form.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Form_Paint);
            // 
            // ChuBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 181);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.btn_Add);
            this.Name = "ChuBai";
            this.Text = "Thêm chủ bái";
            this.Load += new System.EventHandler(this.ChuBai_Load);
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.TextBox txt_gioi_tinh;
        private System.Windows.Forms.Label lbl_LuuTru;
        private System.Windows.Forms.TextBox txt_luutru;
        private System.Windows.Forms.RadioButton rbm_Woman;
        private System.Windows.Forms.RadioButton rbm_Man;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_nguyen_quan;
        private System.Windows.Forms.TextBox txt_nguyenquan;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_id1;
        private System.Windows.Forms.TextBox txt_birthday1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_Form;
    }
}