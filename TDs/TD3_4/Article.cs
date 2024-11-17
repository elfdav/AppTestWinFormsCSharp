using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppTestWinFormsCSharp.TDs.TD3_4
{
    public class Article
    {
		// variables d'instance
        private long reference;
        private string intitule;
        private float prixHT;
        private int quantiteStock;
        
        // variable de classe
        private static int nbArticles;

		public Article(long reference, string intitule, float prixHT, int quantiteStock)
        {
			// this désigne l'instance courante
			this.reference = reference;
            this.intitule = intitule;
			this.prixHT = prixHT;
			this.quantiteStock = quantiteStock;
			
			// variable de classe
			Article.nbArticles++;
        }
        
        public long Reference
        {
            get { return reference; }
        }
      
        public string Intitule
        {
            get { return intitule; }

        }
       
        public float PrixHT
        {
            get { return prixHT; }
            set { prixHT = value; }
        }
       
        public int QuantiteStock
        {
            get { return quantiteStock; }
			set { quantiteStock = value; }
        }

        public  void Approvisionner( int NombrePieces)
		{
            this.quantiteStock = this.quantiteStock + NombrePieces;
        }

        public Boolean Vendre(int nombreUnites)
        {
            bool condition = true;
            if (nombreUnites < this.quantiteStock)
            {
                this.quantiteStock = this.quantiteStock - nombreUnites;
                Console.WriteLine("la quantité en stock :" + this.quantiteStock);
            }
            else
            {
                condition = false;
                Console.WriteLine("Le stock est insuffisant");
            }
            return condition;
        }
            
        public float PrixTTC()
        {
            return 1.2f * prixHT;

        }

        public String toString()
        {
            return "L'article de référence " + Reference + " s'intitule " + Intitule + " est au prix de " 
								+ PrixHT + " euros \n" + "sa quantité en stock est égale à " + QuantiteStock
								+ Article.nbArticles + " articles";

        }
        
        public bool Equals(Article obj)
        {
            return (this.Reference == obj.Reference);
        }
		
		public void MainForArticle()
        {

            Article a = new Article(12, "Fruits", 10.8f, 10);
           // a --> reference 12, intitule Fruits", prix 10.8, quantiteStock 10

			Console.WriteLine(a.toString());
			
			Console.WriteLine("reference : " + a.Reference);
			Console.WriteLine("intitulé : " + a.Intitule);
			Console.WriteLine("getPrixHT : " + a.PrixHT);
            Console.WriteLine("quantité en stock : " + a.QuantiteStock);
			a.QuantiteStock = 20;
			a.Approvisionner(30);
			Console.WriteLine(a.toString());
			
			if (a.Vendre(15) == true)
			{
				Console.WriteLine(a.toString());
			}
			
			Article b = new Article(25, "Legumes", 8.3f, 10);
			Article c = new Article(12, "Fruits", 10.8f, 10);
			
			Console.WriteLine(a.Equals(b));
			Console.WriteLine(a.Equals(c));
		}
    }
}


