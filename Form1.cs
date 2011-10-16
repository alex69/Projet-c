using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Generateur_MCD_MLD
{
    public partial class Form1 : Form
    {
        Point Start;
        Point Fin;
        Boolean clic;
        ArrayList tabpoint = new ArrayList();
        public Form1()
        {
            InitializeComponent();
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

        private void panel1_Click(object sender, EventArgs e)
        {
            if (_buttonIsMoving)
                return;

            // Traitement à effectuer lors d'un clique sur le boutton
            clic = true;
            Start = new Point(Table.Width, (Table.Height/2));
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

      
        private void Form1_Click(object sender, EventArgs e)
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
                NewGraphic.Clear(Color.LightBlue);
                afficherleslignes();
                Pen myPen = new Pen(System.Drawing.Color.Black, 2);
                NewGraphic.DrawLine(myPen, Start, new Point(e.X, e.Y));
                
            }
        }
         Graphics NewGraphic;
            
        private void Form1_Load(object sender, EventArgs e)
         {
             NewGraphic = this.CreateGraphics();
            clic = false;
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
        }
    }

    public class Ligne
    {
        public Pen pens;
        public Point Starts;
        public Point Fins;
    }

    public class Table
    {
        public string nom { get; set; }
        public ArrayList listepoints(Point pt) { get; set; }
        public ArrayList listelignes { get; set; }
    }
}
