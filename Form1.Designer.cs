namespace Generateur_MCD_MLD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Table = new System.Windows.Forms.Panel();
            this.compteur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.AccessibleDescription = null;
            this.Table.AccessibleName = null;
            resources.ApplyResources(this.Table, "Table");
            this.Table.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Table.BackgroundImage = null;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Table.Font = null;
            this.Table.Name = "Table";
            this.Table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.Table.Click += new System.EventHandler(this.Table_Click);
            this.Table.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.Table.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // compteur
            // 
            this.compteur.AccessibleDescription = null;
            this.compteur.AccessibleName = null;
            resources.ApplyResources(this.compteur, "compteur");
            this.compteur.Font = null;
            this.compteur.Name = "compteur";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = null;
            this.button1.AccessibleName = null;
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = null;
            this.button1.Font = null;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = null;
            this.button2.AccessibleName = null;
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackgroundImage = null;
            this.button2.Font = null;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = null;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.compteur);
            this.Controls.Add(this.Table);
            this.Font = null;
            this.Icon = null;
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Table;
        private System.Windows.Forms.Label compteur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

