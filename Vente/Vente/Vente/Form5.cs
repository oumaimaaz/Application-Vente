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
    public partial class Form5 : Form
    {
        public Form5()
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
                Program.CmdSelect = new SqlCommand("SELECT * FROM Article", Program.con);
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



        private void Form5_Load(object sender, EventArgs e)
        {
            fill(label5);

            textBox1.DataBindings.Add("text",Program.ClientBS, "CodeArt");
            textBox2.DataBindings.Add("text", Program.ClientBS, "Designation");
            textBox3.DataBindings.Add("text", Program.ClientBS, "PU");
            textBox5.DataBindings.Add("text", Program.ClientBS, "QStock");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.ClientBS.MoveFirst();
            label5.Text = (Program.ClientBS.Position + 1 + "/" + Program.ClientBS.Count).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.ClientBS.MovePrevious();
            label5.Text = (Program.ClientBS.Position + 1 + "/" + Program.ClientBS.Count).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.ClientBS.MoveNext();
            label5.Text = (Program.ClientBS.Position + 1 + "/" + Program.ClientBS.Count).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.ClientBS.MoveLast();
            label5.Text = (Program.ClientBS.Position + 1 + "/" + Program.ClientBS.Count).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("INSERT INTO Article VALUES(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox5.Text + "')", Program.con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Program.con.Open();
                Program.CmdSelect = new SqlCommand("UPDATE Article SET Designation = '" + textBox2.Text + "', PU = " + textBox3.Text + ",QStock = '" + textBox5.Text + "' WHERE CodeArt = "+textBox1.Text+"", Program.con);
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
                Program.CmdSelect = new SqlCommand("DELETE FROM Article WHERE CodeArt = " + textBox1.Text + "", Program.con);
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
                Program.CmdSelect = new SqlCommand("SELECT * FROM Article WHERE CodeArt = " + textBox4.Text + "", Program.con);
                Program.dr = Program.CmdSelect.ExecuteReader();
                if (Program.dr.Read())
                {
                    textBox1.Text = Program.dr[0].ToString();
                    textBox2.Text = Program.dr[1].ToString();
                    textBox3.Text = Program.dr[2].ToString();
                    textBox5.Text = Program.dr[3].ToString();
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
