using TestWinFormsCSharp.Classes;

namespace TestWinFormsCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Personne P1 = new Personne("Elfassy", "Eden", 12);

            P1.Age = 1000;

            int AgePersonne = P1.Age;

            Personne P2 = new Personne("Elfassy", "David", 90);

            int NombreDePersonnesInstanciées = Personne.NombrePersonnes;

            if (P1 == P2)
                Console.WriteLine("P1 et P2 sont la même personne");
            else
                Console.WriteLine("P1 et P2 sont deux personnes différentes");
        }
    }
}
