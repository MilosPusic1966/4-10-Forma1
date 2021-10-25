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
    public partial class Form1 : Form
    {
        string CS = "Data source=INF_4_PROFESOR\\SQLPBG; Initial catalog=MilosP2021; Integrated security=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
