﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _4_10_Forma1
{
    public partial class Form1 : Form
    {
        string CS = "Data source=INF_4_PROFESOR\\SQLPBG; Initial catalog=MilosP2021; Integrated security=true";
        DataTable podaci = new DataTable();
        int red = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void osvezi()
        {
            txt_ID.Text = podaci.Rows[red]["ID"].ToString();
            txt_ime.Text = podaci.Rows[red]["ime"].ToString();
            txt_prezime.Text = podaci.Rows[red]["prezime"].ToString();
            txt_ocena.Text = podaci.Rows[red]["ocena"].ToString();
            if (red == podaci.Rows.Count - 1)               button1.Enabled = false;
            button1.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ucenik", veza);
            adapter.Fill(podaci);
            //MessageBox.Show(podaci.Rows.Count.ToString());
            osvezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            red++;
            
            osvezi();
        }
    }
}
