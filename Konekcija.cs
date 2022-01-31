using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace _4_10_Forma1
{
    class Konekcija
    {
        static public SqlConnection Connect()
        {
            string CS;
            CS = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            SqlConnection konekcija = new SqlConnection(CS);
            return konekcija;
               
        }
        
    }
}
