using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Serialization;
using System.IO;
using System.Xml.Serialization;
using System.Net;
using System.Threading;
using System.Data.OleDb;

using Microsoft.VisualBasic;
namespace Generateur_MCD_MLD
{
    public partial class Form1 : Form
    {
        private int cpt = 0;
        Graphics NewGraphic;
        Point Start;
        Point Fin;
        Boolean clic;
        ArrayList tabpoint = new ArrayList();
        LOAD loadencours = new LOAD();
        public Form1()
        {
           InitializeComponent();
        }

        public void chargerload() {

            loadencours = deserialisation();
        
        }
        private bool _mouseDownOverButton;

        // Indique si le boutton est en train d'être déplacé
        private bool _buttonIsMoving;

        // Contient les coordonnées de la souris par rapport au coin supérieur gauche du boutton
        private Point _cursOnButton;
     

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDownOverButton && !_buttonIsMoving)
            {
                _buttonIsMoving = true;
                _cursOnButton = new Point(e.X, e.Y);
                Table.BringToFront();
            }
            else if (_buttonIsMoving)
            {
                afficherleslignes();
                Point point = PointToClient(MousePosition);
                Table.Left = point.X - _cursOnButton.X;
                Table.Top = point.Y - _cursOnButton.Y;
            }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            if (_buttonIsMoving)
                return;

            // Traitement à effectuer lors d'un clique sur le boutton
            clic = true;
            Start = new Point((Table.Location.X+Table.Width), (Table.Location.Y+Table.Height/2));
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownOverButton = (e.Button == MouseButtons.Left);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDownOverButton = false;
            _buttonIsMoving = false;
        }


        private void Form1_Click(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Start.X == 0)
            {
                clic = true;
                Start = new Point(e.X, e.Y);
             }
            else {
                clic = false;
                Fin = new Point(e.X, e.Y);
                afficherligne();
            }
           
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clic == true)
            {
                NewGraphic.Clear(Color.WhiteSmoke);
                afficherleslignes();
                Pen myPen = new Pen(System.Drawing.Color.Black, 2);
                NewGraphic.DrawLine(myPen, Start, new Point(e.X, e.Y));

                if (e.Y > (Table.Location.Y+Table.Height)) {
                    //Si le curseur est en dessous de la table
                    Start = new Point((Table.Location.X + Table.Width/2), (Table.Location.Y + Table.Height));
                }
                else if ((e.Y < (Table.Location.Y + Table.Height)) && (e.Y < Table.Location.Y))
                {
                    //Si le curseur est au dessus de la table
                    Start = new Point((Table.Location.X + Table.Width / 2), (Table.Location.Y));
                }
                else if (e.X > (Table.Location.X + Table.Width))
                {
                    //Si le curseur est à droite de la table
                    Start = new Point((Table.Location.X + Table.Width), (Table.Location.Y + Table.Height / 2));
                }
                else if (e.X < (Table.Location.Y + Table.Height))
                {
                    //Si le curseur est à gauche de la table
                    Start = new Point((Table.Location.X), (Table.Location.Y + Table.Height / 2));
                }
                
            }
        }
      public void serialisationload(LOAD ld){ //on lui transmet l'objet LOAD que l'on veur serialiser! 
          // Attention! Le fichier load aura prealablement transmis devra posséder la deserialisation.
         try{  
              XmlSerializer serializer = new XmlSerializer(typeof(LOAD));
              TextWriter tw = new StreamWriter(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\book1.xml");
              serializer.Serialize(tw, ld);
              tw.Close(); 
         }catch {
         }
      }

        public LOAD deserialisation() { //Deserialise le fichier xml et nous renvois l objet
                        
            XmlSerializer serializer = new XmlSerializer(typeof(LOAD));
            TextReader tr = new StreamReader(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\book1.xml");
            LOAD tests = (LOAD)serializer.Deserialize(tr); 
            tr.Close(); 
            return tests;
             
       }
        private void Form1_Load(object sender, EventArgs e)
         {
             chargerload();
            NewGraphic = this.CreateGraphics();
            clic = false;
            compteur.Text = "Nombre de lignes :" + cpt.ToString() + " (Alexandre le Professionnel)";
        }

        public void afficherleslignes()
        {
            foreach (Ligne ligne in tabpoint)
            {
                NewGraphic.DrawLine(ligne.pens, ligne.Starts, ligne.Fins);
            }

        }

        public void afficherligne()
        {
            Graphics NewGraphic = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Black, 2);
            NewGraphic.DrawLine(myPen, Start, Fin);
            Ligne ligne = new Ligne();
            ligne.pens = myPen;
            ligne.Starts = Start;
            ligne.Fins = Fin;
            tabpoint.Add(ligne);
            Start = new Point(0, 0);
            Fin = new Point(0, 0);
            cpt++;
            compteur.Text = "Nombre de lignes :" + cpt.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOAD ld = new LOAD(); ;
            ld.test = "OUI";
           serialisationload(ld); // Je serialise mon fichier
               MessageBox.Show("Sérialisation effectuée avec succès!","OUIAIIIAIAI");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(deserialisation().test);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LOAD ok = new LOAD();
            ok.test = "kk";
            serialisationload(ok);
            MessageBox.Show(deserialisation().test);
        }

        
    }

}
