using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppTestWinFormsCSharp.TDs.TD7_8
{
    public class Labyrinthe
    {
        private string[] tab;
        private int[,] matrice;
        private int nbLignes;
        private int nbColonnes;

        private Position depart;
        private Position arrivee;

        private const char char_mur = '*';

        private const int espace = 0;
        private const int mur = 1;
        private const int char_depart = 2;
        private const int char_arrivee = 3;
        private const int personnage = 4;

        public int NbLignes
        {
            get { return nbLignes; }
            set { nbLignes = value; }
        }

        public int NbColonnes
        {
            get { return nbColonnes; }
            set { nbColonnes = value; }
        }

        public Labyrinthe(string[] tab, int nbLignes, int nbColonnes) // on peut mettre des choses extérieurs qui ne corresponde pas forcément une relation direct avec la classe comme habituellement
        {
            int numLigne = 0;

            this.tab = tab;

            this.NbLignes = nbLignes;

            this.NbColonnes = nbColonnes;

            matrice = new int[nbLignes, nbColonnes];

            foreach (string ligne in tab)
            {
                for (int numCol = 0; numCol < nbColonnes; numCol++)
                {
                    // A chaque caractère correspond une valeur entière a affecter à une case de votre matrice M
                    matrice[numLigne, numCol] = obtenir_code_char_environnement(ligne[numCol]);
                }
                numLigne++;
            }
           
        }
        private int obtenir_code_char_environnement(char car)
        {
            switch (car)
            {
                // Espace
                case ' ':
                    return 0;
                // Mur
                case '*':
                    return 1;
                // Char depart
                case 'd':
                    return 2;
                // Char arrivee
                case 'a':
                    return 3;
                // Personnage
                case 'p':
                    return 4;
                default:
                    return -1;
            }
        }
        
        public bool ini()
        {
            if (!verifier_integriter_data(tab, NbLignes, NbColonnes))
                return false;

            // Initialiser les positions "depart" et "arrivee" selon le modèle du labyrinthe
            // todo: Code à implémenter...


            return true;
        }
        
        public bool verifier_integriter_data(string[] matrice, int nbLignes, int nbColonnes)
        {
            // Vérifier qu'il existe une (et une seule) position de départ d et une (et une seule) position d'arrivée a
            if (!verifier_existence_des_positions(matrice, nbLignes, nbColonnes))
                return false;
            
            // Vérifiez que le labyrinthe est entouré de murs
            if(!verifier_murs_entourent_labyrinthe(matrice, nbLignes, nbColonnes))
                return false;

            // parcourir tout le tableau puis analyser chaque ligne

            // Vérifiez que chaque ligne possède le même nombre de colonnes

            return true;
        }

        private bool verifier_existence_des_positions(string[] tab, int nbLignes, int nbColonnes)
        {
            int nbreCharA = 0;
            int nbreCharD = 0;

            foreach (var ligne in tab)
            {
                if (ligne.Contains("a"))
                    nbreCharA++;

                if (ligne.Contains("d"))
                    nbreCharD++;

                if (nbreCharD > 1)
                    return false;

                if (nbreCharA > 1)
                    return false;
            }
            return true;
        }
        
        private bool verifier_murs_entourent_labyrinthe(string[] tab, int nbLignes, int nbColonnes)
        {
            string first_line = tab[0];
            string last_line = tab[nbLignes - 1];

            #region Recherche mur haut et bas
            // Recherche si mur présents sur premiere et derniere ligne 
            foreach (char c in first_line)
            {
                if (c != char_mur)
                {
                    return false;
                }
            }

            foreach (char c in last_line)
            {
                if (c != char_mur)
                {
                    return false;
                }
            }
            #endregion Recherche mur haut et bas

            #region Recherche mur gauche et droite
            string ligne = "";

            // recherche si mur présent entre la deuxieme et l'avant derniere ligne et au début de chacune de ces lignes
            for (int num_ligne = 1; num_ligne < nbLignes-2; num_ligne++)
            {
                ligne = tab[num_ligne];

                // Le premier char ET le dernier DOIVENT être de type "mur"
                if (ligne[0] != char_mur || ligne[nbColonnes-1] != char_mur)
                    return false;
            }
            #endregion Recherche mur haut et bas

            return true;
        }
    }
}
