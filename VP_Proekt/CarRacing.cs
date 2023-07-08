using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt
{
    public partial class CarRacing : Form
    {
        Random random = new Random();
        Random CarPosition = new Random();

        public int SpeedOfRoad { get; set; } = 15; //roadspeed
        public int SpeedOfTraffic { get; set; } = 15; //trafficSpeed
        public int SpeedOfPlayer { get; set; } = 12; //playerSpeed
        public int Score { get; set; } = 0; //score
        public int CarPicture { get; set; } //carImage
        public bool MoveLeft { get; set; } //goleft
        public bool MoveRight { get; set; } // goright
        public bool IsRed { get; set; }
        public bool GameWon { get; set; } = false;
        public CarRacing()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            lblChoose.Visible = false;

            pbRedChoice.Visible = false;
            pbBlueChoice.Visible = false;

            pbPlayerCar.Visible = true;
            pbCar1.Visible = true;
            pbCar2.Visible = true;

            btnSwitchCar.Visible = true;
            btnSwitchCar.Enabled = false;
            RestartGame();
        }
        private void ChosenCar()
        {
            if (IsRed)
            {
                pbPlayerCar.Image = Properties.Resources.carRed;
                pbCar1.Image = Properties.Resources.carBlue;
                pbCar2.Image = Properties.Resources.carBlue;
            }
            else
            {
                pbPlayerCar.Image = Properties.Resources.carBlue;
                pbCar1.Image = Properties.Resources.carRed;
                pbCar2.Image = Properties.Resources.carRed;
            }
        }
        private void RestartGame()
        {
            ChosenCar();

            lblChoose.Visible = false;
            btnStart.Enabled = false;
            pbExplosion.Visible = false;
            pbAward.Visible = false;
            MoveLeft = false;
            MoveRight = false;
            Score = 0;

            pbAward.Image = Properties.Resources.ThirdPlace;
            SpeedOfRoad = 12;
            SpeedOfTraffic = 15;

            pbCar1.Top = CarPosition.Next(200, 500) * -1;
            pbCar1.Left = CarPosition.Next(5, 200);
            pbCar2.Top = CarPosition.Next(200, 500) * -1;
            pbCar2.Left = CarPosition.Next(245, 422); 

            timer1.Enabled = true;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblScore.Text = $"Score : {Score}";
            Score++;

            if (MoveLeft == true && pbPlayerCar.Left > 10)
            {
                pbPlayerCar.Left -= SpeedOfPlayer;
            }
            if (MoveRight == true && pbPlayerCar.Left < 415)
            {
                pbPlayerCar.Left += SpeedOfPlayer;
            }

            pbRoad1.Top += SpeedOfRoad;
            pbRoad2.Top += SpeedOfRoad;

            if (pbRoad1.Top > 440)
            {
                pbRoad1.Top = -440;
            }
            if (pbRoad2.Top > 440)
            {
                pbRoad2.Top = -440;
            }

            pbCar1.Top += SpeedOfTraffic;
            pbCar2.Top += SpeedOfTraffic;

            if (pbCar1.Top > 530)
            {
                ChangeCar(pbCar1);
            }
            if (pbCar2.Top > 530)
            {
                ChangeCar(pbCar2);
            }

            if (pbPlayerCar.Bounds.IntersectsWith(pbCar1.Bounds) || pbPlayerCar.Bounds.IntersectsWith(pbCar2.Bounds))
            {
                GameOver();
            }
            if(Score <= 200)
            {
                lblChoose.Text = "YOU FAILED!";
            }
            if (Score > 200  && Score < 700)
            {
                pbAward.Image = Properties.Resources.ThirdPlace;
            }
            if (Score > 700 && Score < 1500)
            {
                pbAward.Image = Properties.Resources.SecondPlace;
                SpeedOfRoad = 20;
                SpeedOfTraffic = 22;
            }
            if (Score > 1500)
            {
                pbAward.Image = Properties.Resources.FirstPlace;
                SpeedOfRoad = 27;
                SpeedOfTraffic = 25;
            }
        }
        public void GameOver()
        {
            timer1.Stop();
            pbExplosion.Visible = true;
            pbPlayerCar.Controls.Add(pbExplosion);
            pbExplosion.Location = new Point(-8, 5);
            pbExplosion.BackColor = Color.Transparent;
            if (Score <= 200)
            {
                lblChoose.Visible = true;
            }
            else
            {
                GameWon = true;
                pbAward.Visible = true;
            }
           // pbAward.BackColor = Color.Transparent;
            pbAward.BringToFront();
            btnStart.Text = "RESTART";
            btnStart.Font = new Font(btnStart.Font.FontFamily, 15);
            btnStart.Enabled = true;
            btnSwitchCar.Enabled = true;
        }
        private void ChangeCar(PictureBox carTmp)
        {
            if (IsRed)
            {
                carTmp.Image = Properties.Resources.carBlue;
            }
            else
            {
                carTmp.Image = Properties.Resources.carRed;
            }

            carTmp.Top = CarPosition.Next(100, 400) * -1;

            if ((string)carTmp.Tag == "carLeft")
            {
                carTmp.Left = CarPosition.Next(5, 200);
            }
            if ((string)carTmp.Tag == "carRight")
            {
                carTmp.Left = CarPosition.Next(245, 422);
            }
        }
        private void CarRacing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = true;
            }
        }
        private void CarRacing_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight = false;
            }
        }
        private void pbRedChoice_Click(object sender, EventArgs e)
        {
            pbRedChoice.BorderStyle = BorderStyle.Fixed3D;
            IsRed = true;
            pbBlueChoice.BorderStyle = BorderStyle.None;
            btnStart.Enabled = true;
        }
        private void pbBlueChoice_Click(object sender, EventArgs e)
        {
            pbBlueChoice.BorderStyle = BorderStyle.Fixed3D;
            IsRed = false;
            pbRedChoice.BorderStyle = BorderStyle.None;
            btnStart.Enabled = true;
        }
        private void btnSwitchCar_Click(object sender, EventArgs e)
        {
            IsRed = !IsRed;
            ChosenCar();
        }
    }
}
