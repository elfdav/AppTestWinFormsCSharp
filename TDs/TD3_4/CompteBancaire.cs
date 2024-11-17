using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWinFormsCSharp.TDs.TD3_4
{
    public class CompteBancaire
    {
        const int tentatives_max_debit = 2;
        string nom_client;
        decimal montant_compte;
        bool compte_bloque;
        int tentatives_debit;

        static int cpt_client;
        static int cpt_client_bloques;

        public CompteBancaire(string nom_client, decimal montant_compte, bool compte_bloque)
        {
            this.nom_client = nom_client;
            this.montant_compte = montant_compte;
            this.compte_bloque = compte_bloque;
            cpt_client++;
            
        }

        public CompteBancaire(string nom_client, decimal montant_compte)
        {
            this.nom_client = nom_client;
            this.montant_compte=montant_compte;
            cpt_client++;
        }

        public string Nom_client
        {
            get { return nom_client; }
            
        }

        public decimal Montant_Compte
        {
            get { return montant_compte; } 
        }
        
        public bool debiter_compte(decimal valeur_a_debiter)
        {
            if (compte_bloque)
                return false;
            
            if (valeur_a_debiter > montant_compte)
            {
                tentatives_debit++;

                if (tentatives_debit == tentatives_max_debit)
                {
                    compte_bloque = true;
                    cpt_client_bloques++;
                    return false;
                }

                return false;
            }

            montant_compte -= valeur_a_debiter;

            return true;
        }

        public bool crediter_compte(decimal valeur_a_crediter)
        {
            montant_compte += valeur_a_crediter;
            if(montant_compte > 0)
            {
                tentatives_debit = 0;
                compte_bloque = false;
                cpt_client_bloques--;
            }
            return true;
        }   

        public static int nombre_client()
        {
            return cpt_client;
        }

        public static int nombre_client_bloqué()
        {
            return cpt_client_bloques;
        }
    }
}
