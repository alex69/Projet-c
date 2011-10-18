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
    class Table
    {
        public int taille { get; set; }
        public string couleur { get; set; }
        public string nom { get; set; }
        public ArrayList listepoints { get; set; }
        public ArrayList listelignes { get; set; }
    }
}
