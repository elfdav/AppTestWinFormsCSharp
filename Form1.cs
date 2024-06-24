using TestWinFormsC_.Classes;

namespace TestWinFormsC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Personne personne;
            personne = new Personne("Elfassy", "Eden");
            string nom_prenom = personne.renvoyer_nom_complet();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
