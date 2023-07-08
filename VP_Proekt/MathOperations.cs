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
    public partial class MathOperations : Form
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public char Operation { get; set; }
        public Random Random { get; set; }
        public int Score { get; set; } = 0;
        public int CountOperation { get; set; } = 0;
        public int CorrectAsnwer { get; set; }
        public int TimerValue { get; set; } = 40;
        public bool IsClosed { get; set; } = false;
        public bool IsGameStarted { get; set; } = true;
        public MathOperations()
        {
            InitializeComponent();
            lblText.Text = "You have 2 minutes for 3 operations.\n" + "Be quick!";
            Random = new Random();

            lblNumOfOperations.Visible = false;
            tbOperation.Text = "";
        }
        private char GetOperation(int number)
        {
            if(number == 1)
            {
                CorrectAsnwer = X + Y;
                return '+';
            }
            CorrectAsnwer = X * Y;
            return '*';
        }
        private void MathOperations_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.BackColor = Color.BurlyWood;
            timer1.Start();
            btnOK.Enabled = true;
            tbAnswer.Enabled = true;
            btnPlay.Enabled = false;
            ShowOperation();
            lblNumOfOperations.Visible = true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (int.Parse(tbAnswer.Text) == CorrectAsnwer)
            {
                Score++;    
            }

            tbAnswer.Clear();
            ShowOperation();
        }
        public void ShowOperation()
        {
            CountOperation++;
            if (CountOperation <= 3)
            {
                lblNumOfOperations.Text = $"{CountOperation}/3";

                X = Random.Next(10, 100);
                Y = Random.Next(3, 10);
                Operation = GetOperation(Random.Next(1, 3));

                tbOperation.Text = String.Format("{0} {1} {2} = ?", X, Operation, Y);
                if (IsGameStarted)
                {
                    TimerValue = 39;
                    IsGameStarted = false;
                }
                else
                {
                    TimerValue = 40;
                }
            }
            else
            {
                timer1.Stop(); 
                DialogResult dg = MessageBox.Show($"The game is over. You scored: {Score}", "", MessageBoxButtons.OK);
                if(dg == DialogResult.OK)
                {
                    this.Close();
                    IsClosed = true;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {  
            if (TimerValue == 0)
            {
                ShowOperation();
            }
      
            lblTimer.Text = $"{TimerValue / 60:00}:{TimerValue % 60:00}";
            TimerValue--;
        }
        private void tbAnswer_Validating(object sender, CancelEventArgs e)
        {
            if(tbAnswer.Text !="")
            {
                bool Digit = true;
                foreach(Char c in tbAnswer.Text)
                {
                    if (!Char.IsDigit(c))
                    {
                        Digit = false;
                        break;
                    }
                }
                if (Digit)
                {
                    errorProvider1.SetError(tbAnswer, null);
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(tbAnswer, "Must be a number");
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(tbAnswer, "Write an answer!");
                e.Cancel = true;
            }
        }
    }
}
