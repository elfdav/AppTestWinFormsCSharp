using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.TDs.TD7_8
{
    public class Position
    {
        int ligne;
        int colonne;

        public Position(int ligne, int colonne)
        {
            this.ligne = ligne;
            this.colonne = colonne;
        }

        public int Ligne
        {
            get { return ligne; }
            set { ligne = value; }
        }

        public int Colonne
        {
            get { return colonne; }
            set { colonne = value; }

        }

        public string toString()
        {
            return "Voici la position" + "(" + this.ligne +"," + this.colonne + ")";
        }

        public bool EstEgale(Position pos)
        {
            if(this.ligne  == pos.ligne && this.colonne == pos.colonne) 
                return true;

            return false;
        }
    }
}
