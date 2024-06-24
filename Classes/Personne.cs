using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinFormsC_.Classes
{
    public class Personne
    {
        #region Champs
        private string nom;
        private string prenom;
        private int age;
        private int telephone;
        #endregion Champs

        #region Properties
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 120)
                    value = 100;

                age = value;
            }
        }

        private static int nombrePersonnes = 0;
        public static int NombrePersonnes
        {
            get { return nombrePersonnes; }
        }
        #endregion Properties

        #region Constructors
        public Personne()
        {
        }
        public Personne(string Nom, string Prenom, int Age)
        {
            this.nom = Nom;
            this.prenom = Prenom;
            this.age = Age;
            nombrePersonnes++;
        }
        public Personne(Personne p)
        {
            this.nom = p.nom;
            this.prenom = p.prenom;
            this.age = p.age;  
        }
        #endregion Constructors

        #region Public methods
        public string renvoyer_nom_complet()
        {
            return prenom + " " + nom;
        }
        #endregion Public methods
    }


}
