﻿namespace VanPhap.View
{
    partial class NguoiNhanCauAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguoiNhanCauAn));
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_gioi_tinh_1 = new System.Windows.Forms.TextBox();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.lbl_LuuTru = new System.Windows.Forms.Label();
            this.txt_luutru = new System.Windows.Forms.TextBox();
            this.rbm_Nu = new System.Windows.Forms.RadioButton();
            this.rbm_Nam = new System.Windows.Forms.RadioButton();
            this.txt_han = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.bl_Han = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_sao = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_Sao = new System.Windows.Forms.Label();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.lbl_tuoi = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.lbl_nguyen_quan = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(578, 199);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(116, 35);
            this.txt_id.TabIndex = 30;
            // 
            // txt_gioi_tinh_1
            // 
            this.txt_gioi_tinh_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioi_tinh_1.Location = new System.Drawing.Point(380, 108);
            this.txt_gioi_tinh_1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gioi_tinh_1.Name = "txt_gioi_tinh_1";
            this.txt_gioi_tinh_1.Size = new System.Drawing.Size(61, 35);
            this.txt_gioi_tinh_1.TabIndex = 29;
            this.txt_gioi_tinh_1.Visible = false;
            this.txt_gioi_tinh_1.TextChanged += new System.EventHandler(this.txt_gioi_tinh_1_TextChanged);
            // 
            // txt_birthday
            // 
            this.txt_birthday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Location = new System.Drawing.Point(175, 156);
            this.txt_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(241, 35);
            this.txt_birthday.TabIndex = 28;
            this.txt_birthday.TextChanged += new System.EventHandler(this.txt_birthday_TextChanged);
            this.txt_birthday.Leave += new System.EventHandler(this.txt_birthday_Leave);
            // 
            // lbl_LuuTru
            // 
            this.lbl_LuuTru.AutoSize = true;
            this.lbl_LuuTru.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LuuTru.Location = new System.Drawing.Point(48, 207);
            this.lbl_LuuTru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LuuTru.Name = "lbl_LuuTru";
            this.lbl_LuuTru.Size = new System.Drawing.Size(85, 27);
            this.lbl_LuuTru.TabIndex = 26;
            this.lbl_LuuTru.Text = "Lưu trú";
            this.lbl_LuuTru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_luutru
            // 
            this.txt_luutru.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luutru.Location = new System.Drawing.Point(175, 199);
            this.txt_luutru.Margin = new System.Windows.Forms.Padding(4);
            this.txt_luutru.Name = "txt_luutru";
            this.txt_luutru.Size = new System.Drawing.Size(241, 35);
            this.txt_luutru.TabIndex = 27;
            // 
            // rbm_Nu
            // 
            this.rbm_Nu.AutoSize = true;
            this.rbm_Nu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Nu.Location = new System.Drawing.Point(309, 112);
            this.rbm_Nu.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Nu.Name = "rbm_Nu";
            this.rbm_Nu.Size = new System.Drawing.Size(63, 31);
            this.rbm_Nu.TabIndex = 24;
            this.rbm_Nu.Text = "Nữ";
            this.rbm_Nu.UseVisualStyleBackColor = true;
            // 
            // rbm_Nam
            // 
            this.rbm_Nam.AutoSize = true;
            this.rbm_Nam.Checked = true;
            this.rbm_Nam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Nam.Location = new System.Drawing.Point(207, 112);
            this.rbm_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Nam.Name = "rbm_Nam";
            this.rbm_Nam.Size = new System.Drawing.Size(79, 31);
            this.rbm_Nam.TabIndex = 22;
            this.rbm_Nam.TabStop = true;
            this.rbm_Nam.Text = "Nam";
            this.rbm_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_han
            // 
            this.txt_han.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_han.Location = new System.Drawing.Point(591, 113);
            this.txt_han.Margin = new System.Windows.Forms.Padding(4);
            this.txt_han.Name = "txt_han";
            this.txt_han.ReadOnly = true;
            this.txt_han.Size = new System.Drawing.Size(269, 35);
            this.txt_han.TabIndex = 18;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(48, 34);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(84, 27);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Họ Tên";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bl_Han
            // 
            this.bl_Han.AutoSize = true;
            this.bl_Han.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_Han.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bl_Han.Location = new System.Drawing.Point(524, 119);
            this.bl_Han.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bl_Han.Name = "bl_Han";
            this.bl_Han.Size = new System.Drawing.Size(52, 27);
            this.bl_Han.TabIndex = 17;
            this.bl_Han.Text = "Hạn";
            this.bl_Han.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(177, 26);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(239, 35);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_sao
            // 
            this.txt_sao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sao.Location = new System.Drawing.Point(591, 71);
            this.txt_sao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sao.Name = "txt_sao";
            this.txt_sao.ReadOnly = true;
            this.txt_sao.Size = new System.Drawing.Size(269, 35);
            this.txt_sao.TabIndex = 16;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(48, 119);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(97, 27);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Giới tính";
            // 
            // lbl_Sao
            // 
            this.lbl_Sao.AutoSize = true;
            this.lbl_Sao.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Sao.Location = new System.Drawing.Point(524, 78);
            this.lbl_Sao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sao.Name = "lbl_Sao";
            this.lbl_Sao.Size = new System.Drawing.Size(47, 27);
            this.lbl_Sao.TabIndex = 15;
            this.lbl_Sao.Text = "Sao";
            this.lbl_Sao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoi.Location = new System.Drawing.Point(591, 26);
            this.txt_tuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.ReadOnly = true;
            this.txt_tuoi.Size = new System.Drawing.Size(269, 35);
            this.txt_tuoi.TabIndex = 14;
            // 
            // lbl_tuoi
            // 
            this.lbl_tuoi.AutoSize = true;
            this.lbl_tuoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tuoi.Location = new System.Drawing.Point(524, 37);
            this.lbl_tuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tuoi.Name = "lbl_tuoi";
            this.lbl_tuoi.Size = new System.Drawing.Size(55, 27);
            this.lbl_tuoi.TabIndex = 13;
            this.lbl_tuoi.Text = "Tuổi";
            this.lbl_tuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(48, 164);
            this.lbl_Birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(106, 27);
            this.lbl_Birthday.TabIndex = 12;
            this.lbl_Birthday.Text = "Năm Sinh";
            this.lbl_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(48, 76);
            this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(114, 27);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(175, 68);
            this.txt_nickname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(241, 35);
            this.txt_nickname.TabIndex = 10;
            // 
            // lbl_nguyen_quan
            // 
            this.lbl_nguyen_quan.AutoSize = true;
            this.lbl_nguyen_quan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nguyen_quan.Location = new System.Drawing.Point(20, 247);
            this.lbl_nguyen_quan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nguyen_quan.Name = "lbl_nguyen_quan";
            this.lbl_nguyen_quan.Size = new System.Drawing.Size(140, 27);
            this.lbl_nguyen_quan.TabIndex = 31;
            this.lbl_nguyen_quan.Text = "Nguyên quán";
            this.lbl_nguyen_quan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(175, 242);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 35);
            this.textBox1.TabIndex = 32;
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
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageKey = "add-icon.png";
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(759, 247);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(156, 42);
            this.btn_Add.TabIndex = 33;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageKey = "add-icon.png";
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(578, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 42);
            this.button1.TabIndex = 34;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NguoiNhanCauAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_nguyen_quan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_gioi_tinh_1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_birthday);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.lbl_LuuTru);
            this.Controls.Add(this.lbl_NickName);
            this.Controls.Add(this.txt_luutru);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.rbm_Nu);
            this.Controls.Add(this.lbl_tuoi);
            this.Controls.Add(this.rbm_Nam);
            this.Controls.Add(this.txt_tuoi);
            this.Controls.Add(this.txt_han);
            this.Controls.Add(this.lbl_Sao);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.bl_Han);
            this.Controls.Add(this.txt_sao);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NguoiNhanCauAn";
            this.Text = "Người nhận cầu an";
            this.Load += new System.EventHandler(this.NguoiNhanCauAn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_gioi_tinh_1;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.Label lbl_LuuTru;
        private System.Windows.Forms.TextBox txt_luutru;
        private System.Windows.Forms.RadioButton rbm_Nu;
        private System.Windows.Forms.RadioButton rbm_Nam;
        private System.Windows.Forms.TextBox txt_han;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label bl_Han;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_sao;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_Sao;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.Label lbl_tuoi;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_nguyen_quan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
    }
}