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

        #region Constructors
        public Personne()
        {
        }
        public Personne(string Nom, string Prenom)
        {
            this.nom = Nom;
            this.prenom = Prenom;
        }
        public Personne(Personne p)
        {
            this.nom = p.nom;
            this.prenom = p.prenom;
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
