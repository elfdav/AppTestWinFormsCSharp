using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.TestEvents
{
    public class EcouteurType2
    {
        public void OnVitesseAtteinte(int vitesse)
        {
            Console.WriteLine("vitesse {0} atteinte dans l'écouteur type 2", vitesse);
        }
    }
}
