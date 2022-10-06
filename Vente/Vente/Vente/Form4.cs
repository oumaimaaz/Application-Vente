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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void fill(Label l)
        {
            try
            {
                if (Program.dt.Rows.Count > 0)
                {
                    Program.dt.Rows.Clear();
                }
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT * FROM Client", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                Program.dt.Load(Program.dr);
                Program.ClientBS.DataSource = Program.dt;
                l.Text = (Program.ClientBS.Position + 1 + "/" + Program.ClientBS.Count).ToString();
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

        private void Form4_Load(object sender, EventArgs e)
        {
            fill(label5);
           
            textBox1.DataBindings.Add(new Binding("text", Program.ClientBS,"CodeCl"));
            textBox2.DataBindings.Add(new Binding("text", Program.ClientBS, "Nom"));
            textBox3.DataBindings.Add(new Binding("text", Program.ClientBS, "Ville"));
        }

        //Ajouter
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("INSERT INTO Client VALUES("+textBox1.Text+",'"+textBox2.Text+"','"+textBox3.Text+"')", Program.con);
                Program.CmdSelect.ExecuteNonQuery();
                MessageBox.Show("Succès !");
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                Program.con.Close();
                fill(label5);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.ClientBS.MoveFirst();
            label5.Text = (Program.ClientBS.Position+1 + "/" + Program.ClientBS.Count).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ClientBS.MovePrevious();
            label5.Text = (Program.ClientBS.Position+1 + "/" + Program.ClientBS.Count).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.ClientBS.MoveNext();
            label5.Text = (Program.ClientBS.Position+1 + "/" + Program.ClientBS.Count).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.ClientBS.MoveLast();
            label5.Text = (Program.ClientBS.Position+1 + "/" + Program.ClientBS.Count).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("UPDATE Client SET Nom = '"+textBox2.Text+"', Ville = '"+textBox3.Text+"' WHERE CodeCl="+textBox1.Text+"", Program.con);
                Program.CmdSelect.ExecuteNonQuery();
                MessageBox.Show("Succès !");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                Program.con.Close();
                fill(label5);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("DElETE FROM Client WHERE CodeCl=" + textBox1.Text + "", Program.con);
                Program.CmdSelect.ExecuteNonQuery();
                MessageBox.Show("Succès !");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            finally
            {
                Program.con.Close();
                fill(label5);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("SELECT * FROM Client WHERE CodeCl = " + textBox4.Text+"", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                if (Program.dr.Read())
                {
                    textBox1.Text = Program.dr[0].ToString();
                    textBox2.Text = Program.dr[1].ToString();
                    textBox3.Text = Program.dr[2].ToString();
                }
                else
                {
                    MessageBox.Show("Client introuvable !");
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

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
