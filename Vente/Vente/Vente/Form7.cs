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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private int index = -1;

        private string Montant(float pu, int qu)
        {
            return (pu * qu).ToString();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT CodeCl FROM Client", Program.con);
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

            dataGridView1.Columns.Add("num","Numero Commande");
            dataGridView1.Columns.Add("date","Date Commande");

            dataGridView2.Columns.Add("code", "Code Article");
            dataGridView2.Columns.Add("des", "Designation");
            dataGridView2.Columns.Add("pu", "PU");
            dataGridView2.Columns.Add("Qu", "Quntité");
            dataGridView2.Columns.Add("montant", "Montant");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT Nom,Ville FROM Client WHERE CodeCl = " + comboBox1.Text + "", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                if (Program.dr.Read())
                {
                    textBox2.Text = Program.dr[0].ToString();
                    textBox3.Text = Program.dr[1].ToString();
                }
                Program.dr.Close();
                float chiffre = 0;
                Program.CmdSelect = new SqlCommand("SELECT COUNT(*) FROM Commande C,Client CL WHERE C.CodeCl = CL.CodeCl AND C.CodeCl = "+comboBox1.Text+ "", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                if (Program.dr.Read())
                {
                    chiffre = int.Parse(Program.dr[0].ToString());
                }
                textBox1.Text = chiffre.ToString();
                Program.dr.Close();
                Program.CmdSelect = new SqlCommand("SELECT NumCom,DateCom FROM Commande C,Client CL WHERE C.CodeCl = CL.CodeCl AND CL.CodeCl = " + comboBox1.Text + "", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (Program.dr.Read())
                {
                     dataGridView1.Rows.Add( Program.dr[0].ToString(), Program.dr[1].ToString());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            float total = 0;
            float ttc = float.Parse(textBox4.Text);
            float tva = 0;
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT A.CodeArt,Designation,PU,Qte FROM Article A,Detail D WHERE D.NumCom = '"+dataGridView1.Rows[index].Cells[0].Value.ToString()+ "' AND D.CodeArt = A.CodeArt", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                while (Program.dr.Read())
                {
                    dataGridView2.Rows.Add(Program.dr[0].ToString(), Program.dr[1].ToString(), Program.dr[2].ToString(), Program.dr[3].ToString(),Montant(float.Parse(Program.dr[2].ToString()),int.Parse(Program.dr[3].ToString())));
                    total += float.Parse(Montant(float.Parse(Program.dr[2].ToString()), int.Parse(Program.dr[3].ToString())));
                }

                tva = total * ttc + total;
                textBox5.Text = total.ToString();
                textBox6.Text = tva.ToString();

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("DELETE FROM Detail WHERE NumCom = " + dataGridView1.Rows[index].Cells[0].Value.ToString() + "", Program.con);
                Program.CmdSelect.ExecuteNonQuery();
                Program.CmdSelect = new SqlCommand("DELETE FROM Commande WHERE NumCom = "+dataGridView1.Rows[index].Cells[0].Value.ToString()+"", Program.con);
                Program.CmdSelect.ExecuteNonQuery();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                Program.con.Close();
                dataGridView1.Rows.RemoveAt(index);
            }
        }
    }
}
