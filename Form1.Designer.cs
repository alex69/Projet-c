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
            this.compteur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Table.Location = new System.Drawing.Point(106, 100);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(165, 209);
            this.Table.TabIndex = 0;
            this.Table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.Table.Click += new System.EventHandler(this.Table_Click);
            this.Table.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.Table.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // compteur
            // 
            this.compteur.AutoSize = true;
            this.compteur.Location = new System.Drawing.Point(519, 9);
            this.compteur.Name = "compteur";
            this.compteur.Size = new System.Drawing.Size(95, 13);
            this.compteur.TabIndex = 1;
            this.compteur.Text = "Nombre de lignes :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Je serialise ma class LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Je deserialise mon fichier XML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(727, 438);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.compteur);
            this.Controls.Add(this.Table);
            this.Name = "Form1";
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

