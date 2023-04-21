namespace VanPhap
{
    partial class form_manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_manage));
            this.lbl_title = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.lbl_NickName = new System.Windows.Forms.Label();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.txt_tuoi = new System.Windows.Forms.TextBox();
            this.lbl_tuoi = new System.Windows.Forms.Label();
            this.txt_sao = new System.Windows.Forms.TextBox();
            this.lbl_Sao = new System.Windows.Forms.Label();
            this.txt_han = new System.Windows.Forms.TextBox();
            this.bl_Han = new System.Windows.Forms.Label();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Form = new System.Windows.Forms.Panel();
            this.txt_birthday = new System.Windows.Forms.TextBox();
            this.lbl_LuuTru = new System.Windows.Forms.Label();
            this.txt_luutru = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbm_Woman = new System.Windows.Forms.RadioButton();
            this.rbm_Man = new System.Windows.Forms.RadioButton();
            this.dgv_list = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.pnl_List = new System.Windows.Forms.Panel();
            this.lbl_List = new System.Windows.Forms.Label();
            this.btn_findIcon = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_year = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.pnl_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
            this.pnl_List.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 46);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(250, 31);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Phiếu điền thông tin";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Location = new System.Drawing.Point(28, 37);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(81, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Chủ bái";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // txt_name
            // 
            this.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(132, 35);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(353, 32);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // lbl_sex
            // 
            this.lbl_sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.Location = new System.Drawing.Point(27, 118);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(90, 25);
            this.lbl_sex.TabIndex = 5;
            this.lbl_sex.Text = "Giới tính";
            this.lbl_sex.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nickname
            // 
            this.txt_nickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nickname.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nickname.Location = new System.Drawing.Point(132, 76);
            this.txt_nickname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(353, 32);
            this.txt_nickname.TabIndex = 10;
            // 
            // lbl_NickName
            // 
            this.lbl_NickName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_NickName.AutoSize = true;
            this.lbl_NickName.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NickName.Location = new System.Drawing.Point(27, 80);
            this.lbl_NickName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NickName.Name = "lbl_NickName";
            this.lbl_NickName.Size = new System.Drawing.Size(102, 25);
            this.lbl_NickName.TabIndex = 9;
            this.lbl_NickName.Text = "Pháp danh";
            this.lbl_NickName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Birthday.Location = new System.Drawing.Point(28, 158);
            this.lbl_Birthday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(98, 25);
            this.lbl_Birthday.TabIndex = 12;
            this.lbl_Birthday.Text = "Năm Sinh";
            this.lbl_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tuoi
            // 
            this.txt_tuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tuoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tuoi.Location = new System.Drawing.Point(669, 35);
            this.txt_tuoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tuoi.Name = "txt_tuoi";
            this.txt_tuoi.ReadOnly = true;
            this.txt_tuoi.Size = new System.Drawing.Size(353, 32);
            this.txt_tuoi.TabIndex = 14;
            this.txt_tuoi.TextChanged += new System.EventHandler(this.txt_tuoi_TextChanged);
            // 
            // lbl_tuoi
            // 
            this.lbl_tuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tuoi.AutoSize = true;
            this.lbl_tuoi.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tuoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_tuoi.Location = new System.Drawing.Point(564, 39);
            this.lbl_tuoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tuoi.Name = "lbl_tuoi";
            this.lbl_tuoi.Size = new System.Drawing.Size(53, 25);
            this.lbl_tuoi.TabIndex = 13;
            this.lbl_tuoi.Text = "Tuổi";
            this.lbl_tuoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_sao
            // 
            this.txt_sao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sao.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sao.Location = new System.Drawing.Point(669, 76);
            this.txt_sao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sao.Name = "txt_sao";
            this.txt_sao.ReadOnly = true;
            this.txt_sao.Size = new System.Drawing.Size(353, 32);
            this.txt_sao.TabIndex = 16;
            this.txt_sao.TextChanged += new System.EventHandler(this.txt_sao_TextChanged);
            // 
            // lbl_Sao
            // 
            this.lbl_Sao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Sao.AutoSize = true;
            this.lbl_Sao.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Sao.Location = new System.Drawing.Point(564, 80);
            this.lbl_Sao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sao.Name = "lbl_Sao";
            this.lbl_Sao.Size = new System.Drawing.Size(45, 25);
            this.lbl_Sao.TabIndex = 15;
            this.lbl_Sao.Text = "Sao";
            this.lbl_Sao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_han
            // 
            this.txt_han.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_han.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_han.Location = new System.Drawing.Point(669, 117);
            this.txt_han.Margin = new System.Windows.Forms.Padding(4);
            this.txt_han.Name = "txt_han";
            this.txt_han.ReadOnly = true;
            this.txt_han.Size = new System.Drawing.Size(353, 32);
            this.txt_han.TabIndex = 18;
            this.txt_han.TextChanged += new System.EventHandler(this.txt_han_TextChanged);
            // 
            // bl_Han
            // 
            this.bl_Han.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bl_Han.AutoSize = true;
            this.bl_Han.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl_Han.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bl_Han.Location = new System.Drawing.Point(564, 120);
            this.bl_Han.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bl_Han.Name = "bl_Han";
            this.bl_Han.Size = new System.Drawing.Size(47, 25);
            this.bl_Han.TabIndex = 17;
            this.bl_Han.Text = "Hạn";
            this.bl_Han.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1124, 29);
            this.Menu.TabIndex = 19;
            this.Menu.Text = "menuStrip1";
            this.Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ItemClicked);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.ShowShortcutKeys = false;
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.tìmToolStripMenuItem,
            this.lưuLạiToolStripMenuItem,
            this.inSổToolStripMenuItem,
            this.xóaSổToolStripMenuItem});
            this.chỉnhSửaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(101, 26);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.giúpĐỡToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // pnl_Form
            // 
            this.pnl_Form.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnl_Form.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Form.Controls.Add(this.txt_birthday);
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
            this.pnl_Form.Controls.Add(this.lbl_Birthday);
            this.pnl_Form.Controls.Add(this.lbl_NickName);
            this.pnl_Form.Controls.Add(this.txt_nickname);
            this.pnl_Form.Location = new System.Drawing.Point(8, 80);
            this.pnl_Form.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Form.Name = "pnl_Form";
            this.pnl_Form.Size = new System.Drawing.Size(1104, 252);
            this.pnl_Form.TabIndex = 20;
            this.pnl_Form.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Form_Paint);
            // 
            // txt_birthday
            // 
            this.txt_birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_birthday.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birthday.Location = new System.Drawing.Point(132, 152);
            this.txt_birthday.Margin = new System.Windows.Forms.Padding(4);
            this.txt_birthday.Name = "txt_birthday";
            this.txt_birthday.Size = new System.Drawing.Size(353, 32);
            this.txt_birthday.TabIndex = 28;
            this.txt_birthday.TextChanged += new System.EventHandler(this.txt_birthday_TextChanged);
            // 
            // lbl_LuuTru
            // 
            this.lbl_LuuTru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_LuuTru.AutoSize = true;
            this.lbl_LuuTru.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LuuTru.Location = new System.Drawing.Point(28, 196);
            this.lbl_LuuTru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LuuTru.Name = "lbl_LuuTru";
            this.lbl_LuuTru.Size = new System.Drawing.Size(77, 25);
            this.lbl_LuuTru.TabIndex = 26;
            this.lbl_LuuTru.Text = "Lưu trú";
            this.lbl_LuuTru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_luutru
            // 
            this.txt_luutru.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_luutru.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luutru.Location = new System.Drawing.Point(133, 194);
            this.txt_luutru.Margin = new System.Windows.Forms.Padding(4);
            this.txt_luutru.Name = "txt_luutru";
            this.txt_luutru.Size = new System.Drawing.Size(353, 32);
            this.txt_luutru.TabIndex = 27;
            this.txt_luutru.RegionChanged += new System.EventHandler(this.txt_luutru_RegionChanged);
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
            this.rbm_Woman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbm_Woman.AutoSize = true;
            this.rbm_Woman.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Woman.Location = new System.Drawing.Point(275, 115);
            this.rbm_Woman.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Woman.Name = "rbm_Woman";
            this.rbm_Woman.Size = new System.Drawing.Size(61, 29);
            this.rbm_Woman.TabIndex = 24;
            this.rbm_Woman.Text = "Nữ";
            this.rbm_Woman.UseVisualStyleBackColor = true;
            // 
            // rbm_Man
            // 
            this.rbm_Man.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbm_Man.AutoSize = true;
            this.rbm_Man.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbm_Man.Location = new System.Drawing.Point(173, 115);
            this.rbm_Man.Margin = new System.Windows.Forms.Padding(4);
            this.rbm_Man.Name = "rbm_Man";
            this.rbm_Man.Size = new System.Drawing.Size(75, 29);
            this.rbm_Man.TabIndex = 22;
            this.rbm_Man.Text = "Nam";
            this.rbm_Man.UseVisualStyleBackColor = true;
            this.rbm_Man.CheckedChanged += new System.EventHandler(this.rbm_Man_CheckedChanged);
            // 
            // dgv_list
            // 
            this.dgv_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_list.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_list.Location = new System.Drawing.Point(5, 53);
            this.dgv_list.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_list.Name = "dgv_list";
            this.dgv_list.RowHeadersWidth = 51;
            this.dgv_list.Size = new System.Drawing.Size(1092, 418);
            this.dgv_list.TabIndex = 21;
            this.dgv_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabale_List_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_search.Location = new System.Drawing.Point(680, 11);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(353, 29);
            this.txt_search.TabIndex = 26;
            this.txt_search.Tag = "";
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
            // pnl_List
            // 
            this.pnl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_List.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_List.Controls.Add(this.btn_findIcon);
            this.pnl_List.Controls.Add(this.dgv_list);
            this.pnl_List.Controls.Add(this.txt_search);
            this.pnl_List.Location = new System.Drawing.Point(8, 370);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(1104, 476);
            this.pnl_List.TabIndex = 28;
            this.pnl_List.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbl_List
            // 
            this.lbl_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_List.AutoSize = true;
            this.lbl_List.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_List.Location = new System.Drawing.Point(12, 336);
            this.lbl_List.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_List.Name = "lbl_List";
            this.lbl_List.Size = new System.Drawing.Size(137, 31);
            this.lbl_List.TabIndex = 29;
            this.lbl_List.Text = "Danh sách";
            // 
            // btn_findIcon
            // 
            this.btn_findIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_findIcon.ImageIndex = 1;
            this.btn_findIcon.ImageList = this.icon;
            this.btn_findIcon.Location = new System.Drawing.Point(1043, 11);
            this.btn_findIcon.Margin = new System.Windows.Forms.Padding(4);
            this.btn_findIcon.Name = "btn_findIcon";
            this.btn_findIcon.Size = new System.Drawing.Size(45, 33);
            this.btn_findIcon.TabIndex = 27;
            this.btn_findIcon.UseVisualStyleBackColor = true;
            // 
            // btn_find
            // 
            this.btn_find.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_find.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.ImageIndex = 4;
            this.btn_find.ImageList = this.imageList1;
            this.btn_find.Location = new System.Drawing.Point(958, 183);
            this.btn_find.Margin = new System.Windows.Forms.Padding(4);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(100, 50);
            this.btn_find.TabIndex = 25;
            this.btn_find.Text = "Tìm";
            this.btn_find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_find.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ImageIndex = 1;
            this.btn_Update.ImageList = this.imageList1;
            this.btn_Update.Location = new System.Drawing.Point(730, 183);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(100, 50);
            this.btn_Update.TabIndex = 21;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageIndex = 2;
            this.btn_Delete.ImageList = this.imageList1;
            this.btn_Delete.Location = new System.Drawing.Point(844, 183);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 50);
            this.btn_Delete.TabIndex = 20;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ImageKey = "add-icon.png";
            this.btn_Add.ImageList = this.imageList1;
            this.btn_Add.Location = new System.Drawing.Point(623, 183);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(97, 50);
            this.btn_Add.TabIndex = 19;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.AccessibleDescription = "";
            this.thêmToolStripMenuItem.AccessibleName = "";
            this.thêmToolStripMenuItem.Image = global::VanPhap.Properties.Resources.add_icon;
            this.thêmToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.thêmToolStripMenuItem.Tag = "";
            this.thêmToolStripMenuItem.Text = "Thêm sổ mới";
            this.thêmToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tìmToolStripMenuItem
            // 
            this.tìmToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.tìmToolStripMenuItem.Image = global::VanPhap.Properties.Resources.search_icon;
            this.tìmToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tìmToolStripMenuItem.Name = "tìmToolStripMenuItem";
            this.tìmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.tìmToolStripMenuItem.Text = "Tìm";
            // 
            // lưuLạiToolStripMenuItem
            // 
            this.lưuLạiToolStripMenuItem.Image = global::VanPhap.Properties.Resources.floppy_icon;
            this.lưuLạiToolStripMenuItem.Name = "lưuLạiToolStripMenuItem";
            this.lưuLạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuLạiToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.lưuLạiToolStripMenuItem.Text = "Lưu lại";
            // 
            // inSổToolStripMenuItem
            // 
            this.inSổToolStripMenuItem.Image = global::VanPhap.Properties.Resources.print_icon;
            this.inSổToolStripMenuItem.Name = "inSổToolStripMenuItem";
            this.inSổToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.inSổToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.inSổToolStripMenuItem.Text = "In sổ";
            // 
            // xóaSổToolStripMenuItem
            // 
            this.xóaSổToolStripMenuItem.Image = global::VanPhap.Properties.Resources.delete_icon;
            this.xóaSổToolStripMenuItem.Name = "xóaSổToolStripMenuItem";
            this.xóaSổToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaSổToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.xóaSổToolStripMenuItem.Text = "Xóa sổ";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Image = global::VanPhap.Properties.Resources.guide_icon01;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(797, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nhập năm hiện tại";
            // 
            // txt_year
            // 
            this.txt_year.Location = new System.Drawing.Point(917, 46);
            this.txt_year.Name = "txt_year";
            this.txt_year.Size = new System.Drawing.Size(100, 22);
            this.txt_year.TabIndex = 30;
            // 
            // form_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1124, 864);
            this.Controls.Add(this.txt_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_List);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_Form);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_manage";
            this.Text = "Quản lý cầu an";
            this.Load += new System.EventHandler(this.Form_SoThongTin_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.pnl_Form.ResumeLayout(false);
            this.pnl_Form.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
            this.pnl_List.ResumeLayout(false);
            this.pnl_List.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_title;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.TextBox txt_nickname;
        private System.Windows.Forms.Label lbl_NickName;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.TextBox txt_tuoi;
        private System.Windows.Forms.Label lbl_tuoi;
        private System.Windows.Forms.TextBox txt_sao;
        private System.Windows.Forms.Label lbl_Sao;
        private System.Windows.Forms.TextBox txt_han;
        private System.Windows.Forms.Label bl_Han;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Form;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_list;
        private System.Windows.Forms.RadioButton rbm_Man;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.RadioButton rbm_Woman;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_findIcon;
        private System.Windows.Forms.ImageList icon;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.Label lbl_List;
        private System.Windows.Forms.ToolStripMenuItem xóaSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_LuuTru;
        private System.Windows.Forms.TextBox txt_luutru;
        private System.Windows.Forms.TextBox txt_birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_year;
    }
}

