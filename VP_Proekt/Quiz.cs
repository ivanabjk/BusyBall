using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VP_Proekt
{
    public partial class Quiz : Form
    {
        public IDictionary<string, string[]> Questions = new Dictionary<string, string[]>();
        public Random Random { get; set; }
        public int CountQuestions { get; set; } = 0;
        public string CorrectAnswer { get; set; }
        public int Score { get; set; }
        public int MaxQuestions { get; set; } = 10;
        public bool IsClosed { get; set; } = false;
        public Quiz()
        {
            InitializeComponent();
            lblExplanation.Text = GameExplanationText();
            QuizQuestions();
            Random = new Random();
        }
        private string GameExplanationText()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"You have {MaxQuestions} questions.\n");// With each task written on the wall, everyday I have to clean the     ");
            sb.Append("Answer as many as you can correctly.\n");
            sb.Append("If you answer more than 70%, you can relax by gaming.\n");
            sb.Append("Good luck!\n");
            //sb.Append("When the alarm goes off, I can't hear it. That's where I need your help\n");
            //sb.Append("In order to wake me up, you will need to successfully solve some math problems.\n");
            return sb.ToString();
        }

        private void QuizQuestions()
        {
            Questions.Add("Which color is the complementary color of yellow?", new string[] { "Blue", "Red", "Purple", "Green", "Purple" });
            Questions.Add("What is the capital of Canada?", new string[] { "Toronto", "Ottawa", "Montrael", "Quebec", "Ottawa" });
            Questions.Add("What do bees make honey from?", new string[] { "Pollen", "Stem", "Leaf", "Petals", "Pollen" });
            Questions.Add("What planet is closest to the Sun?", new string[] { "Earth", "Jupiter", "Venus", "Mercury", "Mercury" });
            
            Questions.Add("Lead is a chemical element with what symbol?", new string[] { "Fe", "Le", "Pb", "Ld", "Pb" });
            Questions.Add("What is the capital of North Macedonia?", new string[] { "Vardar", "Skopje", "Kumanovo", "Ohrid", "Skopje" });
            Questions.Add("What is the name of our galaxy?", new string[] { "Milky Way", "Universe", "Galactica", "The Sun", "Milky Way" });
            Questions.Add("What is the forth letter of the Greek aplhabet?", new string[] { "Omega", "Aplha", "Beta", "Delta", "Delta" });
            
            Questions.Add("Which country has the highest population in 2023?", new string[] { "USA", "China", "India", "Russia", "India" });
            Questions.Add("What Netflix show had the most streaming views in 2021?", new string[] { "Stranger Things", "Squid Game", "You", "The Witcher", "Squid Game" });
            Questions.Add("Which of the following is a string instrument?", new string[] { "Violin", "Flute", "Drums", "Saxophone", "Violin" });
            Questions.Add("Which Greek God rules as king of the Gods on Mount Olympus?", new string[] { "Athena", "Poseidon", "Hades", "Zeus", "Zeus" });

            Questions.Add("Steve Jobs is the founder of:", new string[] { "Microsoft", "Apple", "Unix", "Linux", "Apple" });
            Questions.Add("Vegetarians don't eat:", new string[] { "Fruit", "Meat", "Eggs", "Bread", "Meat" });
            Questions.Add("Which of the following stones is purple?", new string[] { "Amethyst", "Ruby", "Diamond", "Quartz", "Amethyst" });
            Questions.Add("Which book is the most translated book in the world?", new string[] { "Harry Potter", "The Little Prince", "Book Of Mormon", "The Bible", "The Bible" });

            Questions.Add("Which language is the most spoken around the world?", new string[] { "Spanish", "French", "English", "German", "English" });
            Questions.Add("Which country won the FIFA World Cup in 2022?", new string[] { "France", "Argentina", "Morocco", "Croatia", "Argentina" });
            Questions.Add("Novak Djokovic is the famous tennis player from which country?", new string[] { "Serbia", "Croatia", "Slovenia", "Russia", "Serbia" });
            Questions.Add("When did the World War II end?", new string[] { "1939", "1914", "1944", "1945", "1945" });

            Questions.Add("Who was the first person to walk on the Moon", new string[] { "Yuri Gagarin", "Scott Kelly", "Neil Armstrong", "Valentina Tereshkova", "Neil Armstrong" });
            Questions.Add("Which is the oldest civilization in the world", new string[] { "Egyptian", "Mesopotamia","Chinese", "Indus Valley", "Mesopotamia" });



        }         
        private void Quiz_Load(object sender, EventArgs e)
        {

        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnNext.Visible = true;
            lblExplanation.Visible = false;
            lblNumOfQuestion.Visible = true;
            lblCorrectAnswers.Visible = true;
            pbCorrectAnswers.Visible = true;
            tbQuestion.Visible = true;
            rbAnswer1.Visible = true;
            rbAnswer2.Visible = true;
            rbAnswer3.Visible = true;
            rbAnswer4.Visible = true;
            
            ShowQuestions();
        }
        public void ShowQuestions()
        {
            CountQuestions++;
            
            if (CountQuestions <= MaxQuestions)
            {
                lblNumOfQuestion.Text =$"{CountQuestions}/{MaxQuestions}";
                var randomQuestion = Questions.ElementAt(Random.Next(0, Questions.Count));
                
                tbQuestion.Text = randomQuestion.Key;
                rbAnswer1.Text = randomQuestion.Value[0];
                rbAnswer2.Text = randomQuestion.Value[1];
                rbAnswer3.Text = randomQuestion.Value[2];
                rbAnswer4.Text = randomQuestion.Value[3];

                CorrectAnswer = randomQuestion.Value[4];
            }
            else
            {
                DialogResult dg = MessageBox.Show($"Congratulations. You scored: {Score}", "", MessageBoxButtons.OK);
                if (dg == DialogResult.OK)
                {
                    this.Close();
                    IsClosed = true;
                }

            }
        }
        public bool IsRadioChecked()
        {
            if (rbAnswer1.Checked || rbAnswer2.Checked || rbAnswer3.Checked || rbAnswer4.Checked)
                return true;
            else return false;
        }
        public string RadioButtonSelected()
        {
            if (rbAnswer1.Checked)
            {
                rbAnswer1.Checked = false;
                return rbAnswer1.Text;
            }
            else if (rbAnswer2.Checked)
            {
                rbAnswer2.Checked = false;
                return rbAnswer2.Text;
            }
            else if (rbAnswer3.Checked)
            {
                rbAnswer3.Checked = false;
                return rbAnswer3.Text;
            }
            else
            {
                rbAnswer4.Checked = false;
                return rbAnswer4.Text;
            }
            
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (IsRadioChecked() && RadioButtonSelected() == CorrectAnswer)
            {
                Score++;
            }
            if (Score == 7)
            {
                pbCorrectAnswers.ForeColor = Color.Green;
            }

            pbCorrectAnswers.Value = (int)(100.0 * Score / MaxQuestions);            

            Questions.Remove(tbQuestion.Text);
            ShowQuestions();
        }
    }
}
