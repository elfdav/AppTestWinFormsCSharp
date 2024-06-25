using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWinFormsCSharp.Classes
{
    public class Personne
    {
        #region Constructors
        public Personne()
        {
        }
        public Personne(string Prenom, int Age, string Nom)
        {
        }
        // La signature d'une méthode définie plusieurs fois DOIT être différente au niveau de l'ordre
        // du type des parametres ! (Pas au niveau des noms des parametres !)
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

        #region Champs
        private string nom;
        private string prenom;
        private int age;
        private int telephone;
        #endregion Champs

        #region Properties
        public string Nom
        {
            get { return this.nom; }
            set
            {
                if (value == null || value.Trim().Length == 0) { Console.WriteLine("Nom Invalide"); nom = null; }
                else { nom = value; }
            }
        }
        public string Prenom
        {
            get { return this.prenom; }
            set
            {
                if (value == null || value.Trim().Length == 0)
                {
                    Console.WriteLine("Prénom Invalide"); prenom = null;
                }
                else { prenom = value; }
            }
        }
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
        public int Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }
        private static int nombrePersonnes = 0;
        public static int NombrePersonnes
        {
            get { return nombrePersonnes; }
        }
        #endregion Properties

        #region Operators
        public static bool  operator == (Personne a, Personne b)
        {
            if (a.nom == b.nom && a.prenom == b.prenom && 
                a.age == b.age && a.telephone == b.telephone)
                return true;
            
            else return false;
        }
        public static bool operator !=(Personne a, Personne b)
        {
            if (a.nom != b.nom || a.prenom != b.prenom &&
                a.age != b.age || a.telephone != b.telephone)
                return true;

            else return false;
        }
        #endregion Operators

        #region Public methods
        public string renvoyer_nom_complet()
        {
            return prenom + " " + nom;
        }
        public string Identifie()
        {
            string s = "p=(" + this.prenom + "," + this.nom + "," + this.age + "," + this.telephone + ")";
            return s;
        }
    }
        #endregion Public methods
}