namespace VanPhap.View
{
    partial class SoCauSieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoCauSieu));
            this.pnl_List = new System.Windows.Forms.Panel();
            this.btn_findIcon = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_gioi_tinh = new System.Windows.Forms.TextBox();
            this.lbl_LuuTru = new System.Windows.Forms.Label();
            this.txt_luutru = new System.Windows.Forms.TextBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbm_Woman = new System.Windows.Forms.RadioButton();
            this.rbm_Man = new System.Windows.Forms.RadioButton();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_han = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.bl_Han = new System.Windows.Forms.Label();
            this.txt_sao = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_Sao = new System.Windows.Forms.Label();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.lbl_tuoi = new System.Windows.Forms.Label();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.lbl_List = new System.Windows.Forms.Label();
            this.lbl_PhieuDiemThongTin = new System.Windows.Forms.Label();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_namhientai = new System.Windows.Forms.TextBox();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.lbl_day_gone = new System.Windows.Forms.Label();
            this.txt_day_gone = new System.Windows.Forms.TextBox();
            this.pnl_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.pnl_Form.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_List
            // 
            this.pnl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_List.Controls.Add(this.btn_findIcon);
            this.pnl_List.Controls.Add(this.dgv_list);
            this.pnl_List.Controls.Add(this.txt_search);
            this.pnl_List.Location = new System.Drawing.Point(22, 340);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(905, 372);
            this.pnl_List.TabIndex = 38;
            // 
            // btn_findIcon
            // 
            this.btn_findIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_findIcon.ImageIndex = 1;
            this.btn_findIcon.ImageList = this.icon;
            this.btn_findIcon.Location = new System.Drawing.Point(845, 15);
            this.btn_findIcon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_findIcon.Name = "btn_findIcon";
            this.btn_findIcon.Size = new System.Drawing.Size(45, 33);
            this.btn_findIcon.TabIndex = 27;
            this.btn_findIcon.UseVisualStyleBackColor = true;
            // 
            // icon
            // 
            this.icon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icon.ImageStream")));
            this.icon.TransparentColor = System.Drawing.Color.Transparent;
            this.icon.Images.SetKeyName(0, "find_icon.png");
            this.icon.Images.SetKeyName(1, "find_icon1.png");
            this.icon.Images.SetKeyName(2, "computer_icon.png");
            this.icon.Images.SetKeyName(3, "add-icon.png");
            this.icon.Images.SetKeyName(4, "delete-icon.png");
            this.icon.Images.SetKeyName(5, "Pencil-icon.png");
            this.icon.Images.SetKeyName(6, "search-icon.png");
            // 
            // dgv_list
            // 
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(4, 53);
            this.dgv_list.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidth = 51;
            this.dgv_list.Size = new System.Drawing.Size(895, 313);
            this.dgv_list.TabIndex = 21;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_search.Location = new System.Drawing.Point(483, 15);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(353, 25);
            this.txt_search.TabIndex = 26;
            this.txt_search.Tag = "";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(364, 20);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(10, 27);
            this.txt_id.TabIndex = 30;
            this.txt_id.Visible = false;
            // 
            // txt_gioi_tinh
            // 
            this.txt_gioi_tinh.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gioi_tinh.Location = new System.Drawing.Point(135, 100);
            this.txt_gioi_tinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_gioi_tinh.Name = "txt_gioi_tinh";
            this.txt_gioi_tinh.Size = new System.Drawing.Size(10, 27);
            this.txt_gioi_tinh.TabIndex = 29;
            this.txt_gioi_tinh.Visible = false;
            // 
            // lbl_LuuTru
            // 
            this.lbl_LuuTru.AutoSize = true;
            this.lbl_LuuTru.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LuuTru.Location = new System.Drawing.Point(521, 23);
            this.lbl_LuuTru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LuuTru.Name = "lbl_LuuTru";
            this.lbl_LuuTru.Size = new System.Drawing.Size(59, 19);
            this.lbl_LuuTru.TabIndex = 26;
            this.lbl_LuuTru.Text = "Lưu trú";
            this.lbl_LuuTru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_luutru
            // 
            this.txt_luutru.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luutru.Location = new System.Drawing.Point(606, 25);
            this.txt_luutru.Margin = new System.Windows.Forms.Padding(4);
            this.txt_luutru.Name = "txt_luutru";
            this.txt_luutru.Size = new System.Drawing.Size(241, 27);
            this.txt_luutru.TabIndex = 27;
            // 
            // btn_find
            // 
            this.btn_find.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.ImageIndex = 4;
            this.btn_find.ImageList = this.imageList1;
            this.btn_find.Location = new System.Drawing.Point(773, 194);
            this.btn_find.Margin = new System.Windows.Forms.Padding(4);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(100, 42);
            this.btn_find.TabIndex = 25;
            this.btn_find.Text = "Tìm";
            this.btn_find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_find.UseVisualStyleBackColor = true;
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
            // rbm_Woman
            // 
            this.rbm_Woman.AutoSize = true;
            this.rbm_Woman.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Woman.Location = new System.Drawing.Point(269, 101);
            this.rbm_Woman.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Woman.Name = "rbm_Woman";
            this.rbm_Woman.Size = new System.Drawing.Size(48, 23);
            this.rbm_Woman.TabIndex = 24;
            this.rbm_Woman.Text = "Nữ";
            this.rbm_Woman.UseVisualStyleBackColor = true;
            // 
            // rbm_Man
            // 
            this.rbm_Man.AutoSize = true;
            this.rbm_Man.Checked = true;
            this.rbm_Man.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Man.Location = new System.Drawing.Point(167, 101);
            this.rbm_Man.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Man.Name = "rbm_Man";
            this.rbm_Man.Size = new System.Drawing.Size(59, 23);
            this.rbm_Man.TabIndex = 22;
            this.rbm_Man.TabStop = true;
            this.rbm_Man.Text = "Nam";
            this.rbm_Man.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ImageIndex = 1;
            this.btn_Update.ImageList = this.imageList1;
            this.btn_Update.Location = new System.Drawing.Point(557, 194);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 42);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageIndex = 2;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(665, 194);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 42);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageKey = "add-icon.png";
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(451, 194);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 42);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_han
            // 
            this.txt_han.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_han.Location = new System.Drawing.Point(606, 145);
            this.txt_han.Margin = new System.Windows.Forms.Padding(4);
            this.txt_han.Name = "txt_han";
            this.txt_han.ReadOnly = true;
            this.txt_han.Size = new System.Drawing.Size(241, 27);
            this.txt_han.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nhập năm hiện tại";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(21, 28);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(60, 19);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Chủ bái";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bl_Han
            // 
            this.bl_Han.AutoSize = true;
            this.bl_Han.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_Han.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bl_Han.Location = new System.Drawing.Point(521, 155);
            this.bl_Han.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bl_Han.Name = "bl_Han";
            this.bl_Han.Size = new System.Drawing.Size(36, 19);
            this.bl_Han.TabIndex = 17;
            this.bl_Han.Text = "Hạn";
            this.bl_Han.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sao
            // 
            this.txt_sao.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sao.Location = new System.Drawing.Point(606, 103);
            this.txt_sao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sao.Name = "txt_sao";
            this.txt_sao.ReadOnly = true;
            this.txt_sao.Size = new System.Drawing.Size(241, 27);
            this.txt_sao.TabIndex = 16;
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(21, 103);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(70, 19);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Giới tính";
            // 
            // lbl_Sao
            // 
            this.lbl_Sao.AutoSize = true;
            this.lbl_Sao.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Sao.Location = new System.Drawing.Point(521, 113);
            this.lbl_Sao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sao.Name = "lbl_Sao";
            this.lbl_Sao.Size = new System.Drawing.Size(34, 19);
            this.lbl_Sao.TabIndex = 15;
            this.lbl_Sao.Text = "Sao";
            this.lbl_Sao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoi.Location = new System.Drawing.Point(606, 62);
            this.txt_tuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.ReadOnly = true;
            this.txt_tuoi.Size = new System.Drawing.Size(241, 27);
            this.txt_tuoi.TabIndex = 14;
            // 
            // lbl_tuoi
            // 
            this.lbl_tuoi.AutoSize = true;
            this.lbl_tuoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tuoi.Location = new System.Drawing.Point(521, 67);
            this.lbl_tuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tuoi.Name = "lbl_tuoi";
            this.lbl_tuoi.Size = new System.Drawing.Size(39, 19);
            this.lbl_tuoi.TabIndex = 13;
            this.lbl_tuoi.Text = "Tuổi";
            this.lbl_tuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(21, 65);
            this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(77, 19);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nickname
            // 
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(135, 62);
            this.txt_nickname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(241, 27);
            this.txt_nickname.TabIndex = 10;
            // 
            // lbl_List
            // 
            this.lbl_List.AutoSize = true;
            this.lbl_List.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_List.Location = new System.Drawing.Point(26, 303);
            this.lbl_List.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_List.Name = "lbl_List";
            this.lbl_List.Size = new System.Drawing.Size(103, 24);
            this.lbl_List.TabIndex = 40;
            this.lbl_List.Text = "Danh sách";
            // 
            // lbl_PhieuDiemThongTin
            // 
            this.lbl_PhieuDiemThongTin.AutoSize = true;
            this.lbl_PhieuDiemThongTin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhieuDiemThongTin.Location = new System.Drawing.Point(24, 11);
            this.lbl_PhieuDiemThongTin.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_PhieuDiemThongTin.Name = "lbl_PhieuDiemThongTin";
            this.lbl_PhieuDiemThongTin.Size = new System.Drawing.Size(188, 24);
            this.lbl_PhieuDiemThongTin.TabIndex = 36;
            this.lbl_PhieuDiemThongTin.Text = "Phiếu điền thông tin";
            this.lbl_PhieuDiemThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_Form
            // 
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Form.Controls.Add(this.lbl_birthday);
            this.pnl_Form.Controls.Add(this.txt_birthday);
            this.pnl_Form.Controls.Add(this.lbl_day_gone);
            this.pnl_Form.Controls.Add(this.txt_day_gone);
            this.pnl_Form.Controls.Add(this.txt_id);
            this.pnl_Form.Controls.Add(this.txt_gioi_tinh);
            this.pnl_Form.Controls.Add(this.lbl_LuuTru);
            this.pnl_Form.Controls.Add(this.txt_luutru);
            this.pnl_Form.Controls.Add(this.btn_find);
            this.pnl_Form.Controls.Add(this.rbm_Woman);
            this.pnl_Form.Controls.Add(this.rbm_Man);
            this.pnl_Form.Controls.Add(this.btn_Update);
            this.pnl_Form.Controls.Add(this.btn_Delete);
            this.pnl_Form.Controls.Add(this.btn_Add);
            this.pnl_Form.Controls.Add(this.txt_han);
            this.pnl_Form.Controls.Add(this.lbl_name);
            this.pnl_Form.Controls.Add(this.bl_Han);
            this.pnl_Form.Controls.Add(this.txt_name);
            this.pnl_Form.Controls.Add(this.txt_sao);
            this.pnl_Form.Controls.Add(this.lbl_sex);
            this.pnl_Form.Controls.Add(this.lbl_Sao);
            this.pnl_Form.Controls.Add(this.txt_tuoi);
            this.pnl_Form.Controls.Add(this.lbl_tuoi);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Location = new System.Drawing.Point(22, 51);
            this.pnl_Form.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(905, 248);
            this.pnl_Form.TabIndex = 37;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(135, 20);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(239, 27);
            this.txt_name.TabIndex = 3;
            // 
            // txt_namhientai
            // 
            this.txt_namhientai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namhientai.Location = new System.Drawing.Point(798, 10);
            this.txt_namhientai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_namhientai.Name = "txt_namhientai";
            this.txt_namhientai.Size = new System.Drawing.Size(111, 27);
            this.txt_namhientai.TabIndex = 39;
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_birthday.Location = new System.Drawing.Point(21, 140);
            this.lbl_birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(73, 19);
            this.lbl_birthday.TabIndex = 31;
            this.lbl_birthday.Text = "Năm sinh";
            this.lbl_birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_birthday
            // 
            this.txt_birthday.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Location = new System.Drawing.Point(135, 132);
            this.txt_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(239, 27);
            this.txt_birthday.TabIndex = 32;
            // 
            // lbl_day_gone
            // 
            this.lbl_day_gone.AutoSize = true;
            this.lbl_day_gone.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_day_gone.Location = new System.Drawing.Point(21, 177);
            this.lbl_day_gone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_day_gone.Name = "lbl_day_gone";
            this.lbl_day_gone.Size = new System.Drawing.Size(70, 19);
            this.lbl_day_gone.TabIndex = 33;
            this.lbl_day_gone.Text = "Năm mất";
            this.lbl_day_gone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_day_gone
            // 
            this.txt_day_gone.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_day_gone.Location = new System.Drawing.Point(135, 174);
            this.txt_day_gone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_day_gone.Name = "txt_day_gone";
            this.txt_day_gone.Size = new System.Drawing.Size(241, 27);
            this.txt_day_gone.TabIndex = 34;
            // 
            // SoCauSieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 722);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_List);
            this.Controls.Add(this.lbl_PhieuDiemThongTin);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.txt_namhientai);
            this.Name = "SoCauSieu";
            this.Text = "SoCauSieu";
            this.Load += new System.EventHandler(this.SoCauSieu_Load);
            this.pnl_List.ResumeLayout(false);
            this.pnl_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.Button btn_findIcon;
        private System.Windows.Forms.ImageList icon;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_gioi_tinh;
        private System.Windows.Forms.Label lbl_LuuTru;
        private System.Windows.Forms.TextBox txt_luutru;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RadioButton rbm_Woman;
        private System.Windows.Forms.RadioButton rbm_Man;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_han;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label bl_Han;
        private System.Windows.Forms.TextBox txt_sao;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_Sao;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.Label lbl_tuoi;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_List;
        private System.Windows.Forms.Label lbl_PhieuDiemThongTin;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_namhientai;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.Label lbl_day_gone;
        private System.Windows.Forms.TextBox txt_day_gone;
    }
}