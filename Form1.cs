using _05102026_07102026;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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
            Cane Gatto1 = new Cane("bob", 10);
            string risultato = Gatto1.Verso();
            MessageBox.Show(risultato);

            SoundPlayer suono = new SoundPlayer("versi/a-medium-sized-dog-woofing.wav");
            suono.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pollo Gatto1 = new Pollo("bob", 10);
            string risultato = Gatto1.Verso();
            MessageBox.Show(risultato);

            SoundPlayer suono = new SoundPlayer("versi/raven-calling.wav");
            suono.Play();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Gatto Gatto1 = new Gatto("bob", 10);
            string risultato = Gatto1.Verso();
            MessageBox.Show(risultato);

            SoundPlayer suono = new SoundPlayer("versi/cat-simon-purring.wav");
            suono.Play();


        }
    }
}
