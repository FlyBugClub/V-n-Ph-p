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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_gioi_tinh = new System.Windows.Forms.TextBox();
            this.txt_birthday = new System.Windows.Forms.TextBox();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(299, 29);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(8, 29);
            this.txt_id.TabIndex = 30;
            this.txt_id.Visible = false;
            // 
            // txt_gioi_tinh
            // 
            this.txt_gioi_tinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioi_tinh.Location = new System.Drawing.Point(130, 98);
            this.txt_gioi_tinh.Name = "txt_gioi_tinh";
            this.txt_gioi_tinh.Size = new System.Drawing.Size(8, 29);
            this.txt_gioi_tinh.TabIndex = 29;
            this.txt_gioi_tinh.Visible = false;
            // 
            // txt_birthday
            // 
            this.txt_birthday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Location = new System.Drawing.Point(490, 29);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(182, 29);
            this.txt_birthday.TabIndex = 28;
            this.txt_birthday.TextChanged += new System.EventHandler(this.txt_birthday_TextChanged);
            // 
            // lbl_LuuTru
            // 
            this.lbl_LuuTru.AutoSize = true;
            this.lbl_LuuTru.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LuuTru.Location = new System.Drawing.Point(375, 106);
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
            this.txt_luutru.Location = new System.Drawing.Point(490, 98);
            this.txt_luutru.Name = "txt_luutru";
            this.txt_luutru.Size = new System.Drawing.Size(182, 29);
            this.txt_luutru.TabIndex = 27;
            // 
            // rbm_Woman
            // 
            this.rbm_Woman.AutoSize = true;
            this.rbm_Woman.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Woman.Location = new System.Drawing.Point(231, 99);
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
            this.rbm_Man.Location = new System.Drawing.Point(154, 99);
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
            this.lbl_name.Location = new System.Drawing.Point(35, 36);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 21);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Chủ bái";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(130, 29);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(180, 29);
            this.txt_name.TabIndex = 3;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(35, 105);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(76, 21);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Giới tính";
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(375, 36);
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
            this.lbl_NickName.Location = new System.Drawing.Point(35, 70);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(89, 21);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(130, 63);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(182, 29);
            this.txt_nickname.TabIndex = 10;
            // 
            // lbl_nguyen_quan
            // 
            this.lbl_nguyen_quan.AutoSize = true;
            this.lbl_nguyen_quan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nguyen_quan.Location = new System.Drawing.Point(375, 71);
            this.lbl_nguyen_quan.Name = "lbl_nguyen_quan";
            this.lbl_nguyen_quan.Size = new System.Drawing.Size(108, 21);
            this.lbl_nguyen_quan.TabIndex = 33;
            this.lbl_nguyen_quan.Text = "Nguyên quán";
            this.lbl_nguyen_quan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_nguyen_quan.Click += new System.EventHandler(this.lbl_nguyen_quan_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(489, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 29);
            this.textBox2.TabIndex = 34;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageKey = "add-icon.png";
            this.btn_Add.Location = new System.Drawing.Point(286, 160);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(117, 34);
            this.btn_Add.TabIndex = 35;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // ChuBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 221);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_nguyen_quan);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.txt_gioi_tinh);
            this.Controls.Add(this.lbl_NickName);
            this.Controls.Add(this.txt_birthday);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_LuuTru);
            this.Controls.Add(this.txt_luutru);
            this.Controls.Add(this.rbm_Woman);
            this.Controls.Add(this.rbm_Man);
            this.Controls.Add(this.lbl_sex);
            this.Controls.Add(this.lbl_name);
            this.Name = "ChuBai";
            this.Text = "ChuBai";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_gioi_tinh;
        private System.Windows.Forms.TextBox txt_birthday;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Add;
    }
}