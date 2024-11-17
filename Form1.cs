using AppTestWinFormsCSharp.Classes;
using AppTestWinFormsCSharp.Classes_EE;
using AppTestWinFormsCSharp.TDs.TD3_4;

namespace AppTestWinFormsCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            R�vision_EE r�vision_EE = new R�vision_EE ("Elfassy", "Eden", 19);

            string nom = r�vision_EE.Nom;

            r�vision_EE.Nom = "dav";

            nom = r�vision_EE.Nom;

            string s = r�vision_EE.retourne_nom_complet();
            int i = R�vision_EE.compter_personne(); 

            Complexe complexe = new Complexe(3, 4);
            double module = complexe.Module();


            ///////////////////////////////////////////////////////////////////////////////

            // MATRICE LOSANGE AFFICHANT LA VALEUR "1" AUX EXTREMITES

            int[,] Matrice;

            int TailleMatrice = 11;

            Matrice = Revisions.InitiationMatrice(TailleMatrice, TailleMatrice);

            Revisions.AfficherMatrice(Matrice);

            return;

            ///////////////////////////////////////////////////////////////////////////////

            // REDEFINITION DE L'OPERATEUR DE COMPARAISON

            DateTime dateNaissanceEE = new DateTime(2005, 07, 28);

            Person P1 = new Person("Eden", "Elfassy", dateNaissanceEE, '2', "", "");

            int Age = P1.Age();

            
            DateTime dateNaissanceDE = new DateTime(2005, 10, 28);

            Person P2 = new Person("David", "Elfassy", dateNaissanceDE, '1', "", "");


            if (P1 == P2)
                Console.WriteLine("P1 et P2 sont la m�me personne");
            else
                Console.WriteLine("P1 et P2 sont deux personnes diff�rentes");
            
            if (P1 != P2)
                Console.WriteLine("P1 et P2 sont deux personnes diff�rentes");
            else
                Console.WriteLine("P1 et P2 sont la m�me personne");

            ///////////////////////////////////////////////////////////////////////////////
            
            int NombreDePersonnesInstanci�es = Person.NombrePersonnes;
        }
    }
}