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
using System.Configuration;

namespace _4_10_Forma1
{
    public partial class Osoba : Form
    {
        string CS = ConfigurationManager.ConnectionStrings["CS"].ToString();
        DataTable podaci = new DataTable();
        int red = 0;
        public Osoba()
        {
            InitializeComponent();
        }
        private void osvezi()
        {
            if (podaci.Rows.Count == 0)
            {
                txt_ID.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_ocena.Text = "";
                button1.Enabled = false;
                button6.Enabled = false;
                button2.Enabled = false;
                button7.Enabled = false;
                red = 0;
            }
            else {
                txt_ID.Text = podaci.Rows[red]["ID"].ToString();
                txt_ime.Text = podaci.Rows[red]["ime"].ToString();
                txt_prezime.Text = podaci.Rows[red]["prezime"].ToString();
                txt_ocena.Text = podaci.Rows[red]["ocena"].ToString();
                button1.Enabled = (red != podaci.Rows.Count - 1);
                button6.Enabled = (red != podaci.Rows.Count - 1);
                button2.Enabled = (red != 0);
                button7.Enabled = (red != 0);
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            red = podaci.Rows.Count - 1;
            osvezi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            red--;
            osvezi();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            red = 0;
            osvezi();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            SqlCommand naredba = new SqlCommand("DELETE FROM Ucenik WHERE ID=" + txt_ID.Text, veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ucenik", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            if (red > podaci.Rows.Count-1)
            {
                red = podaci.Rows.Count - 1;
            }
            osvezi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            // MessageBox.Show("UPDATE Ucenik SET ime=" + txt_ime.Text + ", prezime=" + txt_prezime.Text + ", ocena=" + txt_ocena.Text + " WHERE id=" + txt_ID.Text);
               
            SqlCommand naredba = new SqlCommand("UPDATE Ucenik SET ime='" + txt_ime.Text + "', prezime='" + txt_prezime.Text + "', ocena=" + txt_ocena.Text + " WHERE id=" + txt_ID.Text, veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ucenik", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            if (red > podaci.Rows.Count - 1)
            {
                red = podaci.Rows.Count - 1;
            }
            osvezi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(CS);
            // MessageBox.Show("UPDATE Ucenik SET ime=" + txt_ime.Text + ", prezime=" + txt_prezime.Text + ", ocena=" + txt_ocena.Text + " WHERE id=" + txt_ID.Text);

            SqlCommand naredba = new SqlCommand("INSERT INTO Ucenik (ime, prezime, ocena) VALUES ('" + txt_ime.Text + "', '" + txt_prezime.Text + "', " + txt_ocena.Text + ") ", veza);
            // MessageBox.Show("INSERT INTO Ucenik (ime, prezime, ocena) VALUES ('" + txt_ime.Text + "', '" + txt_prezime.Text + "', " + txt_ocena.Text +") ");
            
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ucenik ORDER BY ID", veza);
            podaci.Clear();
            adapter.Fill(podaci);
            red = podaci.Rows.Count - 1;
            osvezi();
            
        }
            
    }
}
