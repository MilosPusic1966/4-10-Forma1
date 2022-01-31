using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_10_Forma1
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void uceniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba nova = new Osoba();
            nova.ShowDialog();
            // this.Close();
        }
        
        private void Glavna_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void skGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skgodina nova = new skgodina("sk_godina");
            nova.ShowDialog();
        }

        private void odeljenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            skgodina nova = new skgodina("predmet");
            nova.ShowDialog();
        }
    }
}
