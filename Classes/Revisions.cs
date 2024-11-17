using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.Classes
{
    public class Revisions
    {
        #region Périmètre d'un losange avec un FOR
        public static int[,] InitiationMatrice(int hauteur, int largeur)
        {
            // Ini de la matrice (par défaut avec la valeur 0)
            int[,] matrice = new int[hauteur, largeur];

            // Calcul du milieu de la matrice carrée
            int milieu = hauteur / 2;

            int matriceLenght = matrice.GetLength(0);

            int j = 0;

            for (int i = 0; i < matriceLenght; i++)
            {
                if (i <= milieu)
                {
                    if (i == 0)
                        matrice[i, milieu] = 1;
                    else
                    {
                        // Placer les 1 sur les positions du losange
                        matrice[i, milieu - i] = 1;
                        matrice[i, milieu + i] = 1;
                    }
                }

                if (i > milieu)
                {
                    j++;

                    // Placer les 1 sur les positions du losange
                    matrice[i, j] = 1;
                    matrice[i, (matriceLenght - (j + 1))] = 1;
                }
            }

            return matrice;
        }
        public static void AfficherMatrice(int[,] Matrice)
        {
            int matriceLenght = Matrice.GetLength(0);

            for (int i = 0; i < matriceLenght; i++)
            {
                for (int j = 0; j < matriceLenght; j++)
                {
                    Console.Write(Matrice[i, j]);
                }
                Console.WriteLine();
            }
        }
        #endregion Périmètre d'un losange avec un FOR
    }
}
