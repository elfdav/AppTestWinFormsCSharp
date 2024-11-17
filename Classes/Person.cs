using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.Classes
{
    public class Person
    {
        #region Private variables

        string? firstname;
        string? lastname;
        DateTime birthdate;
        char sex;
        string? address;
        string? phone;

        #endregion Private variables

        #region Constructors
        public Person()
        {
        }
        public Person(string Firstname, string Lastname, DateTime Birthdate, char Sex, string Address, string Phone)
        {
            this.firstname = Firstname;
            this.lastname = Lastname;
            this.birthdate = Birthdate;
            this.sex = Sex;
            this.address = Address;
            this.phone = Phone; 

            nombrePersonnes++;
        }
        public Person(Person p)
        {
            this.firstname = p.firstname;
            this.lastname = p.lastname;
            this.birthdate = p.birthdate;
            this.sex = p.sex;
            this.address = p.address;
            this.phone = p.phone;
        }
        #endregion Constructors
                
        #region Properties

        //public string Lastname
        //{
        //    get { return this.lastname; }
        //    set
        //    {
        //        if (value == null || value.Trim().Length == 0) { Console.WriteLine("Nom Invalide"); lastname = null; }
        //        else { lastname = value; }
        //    }
        //}

        private static int nombrePersonnes = 0;

        public static int NombrePersonnes
        {
            get { return nombrePersonnes; }
        }
        #endregion Properties

        #region Operators
        
        public static bool operator == (Person a, Person b)
        {
            if (a.Age() == b.Age())
                return true;

            return false;
        }

        public static bool operator != (Person a, Person b)
        {
            if (a.Age() != b.Age())
                return true;

            return false;
        }

        #endregion Operators

        #region Public methods
        public string Renvoyer_nom_complet()
        {
            return firstname + " " + lastname;
        }
        public string Identifie()
        {
            string s = "p=(" + this.firstname + "," + this.lastname + "," + this.birthdate.ToString() + "," + this.phone + ")";
            return s;
        }
        public int Age()
        {
            // Récupérer l'année de naissance
            int anneeNaissance = birthdate.Year;
            // Récupérer l'année courante
            int anneeCourante = DateTime.Now.Year;
            // Calculer l'âge initial
            int age = anneeCourante - anneeNaissance;

            // Vérifier si l'anniversaire est passé cette année
            if (DateTime.Now < new DateTime(anneeCourante, birthdate.Month, birthdate.Day))
            {
                age--;  // Si l'anniversaire n'est pas encore passé, on enlève une année
            }

            return age;  // Retourner l'âge calculé
        }
    }
        #endregion Public methods
}