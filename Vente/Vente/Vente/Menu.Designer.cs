
namespace Vente
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeDesNomDesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesNomDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesClientsDuneVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeClientParVilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.majClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.majArticleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesNomDesClientToolStripMenuItem,
            this.miseÀJourToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeDesNomDesClientToolStripMenuItem
            // 
            this.listeDesNomDesClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesNomDesClientsToolStripMenuItem,
            this.listeDesClientsDuneVilleToolStripMenuItem,
            this.nombreDeClientParVilleToolStripMenuItem,
            this.consultationDesCommandesToolStripMenuItem});
            this.listeDesNomDesClientToolStripMenuItem.Name = "listeDesNomDesClientToolStripMenuItem";
            this.listeDesNomDesClientToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.listeDesNomDesClientToolStripMenuItem.Text = "Consultation";
            this.listeDesNomDesClientToolStripMenuItem.Click += new System.EventHandler(this.listeDesNomDesClientToolStripMenuItem_Click);
            // 
            // listeDesNomDesClientsToolStripMenuItem
            // 
            this.listeDesNomDesClientsToolStripMenuItem.Name = "listeDesNomDesClientsToolStripMenuItem";
            this.listeDesNomDesClientsToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listeDesNomDesClientsToolStripMenuItem.Text = "Liste des nom des clients";
            this.listeDesNomDesClientsToolStripMenuItem.Click += new System.EventHandler(this.listeDesNomDesClientsToolStripMenuItem_Click);
            // 
            // listeDesClientsDuneVilleToolStripMenuItem
            // 
            this.listeDesClientsDuneVilleToolStripMenuItem.Name = "listeDesClientsDuneVilleToolStripMenuItem";
            this.listeDesClientsDuneVilleToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.listeDesClientsDuneVilleToolStripMenuItem.Text = "Liste des clients d\'une ville";
            this.listeDesClientsDuneVilleToolStripMenuItem.Click += new System.EventHandler(this.listeDesClientsDuneVilleToolStripMenuItem_Click);
            // 
            // nombreDeClientParVilleToolStripMenuItem
            // 
            this.nombreDeClientParVilleToolStripMenuItem.Name = "nombreDeClientParVilleToolStripMenuItem";
            this.nombreDeClientParVilleToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.nombreDeClientParVilleToolStripMenuItem.Text = "Nombre de client par ville";
            this.nombreDeClientParVilleToolStripMenuItem.Click += new System.EventHandler(this.nombreDeClientParVilleToolStripMenuItem_Click);
            // 
            // consultationDesCommandesToolStripMenuItem
            // 
            this.consultationDesCommandesToolStripMenuItem.Name = "consultationDesCommandesToolStripMenuItem";
            this.consultationDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.consultationDesCommandesToolStripMenuItem.Text = "Consultation des commandes";
            this.consultationDesCommandesToolStripMenuItem.Click += new System.EventHandler(this.consultationDesCommandesToolStripMenuItem_Click);
            // 
            // miseÀJourToolStripMenuItem
            // 
            this.miseÀJourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.majClientToolStripMenuItem,
            this.majArticleToolStripMenuItem,
            this.saisieCommandeToolStripMenuItem});
            this.miseÀJourToolStripMenuItem.Name = "miseÀJourToolStripMenuItem";
            this.miseÀJourToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.miseÀJourToolStripMenuItem.Text = "Mise à jour";
            // 
            // majClientToolStripMenuItem
            // 
            this.majClientToolStripMenuItem.Name = "majClientToolStripMenuItem";
            this.majClientToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.majClientToolStripMenuItem.Text = "MajClient";
            this.majClientToolStripMenuItem.Click += new System.EventHandler(this.majClientToolStripMenuItem_Click);
            // 
            // majArticleToolStripMenuItem
            // 
            this.majArticleToolStripMenuItem.Name = "majArticleToolStripMenuItem";
            this.majArticleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.majArticleToolStripMenuItem.Text = "MajArticle";
            this.majArticleToolStripMenuItem.Click += new System.EventHandler(this.majArticleToolStripMenuItem_Click);
            // 
            // saisieCommandeToolStripMenuItem
            // 
            this.saisieCommandeToolStripMenuItem.Name = "saisieCommandeToolStripMenuItem";
            this.saisieCommandeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saisieCommandeToolStripMenuItem.Text = "SaisieCommande";
            this.saisieCommandeToolStripMenuItem.Click += new System.EventHandler(this.saisieCommandeToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listeDesNomDesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesNomDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientsDuneVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeClientParVilleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem majClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem majArticleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisieCommandeToolStripMenuItem;
    }
}