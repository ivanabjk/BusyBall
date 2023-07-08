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
    public partial class Form1 : Form
    {
        public bool IsGuideClicked { get; set; }
        public MainForm Main { get; set; } = new MainForm();

        public Form1()
        {
            this.BackgroundImage = Properties.Resources.bgBlurry;
            InitializeComponent();
            lblGameExplanation.Text = GameExplanationText();
        }
        private string GameExplanationText()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" \n");
            sb.Append("     Hello! I'm Paul, the busy ball.\n");
            sb.Append("     Everyday I live my life as the main character in a video game.      \n");
            sb.Append("     In order to start my adventure, I must defeat the loud beast    \n");
            sb.Append("     also known as The Alarm.\n");
            sb.Append("     My to do list is always full with the same few tasks,\n");
            sb.Append("     which I see as mini games.\n");
            sb.Append("     Please help me complete as many as possible.\n");
            sb.Append(" ");
            return sb.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            MainForm Main = new MainForm();
            this.Hide();
            Main.ShowDialog();
            this.Close();
            
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            IsGuideClicked = !IsGuideClicked;
            if (IsGuideClicked)
            {
                btnGuide.BackColor = Color.PaleGoldenrod;
                btnGuide.ForeColor = Color.Black;
                lblGuide.Text = Main.SetGuideText();
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
