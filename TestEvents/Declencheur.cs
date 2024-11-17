using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.TestEvents
{
    public class Declencheur
    {
        private int vitesseMax;

        public Declencheur()
            : this(100)
        {
        }

        public Declencheur(int vMax) // syntaxe paramètre optionnel
        {
            vitesseMax = vMax;
        }

        public delegate void AtteindreVitesseMax(int vitesse);
        public event AtteindreVitesseMax Seuil1;

        internal void AugmenterVitesse(int limiteVitesse)
        {
            for (int i = 0; i < limiteVitesse; i++)
            {
                if (i == vitesseMax)
                {
                    Seuil1(i);
                }
            }
        }
        
        // Méthode pour obtenir la liste des abonnés à l'événement Seuil1
        public Delegate[] GetAbonnes()
        {
            return Seuil1?.GetInvocationList() ?? new Delegate[0]; // Retourne un tableau vide si aucun abonné
        }
    }
}
