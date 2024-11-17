using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.Classes
{
    public class Complexe
    {
        int entiere;
        int imaginaire;

        public Complexe(int entiere, int imaginaire)
        {
            this.entiere = entiere;
            this.imaginaire = imaginaire;
        }
        public string toString()
        {
            return "partie entiere : " + entiere + "/n" + "partie imaginaire : " + imaginaire;
        }
        public static bool operator ==(Complexe a, Complexe b)
        {
            if (a.entiere == b.entiere && a.imaginaire == b.imaginaire)
                return true;

            return false;
        }
        public static bool operator !=(Complexe a, Complexe b)
        {
            if (a.entiere != b.entiere || a.imaginaire != b.imaginaire)
                return true;

            return false;
        }
        public double Module()
        {
            return Math.Sqrt(entiere * entiere + imaginaire * imaginaire);
        }
    }
}

