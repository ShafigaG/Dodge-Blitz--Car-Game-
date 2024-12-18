using WMPLib;

namespace pixieCar
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer player;
        private bool musicIsPlaying;
        public Form1()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.URL = @"sound\music.mp3";


            player.controls.play();
            musicIsPlaying = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (musicIsPlaying)
            {
                player.controls.pause();
                btnMusicOnOff.BackgroundImage = Image.FromStream(new MemoryStream(Properties.Resources.volume_mute)); // Convert to Image
                musicIsPlaying = false;
            }
            else
            {
                player.controls.play();
                btnMusicOnOff.BackgroundImage = Image.FromStream(new MemoryStream(Properties.Resources.volume)); // Convert to Image
                musicIsPlaying = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            var frm2 = new Form2()
            {
                ShowInTaskbar = false,

                FormBorderStyle = FormBorderStyle.None,
            };
            frm2.StartPosition = FormStartPosition.CenterParent;


            frm2.ShowDialog();

            this.Close();


        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var frm5 = new Form5()
            {
                ShowInTaskbar = false,

                FormBorderStyle = FormBorderStyle.None,
            };
            frm5.StartPosition = FormStartPosition.CenterParent;

            frm5.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var frm3 = new Form3()
            {
                ShowInTaskbar = false,

                FormBorderStyle = FormBorderStyle.None,
            };
            frm3.StartPosition = FormStartPosition.CenterParent;
            frm3.ShowDialog(this);
        }

    }
}