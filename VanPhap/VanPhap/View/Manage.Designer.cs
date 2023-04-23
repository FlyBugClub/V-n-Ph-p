﻿namespace VanPhap
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSổToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giúpĐỡToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.icon = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_SoCauSieu = new System.Windows.Forms.Button();
            this.btn_SoCauAn = new System.Windows.Forms.Button();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pnl_title = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Component = new System.Windows.Forms.Panel();
            this.sơCầuAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sớCầuAnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sớCầuSiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Logo.SuspendLayout();
            this.pnl_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.sơCầuAnToolStripMenuItem,
            this.giúpĐỡToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(1148, 30);
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
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
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
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(101, 25);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh sửa";
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
            // giúpĐỡToolStripMenuItem
            // 
            this.giúpĐỡToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửDụngToolStripMenuItem});
            this.giúpĐỡToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            this.giúpĐỡToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            this.hướngDẫnSửDụngToolStripMenuItem.Image = global::VanPhap.Properties.Resources.guide_icon01;
            this.hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            this.hướngDẫnSửDụngToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.hướngDẫnSửDụngToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.hướngDẫnSửDụngToolStripMenuItem.Text = "Hướng dẫn sử dụng";
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
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.pnl_Menu.Controls.Add(this.btn_SoCauSieu);
            this.pnl_Menu.Controls.Add(this.btn_SoCauAn);
            this.pnl_Menu.Controls.Add(this.pnl_Logo);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 30);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(200, 834);
            this.pnl_Menu.TabIndex = 31;
            // 
            // btn_SoCauSieu
            // 
            this.btn_SoCauSieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.btn_SoCauSieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SoCauSieu.FlatAppearance.BorderSize = 0;
            this.btn_SoCauSieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SoCauSieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SoCauSieu.Location = new System.Drawing.Point(0, 160);
            this.btn_SoCauSieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SoCauSieu.Name = "btn_SoCauSieu";
            this.btn_SoCauSieu.Size = new System.Drawing.Size(200, 60);
            this.btn_SoCauSieu.TabIndex = 34;
            this.btn_SoCauSieu.Text = "Sớ cầu siêu";
            this.btn_SoCauSieu.UseVisualStyleBackColor = false;
            this.btn_SoCauSieu.Click += new System.EventHandler(this.btn_SoCauSieu_Click);
            // 
            // btn_SoCauAn
            // 
            this.btn_SoCauAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(215)))), ((int)(((byte)(210)))));
            this.btn_SoCauAn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_SoCauAn.FlatAppearance.BorderSize = 0;
            this.btn_SoCauAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SoCauAn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SoCauAn.Location = new System.Drawing.Point(0, 100);
            this.btn_SoCauAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SoCauAn.Name = "btn_SoCauAn";
            this.btn_SoCauAn.Size = new System.Drawing.Size(200, 60);
            this.btn_SoCauAn.TabIndex = 33;
            this.btn_SoCauAn.Text = "Sớ cầu an";
            this.btn_SoCauAn.UseVisualStyleBackColor = false;
            this.btn_SoCauAn.Click += new System.EventHandler(this.btn_SoCauAn_Click);
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.pnl_Logo.Controls.Add(this.label2);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(200, 100);
            this.pnl_Logo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.imageList2;
            this.label2.Location = new System.Drawing.Point(55, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 63);
            this.label2.TabIndex = 0;
            this.label2.Text = "   ";
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "4791023_buddha_building_china_landmark_pagoda_icon.png");
            this.imageList2.Images.SetKeyName(1, "4791023_buddha_building_china_landmark_pagoda_icon (1).png");
            // 
            // pnl_title
            // 
            this.pnl_title.BackColor = System.Drawing.Color.Gainsboro;
            this.pnl_title.Controls.Add(this.lbl_Title);
            this.pnl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title.Location = new System.Drawing.Point(200, 30);
            this.pnl_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_title.Name = "pnl_title";
            this.pnl_title.Size = new System.Drawing.Size(948, 100);
            this.pnl_title.TabIndex = 32;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(371, 37);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(171, 35);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "VÂN PHÁP";
            // 
            // pnl_Component
            // 
            this.pnl_Component.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Component.Location = new System.Drawing.Point(200, 130);
            this.pnl_Component.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Component.Name = "pnl_Component";
            this.pnl_Component.Size = new System.Drawing.Size(948, 734);
            this.pnl_Component.TabIndex = 33;
            this.pnl_Component.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // sơCầuAnToolStripMenuItem
            // 
            this.sơCầuAnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sớCầuAnToolStripMenuItem,
            this.sớCầuSiêuToolStripMenuItem});
            this.sơCầuAnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sơCầuAnToolStripMenuItem.Name = "sơCầuAnToolStripMenuItem";
            this.sơCầuAnToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.sơCầuAnToolStripMenuItem.Text = "Sớ cầu";
            this.sơCầuAnToolStripMenuItem.Click += new System.EventHandler(this.sơCầuAnToolStripMenuItem_Click);
            // 
            // sớCầuAnToolStripMenuItem
            // 
            this.sớCầuAnToolStripMenuItem.Name = "sớCầuAnToolStripMenuItem";
            this.sớCầuAnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sớCầuAnToolStripMenuItem.Text = "Sớ cầu an";
            this.sớCầuAnToolStripMenuItem.Click += new System.EventHandler(this.sớCầuAnToolStripMenuItem_Click);
            // 
            // sớCầuSiêuToolStripMenuItem
            // 
            this.sớCầuSiêuToolStripMenuItem.Name = "sớCầuSiêuToolStripMenuItem";
            this.sớCầuSiêuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sớCầuSiêuToolStripMenuItem.Text = "Sớ cầu siêu";
            this.sớCầuSiêuToolStripMenuItem.Click += new System.EventHandler(this.sớCầuSiêuToolStripMenuItem_Click);
            // 
            // form_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1148, 864);
            this.Controls.Add(this.pnl_Component);
            this.Controls.Add(this.pnl_title);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_manage";
            this.Text = "Quản lý sớ cầu";
            this.Load += new System.EventHandler(this.Form_SoThongTin_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Logo.ResumeLayout(false);
            this.pnl_Logo.PerformLayout();
            this.pnl_title.ResumeLayout(false);
            this.pnl_title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private System.Windows.Forms.ImageList icon;
        private System.Windows.Forms.ToolStripMenuItem xóaSổToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.Button btn_SoCauAn;
        private System.Windows.Forms.Panel pnl_title;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Panel pnl_Component;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button btn_SoCauSieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem sơCầuAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sớCầuAnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sớCầuSiêuToolStripMenuItem;
    }
}

