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
            this.Table = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Table.Location = new System.Drawing.Point(24, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(165, 209);
            this.Table.TabIndex = 0;
            this.Table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.Table.Click += new System.EventHandler(this.panel1_Click);
            this.Table.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.Table.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(727, 438);
            this.Controls.Add(this.Table);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Table;
    }
}

