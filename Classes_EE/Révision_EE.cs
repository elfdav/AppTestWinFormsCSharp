using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.Classes_EE
{
    public class Révision_EE
    {
        string nom;
        string prénom;
        int age;

        int total;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        #region "Constructors"
        public Révision_EE(string nom, string prénom, int age)
        {
            this.nom = nom;
            this.prénom = prénom;   // cosntructeur naturel = constructeur avec tous les attributs
            this.age = age;
        }

        public Révision_EE()
        {

        }
        #endregion "Constructors" 

        public string retourne_nom_complet()
        {
            return "Le prénom :" + prénom + "Le nom :" + nom; // Méthode d'instance, donc on appelle que avec l'instance r minuscuel 
        }

        public static int compter_personne()
        {

            return 0;
        }
    }

}
