using System.Media;


namespace pixieCar
{
    public partial class Form2 : Form
    {
        static public List<(int score, string date)> gameHistory = new List<(int, string)>();

        static public string formattedDate = "";
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 12;
        static public int score;
        int carImage;

        Random rand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public Form2()
        {
            InitializeComponent();

            resetGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm4 = new Form4()
            {
                ShowInTaskbar = false,

                FormBorderStyle = FormBorderStyle.None,
            };
            frm4.StartPosition = FormStartPosition.CenterParent;
            frm4.ShowDialog(this);
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            labelScore.Text = " " + score;
            score++;
            if (goleft == true && player.Left > 3)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 491)
            {
                player.Left += playerSpeed;
            }

            roadTrack.Top += roadSpeed;
            roadTrack2.Top += roadSpeed;

            if (roadTrack2.Top > 876)
            {
                roadTrack2.Top = -876;
            }
            if (roadTrack.Top > 876)
            {
                roadTrack.Top = -876;
            }

            ai1.Top += trafficSpeed;
            ai2.Top += trafficSpeed;

            if(ai1.Top > 876)
            {
                changeAIcars(ai1);
            }
            if(ai2.Top > 876)
            {
                changeAIcars(ai2);
            }

            if(player.Bounds.IntersectsWith(ai1.Bounds) || player.Bounds.IntersectsWith(ai2.Bounds)) {
                playSound();
                gameover();
            }

            if(score >500 && score < 1500)
            {
                roadSpeed = 20;
                trafficSpeed = 22;
            }
            if(score > 1500)
            {
                roadSpeed = 25;
                trafficSpeed = 27;
            }
        }

        private void changeAIcars(PictureBox tempCar)
        {
            carImage = rand.Next(1, 9);

            switch(carImage)
            {
                case 1:
                    tempCar.Image = Properties.Resources.carPink; 
                    break;
                case 2:
                    tempCar.Image = Properties.Resources.ambulance;
                    break;
                case 3:
                    tempCar.Image = Properties.Resources.carGreen;
                    break;
                case 4:
                    tempCar.Image = Properties.Resources.carGrey;
                    break;
                case 5:
                    tempCar.Image = Properties.Resources.carOrange;
                    break;
                case 6:
                    tempCar.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempCar.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempCar.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempCar.Image = Properties.Resources.TruckWhite;
                    break;
            }

            tempCar.Top = carPosition.Next(100, 500) * -1;

            if((string)tempCar.Tag == "carLeft")
            {
                tempCar.Left = carPosition.Next(3, 213);
            }
            if ((string)tempCar.Tag == "carRight")
            {
                tempCar.Left = carPosition.Next(299, 491);
            }
        }
        private void resetGame()
        {
            
            explosion.Visible = false;
            goleft = false;
            goright = false;
            score = 0;

            roadSpeed = 12;
            trafficSpeed = 15;

            ai1.Top = carPosition.Next(200, 500) * -1;
            ai1.Left = carPosition.Next(3, 213);

            ai2.Top = carPosition.Next(200, 500) * -1;
            ai2.Left = carPosition.Next(299, 491);

            gameTimer.Start();
        }

        private void gameover()
        {
            
            gameTimer.Stop();   
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(2, 4);
            explosion.BackColor = Color.Transparent;

            DateTime currentDate = DateTime.Now;

            
            formattedDate = currentDate.ToString("yyyy-MM-dd HH:mm:ss");
            gameHistory.Add((score, formattedDate));



            var frm4 = new Form4()
            {
                ShowInTaskbar = false,

                FormBorderStyle = FormBorderStyle.None,
            };
            frm4.StartPosition = FormStartPosition.CenterParent;
            frm4.ShowDialog(this);
           
            var frm5 = new Form5()
            {
                ShowInTaskbar = false,

                FormBorderStyle = FormBorderStyle.None,
                
            };

            this.Close();
            

        }

        private void playSound()
        {
            SoundPlayer playerHit = new SoundPlayer(Properties.Resources.hit);
            playerHit.Play();
        }
        private void roadTrack2_Click(object sender, EventArgs e)
        {

        }

        private void roadTrack_Click(object sender, EventArgs e)
        {

        }
        
    }
}
