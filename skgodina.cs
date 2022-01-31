using System;
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
    public partial class skgodina : Form
    {
        DataTable podaci;
        SqlDataAdapter adapter;
        string ime_tabele;

        public skgodina(string tabela)
        {
            ime_tabele = tabela;
            InitializeComponent();
        }

        private void skgodina_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM "+ime_tabele, Konekcija.Connect());
            podaci = new DataTable();
            adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
            // dataGridView1.Columns["id"].ReadOnly = true;
            // dataGridView1.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable menjano = podaci.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (menjano != null)
            {
                adapter.Update(menjano);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
