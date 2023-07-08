using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt
{
    public partial class MainForm : Form
    {
        public int TwoSeconds { get; set; } = 0;
        public bool IncrementSize { get; set; }  = true;
        public bool IsStarted { get; set; } = false;
        public Point OriginalLoc { get; set; }
        public bool IsGuideClicked { get; set; } = false;

        //public bool IsGameFinished { get; set; } = false;
        public bool Game1Finished { get; set; } = false;
        public bool Game2Finished { get; set; } = false;
        public bool Game3Finished { get; set; } = false;
        public bool Game4Finished { get; set; } = false;
        public int MathScore { get; set; } = 0;

        public MainForm()
        {
            this.BackgroundImage = Properties.Resources.bgPic;
            InitializeComponent();
            DoubleBuffered = true;
            OriginalLoc = pbAlarmClock.Location;
            timerStart.Start();

            btnGame1.Visible = false;
            btnGame2.Visible = false;
            btnGame3.Visible = false;
            btnGame4.Visible = false;

            lblEnd.Visible = false;

        }
        private void Pulse()
        {
            if (IncrementSize)
            {
                pbAlarmClock.Location = new Point(285,305);
                IncrementSize = !IncrementSize;
            }
            else
            {
                pbAlarmClock.Location = new Point(285, 316);
                IncrementSize = !IncrementSize;
            }
        }
        private void timerStart_Tick(object sender, EventArgs e)
        {
            TwoSeconds++;
            if(TwoSeconds == 2)
            {
                timerStart.Stop();
                timerAlarm.Start();
                pbAlarmClock.Enabled = true;
            }
        }
        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            Pulse();
        }
        private void pbAlarmClock_Click(object sender, EventArgs e)
        {
            timerAlarm.Stop();
            lblTurnAlarmOff.Visible = false;
            pbAlarmClock.Location = OriginalLoc;

            MathOperations math = new MathOperations();
            math.ShowDialog();
            if(math.IsClosed)
            {
                MathScore = math.Score;
                if (MathScore == 0)
                {
                    timerAlarm.Start();
                }
                else 
                {
                    pbBall.Size = new Size(75, 75);
                    pbBall.Image = Properties.Resources.SmileyBall;
                    
                    pbZZZ.Visible = false;

                    if(MathScore == 1)
                    {
                        btnGame1.Enabled = true;
                    }
                    else if (MathScore == 2)
                    {
                        btnGame1.Enabled = true;
                        btnGame2.Enabled = true;
                    }
                    else
                    {
                        btnGame1.Enabled = true;
                        btnGame2.Enabled = true;
                        btnGame3.Enabled = true;
                    }
                    timerAlarm.Stop();
                    pbAlarmClock.Location = OriginalLoc;
                    MakeVisible();
                    pbAlarmClock.Enabled = false;
                }
            }
            else
            {
                timerAlarm.Start();
                lblTurnAlarmOff.Visible = true;
            }
        }
        public void MakeVisible()
        {
            btnGame1.Visible = true;
            btnGame2.Visible = true;
            btnGame3.Visible = true;
            btnGame4.Visible = true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnGame1_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz();
            quiz.ShowDialog();

            if(quiz.IsClosed && quiz.Score >= 0.7*quiz.MaxQuestions)
            {
                //Game1Finished = true;
                btnGame1.Font = new Font(btnGame1.Font.FontFamily, 15, FontStyle.Strikeout);
                btnGame4.Enabled = true;
            }
           
        }
        private void btnGame2_Click(object sender, EventArgs e)
        {
            Nonogram nonogram = new Nonogram();
            nonogram.ShowDialog();

            if (nonogram.GameWon)
            {
                Game2Finished = true;
                btnGame2.Font = new Font(btnGame2.Font.FontFamily, 15, FontStyle.Strikeout);
            }
            if (GameFinished())
            {
                lblEnd.Visible = true;
                lblText.Visible = true;
            }
        }
        private void btnGame3_Click(object sender, EventArgs e)
        {
            Puzzle puzzle = new Puzzle();
            puzzle.ShowDialog();

            if(puzzle.isFinished)
            {
                Game3Finished = true;
                btnGame3.Font = new Font(btnGame3.Font.FontFamily, 15, FontStyle.Strikeout);
            }
            if (GameFinished())
            {
                lblEnd.Visible = true;
                lblText.Visible = true;
            }
        } 
        private void btnGame4_Click(object sender, EventArgs e)
        {
            CarRacing carRacing = new CarRacing();
            carRacing.ShowDialog();

            if(carRacing.GameWon)
            {
                Game4Finished = true;
                btnGame4.Font = new Font(btnGame4.Font.FontFamily, 15,FontStyle.Strikeout);
            }
            if (GameFinished())
            {
                lblEnd.Visible = true;
                lblText.Visible = true;
            }
        }
        public bool IsGame2Over()
        {
            if (btnGame2.Enabled == true)
            {
                if (Game2Finished == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsGame3Over()
        {
            if (btnGame3.Enabled == true)
            {
                if (Game3Finished == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsGame4Over()
        {
            if (btnGame4.Enabled == true)
            {
                if (Game4Finished == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool GameFinished()
        {
            if (MathScore == 1)
            {
                if(IsGame4Over())
                {
                    return true;
                }
                
            }
            else if (MathScore == 2)
            {
                if (IsGame4Over() && IsGame2Over())
                {
                    return true;
                }
            }
            else
            {
                if (IsGame4Over() && IsGame2Over() && IsGame3Over())
                {
                    return true;
                }
            }
            return false;
        }
        public string SetGuideText()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n");
            sb.Append("     When you start the game, the alarm will start to ring.You need to click it.\n");
            sb.Append("     In order to turn it off, you need to solve some math problems. There are 3 in total.\n");
            sb.Append("     You need to solve at least one to continue the game. With each math problem you unlock a task.      \n");
            sb.Append("     The forth task can be unlocked if you score at least 70% on the first task.\n\n");

            sb.Append("     Quiz:\n");
            sb.Append("     The first task is a quiz. You are given 10 random questions which you need to answer,\n");
            sb.Append("     by selecting one of the radio buttons. After scoring 70% the task is considered finished.\n");
            
            sb.Append("     Nonogram:\n");
            sb.Append("     The second game Nonogram. You have a 10x10 grid layout with buttons.\n");
            sb.Append("     You can select the buttons or put a cross over them if you think they shouldn't be selected.\n");
            sb.Append("     There are numbers around the grid that tell you how many buttons should be selected\n");
            sb.Append("     in a row or column.\n");
            sb.Append("     For example: If you have the numbers 2 3 1, you need to select 2 buttons,\n ");
            sb.Append("     then 3 and 1 more in the row/column.\n");

            sb.Append("     Puzzle:\n");
            sb.Append("     You have shuffled pieces of a picture that you must put in the correct order.\n");

            sb.Append("     Car Racing Game:\n");
            sb.Append("     A simple car racing game where you need to win an award to cmplete the task.\n");
            sb.Append("     If you win over 200 points you get a bronse trophey.\n");
            sb.Append("     Over 700 points you get a silver trophey and over 1000 points a gold trophey.\n\n");
            
            sb.Append("     After you finish a task you can play it as many times as you'd like.\n");
            sb.Append("     If you are not satisfied with the number of unlocked tasks, you can restart the game.\n");
            sb.Append("     ");
            return sb.ToString();

        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            IsGuideClicked = !IsGuideClicked;
            if (IsGuideClicked)
            {
                btnGuide.BackColor = Color.PaleGoldenrod;
                btnGuide.ForeColor = Color.Black;
                lblGuide.Text = SetGuideText();
                lblGuide.Visible = true;
            }
            else
            {
                btnGuide.BackColor = Color.DarkRed;
                btnGuide.ForeColor = Color.White;
                lblGuide.Visible = false;
            }
        }
    }
}
