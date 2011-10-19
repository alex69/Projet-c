using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Generateur_MCD_MLD
{   [Serializable]
    public class LOAD
    {
     
        ArrayList  VTable = new ArrayList();
        public string nom;
        public void addVtable(Table tb) {
            VTable.Add(tb);
        }

        public ArrayList getVtable() {
            return VTable;
        }
    }
}
