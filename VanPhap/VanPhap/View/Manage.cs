﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VanPhapShared;
using VanPhapService;
using System.Security.Policy;

namespace VanPhap
{
    
    public partial class Form_SoCauAn : Form
    {
        const String URL = "tcp://127.0.0.1:6969/longtt";
        IVanPhapBUS VanPhapBUS =  (IVanPhapBUS)Activator.GetObject(typeof(IVanPhapBUS), URL);
        public Form_SoCauAn()
        {
            InitializeComponent();
        }

        private void Manage_Load(object sender, EventArgs e)
        { 
            List<ChiTietSo> humans = VanPhapBUS.GetAll();
            tabale_List.DataSource = humans;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void Form_SoThongTin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbm_Man_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabale_List_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    } 
}
