using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.TestEvents
{
    public class EcouteurType1
    {
        public void OnVitesseAtteinte(int vitesse)
        {
            Console.WriteLine("vitesse {0} atteinte dans l'écouteur type 1", vitesse);
        }
    }
}
