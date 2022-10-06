using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Vente
{
    static class Program
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V83SMQA;Initial Catalog=Vente;Integrated Security=True");
        public static SqlCommand CmdSelect = new SqlCommand();
        public static SqlDataReader dr;
        public static BindingSource ClientBS = new BindingSource();
        public static DataTable dt = new DataTable();



        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
