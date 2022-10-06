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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private string Montant(float pu, int qu)
        {
            return (pu * qu).ToString();
        }

        private string qte;
        private int index;

        private void total()
        {
            
            float total = 0;
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                total += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            textBox7.Text = total.ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
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

            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT CodeArt FROM Article", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                while (Program.dr.Read())
                {
                    comboBox2.Items.Add(Program.dr[0].ToString());
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

            dataGridView1.Columns.Add("code","Code Article");
            dataGridView1.Columns.Add("des", "Designation");
            dataGridView1.Columns.Add("pu", "PU");
            dataGridView1.Columns.Add("Qu", "Quntité");
            dataGridView1.Columns.Add("montant", "Montant");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT Nom,Ville FROM Client WHERE CodeCl = "+comboBox1.Text+"", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                if (Program.dr.Read())
                {
                    textBox2.Text = Program.dr[0].ToString();
                    textBox3.Text = Program.dr[1].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Add(comboBox2.Text,textBox4.Text,textBox5.Text,textBox6.Text, Montant(float.Parse(textBox5.Text), int.Parse(textBox6.Text)) );
              
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

            total();
            if (int.Parse(qte) < int.Parse(textBox6.Text))
            {
                MessageBox.Show("Stock insuffisant!");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT Designation,PU,QStock FROM Article WHERE CodeArt = " + comboBox2.Text + "", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                if (Program.dr.Read())
                {
                    textBox4.Text = Program.dr[0].ToString();
                    textBox5.Text = Program.dr[1].ToString();
                    qte = Program.dr[2].ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(index);
                total();
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("INSERT INTO Commande VALUES("+textBox1.Text+",'"+dateTimePicker1.Text+"',"+comboBox1.Text+")", Program.con);
                Program.CmdSelect.ExecuteNonQuery();

                Program.CmdSelect = new SqlCommand("INSERT INTO Detail VALUES(" + textBox1.Text + "," + comboBox2.Text + "," + textBox6.Text + ")", Program.con);
                Program.CmdSelect.ExecuteNonQuery();
                
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                Program.con.Close();
            }


            try
            {
                Program.con.Open();
                int qtes = 0;

                for (int i = 0; i < dataGridView1.Rows.Count-1 ; i++)
                {
                    Program.CmdSelect = new SqlCommand("SELECT QStock FROM Article WHERE CodeArt=" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "", Program.con);
                    Program.dr = Program.CmdSelect.ExecuteReader();
                    if (Program.dr.Read())
                    {
                        qtes = int.Parse(Program.dr[0].ToString()) - int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                        Program.dr.Close();
                        Program.CmdSelect = new SqlCommand("UPDATE Article SET QStock= " + qtes + " WHERE CodeArt=" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "", Program.con);
                        Program.CmdSelect.ExecuteNonQuery();
                    }
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
