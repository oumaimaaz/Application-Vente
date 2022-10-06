using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vente
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void show(Form f)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void listeDesNomDesClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listeDesNomDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            show(new Form1());
        }

        private void listeDesClientsDuneVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(new Form2());
        }

        private void nombreDeClientParVilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(new Form3());
        }

        private void consultationDesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            show(new Form7());
        }

        private void majClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(new Form4());
        }

        private void majArticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(new Form5());
        }

        private void saisieCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show(new Form6());
        }
    }
}
