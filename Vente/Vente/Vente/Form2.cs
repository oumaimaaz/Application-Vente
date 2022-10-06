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

namespace Vente
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT Ville FROM Client", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                while (Program.dr.Read())
                {
                    comboBox1.Items.Add(Program.dr[0].ToString()); 
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                Program.con.Close();
            }

            //datagridview's columns
            dataGridView1.Columns.Add("code","Code Client");
            dataGridView1.Columns.Add("nom", "Nom");
            dataGridView1.Columns.Add("ville", "Ville");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT * FROM Client WHERE Ville = '"+comboBox1.Text+"'", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                while (Program.dr.Read())
                {
                    dataGridView1.Rows.Add(Program.dr[0].ToString(), Program.dr[1].ToString(), Program.dr[2].ToString());
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                Program.con.Close();
            }
        }
    }
}
