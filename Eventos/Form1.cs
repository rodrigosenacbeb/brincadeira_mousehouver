using System;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void TocarAudio()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("errou_fastao.wav");
            player.Play();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            TocarAudio();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            TocarAudio();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = true;
            TocarAudio();
        }     

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            TocarAudio();
        }
    }
}
