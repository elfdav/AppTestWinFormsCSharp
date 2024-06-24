using TestWinFormsC_.Classes;

namespace TestWinFormsC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Personne personne;
            personne = new Personne("Elfassy", "Eden", 12);

            personne.Age = 1000;
            
            int AgePersonne = personne.Age;

            Personne personne_deux = new Personne("Elfassy", "David", 90);

            int NombreDePersonnesInstanciées = Personne.NombrePersonnes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
