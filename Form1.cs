using _05102026_07102026;
using System.Media;

namespace _05102026_071020206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MostraAnimale(TipoAnimale.Cane, "versi/a-medium-sized-dog-woofing.wav");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MostraAnimale(TipoAnimale.Pollo, "versi/raven-calling.wav");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MostraAnimale(TipoAnimale.Gatto, "versi/cat-simon-purring.wav");
        }

        private static void MostraAnimale(TipoAnimale tipo, string percorsoSuono)
        {
            Animale animale = AnimaleFactory.Crea(tipo, "bob", 10);
            FileLogger.Instance.Log($"Creato {animale.GetType().Name}: {animale.Nome}, eta={animale.Age}.");
            MessageBox.Show(animale.Verso());

            SoundPlayer suono = new SoundPlayer(percorsoSuono);
            suono.Play();
        }
    }
}
