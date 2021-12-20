using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace _4_10_Forma1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["CS"].ToString();
            SqlConnection veza = new SqlConnection(CS);
            string username = textBox1.Text;
            SqlCommand naredba = new SqlCommand($"Select * FROM korisnik WHERE email = '{username}'", veza);
            SqlDataAdapter adapt = new SqlDataAdapter(naredba);
            DataTable tabela = new DataTable();
            adapt.Fill(tabela);
            if (tabela.Rows.Count == 1)
            {
                if (String.Compare(tabela.Rows[0]["pass"].ToString(),textBox2.Text) == 0)
                {
                    MessageBox.Show("Dobrodosli");
                    this.Hide();
                    Glavna main_form = new Glavna();
                    main_form.Show();
                }
                else MessageBox.Show("Los password");
            }
            else MessageBox.Show("Nepostojeci username");



        }
    }
}
