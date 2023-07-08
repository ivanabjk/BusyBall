using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace VP_Proekt
{
    public partial class Nonogram : Form
    {
        public Solution Solution { get; set; }
        public Random Random = new Random();
        public int Rand { get; set; }
        public bool GameWon { get; set; } = false;
        public const int GridSize = 10;
        public Button[,] GridButtons { get; set; }
        public List<int> Matrix { get; set; }
        public int CountCorrect { get; set; }
        public static List<Label> HorizontalLabels { get; set; } = new List<Label>();
        public static List<Label> VerticalLabels { get; set; } = new List<Label>();
        public int CountSelected { get; set; } = 0;

        public Nonogram()
        {
            InitializeComponent();
            InitializeGrid();
            Rand = Random.Next(1, 4);
            //Rand = 2;
            Solution = new Solution(GridSize, GridButtons, Rand);
            Matrix = Solution.InitializeMatrix();
            CreateLabels();
        }
        private void InitializeGrid()
        {
            GridButtons = new Button[GridSize, GridSize];
            const int buttonSize = 40; 

            for (int row = 0; row < GridSize; row++)
            {
                for (int col = 0; col < GridSize; col++)
                {
                    Button button = new Button
                    {
                        Size = new Size(buttonSize, buttonSize),
                        Location = new Point(col * buttonSize + 100, row * buttonSize + 70),
                        BackColor = Color.White,
                        Tag = 0
                    };
                    button.MouseDown += Button_MouseDown;
                    GridButtons[row, col] = button;
                    Controls.Add(button);
                }
            }
        }
       
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            Button Button = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                int tag = (int)Button.Tag;
                tag = (tag == 0 || tag == -1) ? 1 : 0;

                Button.Tag = tag;
                if (tag == 1)
                {
                    Button.BackColor = Color.Black;
                    Button.BackgroundImage = null;
                    CountSelected++;
                }
                else
                {
                    Button.BackColor = Color.White;
                    Button.BackgroundImage = null;
                    CountSelected--;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                int tag = (int)Button.Tag;

                if (tag == 1)
                {
                    CountSelected--;
                }

                tag = (tag == 0 || tag == 1) ? -1 : 0;

                Button.Tag = tag;
                if (tag == -1)
                {
                    Button.BackgroundImage = Properties.Resources.cross;
                    Button.BackgroundImageLayout = ImageLayout.Stretch;
                    Button.BackColor = Color.White;
                }
                else
                {
                    Button.BackgroundImage = null;
                    Button.BackColor = Color.White;
                }
            }
        }
        private void Nonogram_Load(object sender, EventArgs e)
        {

        }

        public void CreateLabels()
        {
            List<List<int>> Horizontal = new List<List<int>>();
            List<string> HorizontalLabelStrings = new List<string>();
            int HorizontalCounter;
            for (int j = 0; j < GridSize; j++)
            {
                List<int> tmp = new List<int>();
                HorizontalCounter = 0;
                for (int i = 0; i < GridSize; i++)
                {
                    if (Matrix != null)
                    {
                        if (Matrix[GridSize * j + i] == 1)
                        {
                            HorizontalCounter++;
                            if (i == GridSize - 1)
                            {
                                CountCorrect += HorizontalCounter;
                                tmp.Add(HorizontalCounter);
                            }
                        }
                        else
                        {
                            if (HorizontalCounter != 0)
                            {
                                CountCorrect += HorizontalCounter;
                                tmp.Add(HorizontalCounter);
                            }
                            HorizontalCounter = 0;
                        }
                    }

                }
                Horizontal.Add(tmp);
            }
            List<List<int>> Vertical = new List<List<int>>();
            List<string> VerticalLabelStrings = new List<string>();
            int VerticalCounter;
            for (int i = 0; i < GridSize; i++)
            {
                List<int> tmp2 = new List<int>();
                VerticalCounter = 0;
                for (int j = 0; j < GridSize; j++)
                {
                    if (Matrix != null)
                    {
                        if (Matrix[j * GridSize + i] == 1)
                        {
                            VerticalCounter++;
                            if (j == GridSize - 1)
                            {
                                tmp2.Add(VerticalCounter);
                            }
                        }
                        else
                        {
                            if (VerticalCounter != 0)
                            {
                                tmp2.Add(VerticalCounter);
                            }
                            VerticalCounter = 0;
                        }
                    }

                }
                Vertical.Add(tmp2);
            }
            foreach (var h in Horizontal)
            {
                string str = "";
                foreach (var e in h)
                {
                    str += e.ToString() + " ";
                }
                HorizontalLabelStrings.Add(str);
            }
            foreach (var v in Vertical)
            {
                string str = "";
                foreach (var e in v)
                {
                    str += e.ToString() + "\n";
                }
                VerticalLabelStrings.Add(str);
            }
            for (int i = 0; i < GridSize; i++)
            {
                Label NewHorizontalLabel = new Label();
                Controls.Add(NewHorizontalLabel);
                NewHorizontalLabel.AutoSize = true;
                NewHorizontalLabel.Text = HorizontalLabelStrings[i] == "" ? "0" : HorizontalLabelStrings[i];
                NewHorizontalLabel.Location = new Point(GridButtons[i, 0].Location.X - NewHorizontalLabel.Size.Width,
                                                        GridButtons[i, 0].Location.Y + GridButtons[i, 0].Size.Height / 2 - NewHorizontalLabel.Size.Height / 2);

                HorizontalLabels.Add(NewHorizontalLabel);

            }
            for (int i = 0; i < GridSize; i++)
            {
                Label NewVerticalLabel = new Label();
                Controls.Add(NewVerticalLabel);
                NewVerticalLabel.AutoSize = true;
                NewVerticalLabel.Text = VerticalLabelStrings[i] == "" ? "0" : VerticalLabelStrings[i];
                NewVerticalLabel.Location = new Point(GridButtons[0, i].Location.X + GridButtons[0, i].Size.Width / 2 - NewVerticalLabel.Size.Width / 2,
                                                      GridButtons[0, i].Location.Y - NewVerticalLabel.Size.Height);

                VerticalLabels.Add(NewVerticalLabel);
            }
        }

        public void CheckIfCorrect()
        {
            //lblAnswer.Text = Solution.ColorButtons();
            //label1.Text = $"{CountSelected}/{CountCorrect}";
            if (CountSelected == CountCorrect)
            {
                bool CorrectAnswer = true;
                for (int row = 0; row < GridSize; row++)
                {
                    for (int col = 0; col < GridSize; col++)
                    {
                        if ((int)GridButtons[row, col].Tag != -1)
                        {
                            if ((int)GridButtons[row, col].Tag != Matrix[row * GridSize + col])
                            {
                                CorrectAnswer = false;
                                break;
                            }
                        }
                        else
                        {
                            if ((int)GridButtons[row, col].Tag + 1 != Matrix[row * GridSize + col])
                            {
                                CorrectAnswer = false;
                                break;
                            }
                        }

                    }
                }
                if (CorrectAnswer)
                {
                    lblText.Text = $"BRAVO!";
                    GameWon = true;
                    lblAnswer.Text = Solution.ColorButtons();
                    foreach (var b in GridButtons)
                    {
                        b.Enabled = false;
                    }
                    DialogResult dg = MessageBox.Show("WELL DONE!!!", "Bravo", MessageBoxButtons.OK);
                    if (dg == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    lblText.Text = $"TRY AGAIN!";
                }
            }
            else if (CountSelected < CountCorrect)
            {
                lblText.Text = $"SELECT MORE TILES!";
            }
            else
            {
                lblText.Text = $"TOO MANY TILES SELECTED!";
            }

        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            CheckIfCorrect();
        }
    }
}
