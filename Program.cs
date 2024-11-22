using AppTestWinFormsCSharp.TestEvents;
using AppTestWinFormsCSharp.TDs.TD3_4;
using AppTestWinFormsCSharp.TDs.TD7_8;

namespace AppTestWinFormsCSharp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            #region TP7-8

            string[] schema1 = { "*******", "*d    *", "**   a*", "*******" };
            Labyrinthe laby = new Labyrinthe(schema1, 4, 7);

            // Effectuer tous les controles d'intégrité sur la matrice
            if (!laby.ini())
                return;
                // Prévenir et sortir du prog !

            #endregion TP7-8

            #region TP3-4

            CompteBancaire cbEden = new CompteBancaire("Eden", 100);
            CompteBancaire cbDavid = new CompteBancaire("David", 1000);
            CompteBancaire cbDelphine = new CompteBancaire("Delphine", 10000);

            cbEden.debiter_compte(2000);
            cbEden.debiter_compte(2000);
            
            cbDavid.debiter_compte(1100);
            cbDavid.debiter_compte(1100);

            int total_client_bloqué = CompteBancaire.nombre_client_bloqué();

            cbEden.crediter_compte(50);

            int total_client = CompteBancaire.nombre_client();
            total_client_bloqué = CompteBancaire.nombre_client_bloqué();

            #endregion TP3-4

            // Note importante : Ne pas mettre les points d'entrée des prog apres Application.Run(new Form1());
            #region TestDav
            EcouteurType1 E1 = new EcouteurType1();
            EcouteurType2 E2 = new EcouteurType2();
            Declencheur mon1erDeclencheur = new Declencheur(280);

            mon1erDeclencheur.Seuil1 += E1.OnVitesseAtteinte;
            mon1erDeclencheur.Seuil1 += E2.OnVitesseAtteinte;

            // Connaitre la liste de tous les abonnés
            var listeAbonnés = mon1erDeclencheur.GetAbonnes().ToList();

            mon1erDeclencheur.AugmenterVitesse(325);
            Console.ReadLine();
            #endregion TestDav

            Application.Run(new Form1());
        }
    }
}