using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Generateur_MCD_MLD
{
    public partial class frmCreation : Form
    {
        LOAD loadencours = new LOAD();
        Form1 frm = new Form1();
        public void chargerload() { 
        
        loadencours = frm.deserialisation();
        MessageBox.Show(loadencours.nom);
        }
        public frmCreation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Table tb = new Table();
            tb.nom = textBox1.Text;
            loadencours.addVtable(tb);
            frm.serialisationload(loadencours);
            affichertable();
            textBox1.Text = "";
            textBox1.Focus();
        }
        public void affichertable() {
            listBox1.Items.Clear();
            foreach (Table tab in loadencours.getVtable())
            {
                listBox1.Items.Add(tab.nom);
            }    
        }
        private void frmCreation_Load(object sender, EventArgs e)
        {
            chargerload();
            affichertable();
        }
    }
}
