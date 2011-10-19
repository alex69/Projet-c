using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml.Serialization;
namespace Generateur_MCD_MLD
{   [Serializable]
    public class LOAD
    {
      
        ArrayList  VTable = new ArrayList();
        public string nom;

    public String lectureVtable(){ //Renvoi une chaine contenant tous les noms des tables
        String str = "";
        foreach (Table tab in VTable)
         {
            str = str + ";" + tab.nom;  
         }
         return str;    
    }

        public void addVtable(Table tb) {//Ajoute un objet TABLE dans Vtable
            VTable.Add(tb);
        }

        public ArrayList getVtable() {//Return l'arraylist VTABLE
            return VTable;
        }
    }
}
