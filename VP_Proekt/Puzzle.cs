using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using VP_Proekt.Properties;

namespace VP_Proekt
{
    public partial class Puzzle : Form
    {
        Random Random {  get; set; }
        public Point EmptyPoint = new Point();
        public ArrayList pictures = new ArrayList();
        public bool isFinished = false;

        public Puzzle()
        {
            EmptyPoint.X = 180;
            EmptyPoint.Y = 180;
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "SHUFFLE";
            foreach (Button b in panel1.Controls)
            {
                b.Enabled = true;
            }

            Image original = Properties.Resources.parrot;
            pbOriginalPicture.Image = original;

            DivideImage(original, 270, 270);
            PutImagesOnButtons(pictures);
        }

        private void DivideImage(Image original, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(original, 0, 0, width, height);
            g.Dispose();
            int moveRight = 0;
            int moveDown = 0;
            for (int i = 0; i < 8; i++)
            {
                Bitmap piece = new Bitmap(90, 90);

                for (int j = 0; j < 90; j++)
                    for (int k = 0; k < 90; k++)
                    {
                        piece.SetPixel(j, k, bmp.GetPixel(j + moveRight, k + moveDown));
                    }


                pictures.Add(piece);
                moveRight += 90;
                if (moveRight == 270)
                {
                    moveRight = 0;
                    moveDown += 90;
                }
            }
        }

        private void PutImagesOnButtons(ArrayList images)
        {
            int i = 0;
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7 };

            arr = shuffle(arr);

            foreach(Button btn in panel1.Controls)
            {
                if(i<arr.Length)
                {
                    btn.Image = (Image)images[arr[i]];
                    i++;
                }
            }
        }

        private int[] shuffle(int[] arr)
        {
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();

            return arr;
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            MoveButton((Button)sender);
        }

        private void MoveButton(Button btn)
        {
            if( ( (btn.Location.X == EmptyPoint.X-90 || btn.Location.X == EmptyPoint.X+90) && btn.Location.Y == EmptyPoint.Y)
                || (btn.Location.Y == EmptyPoint.Y-90 || btn.Location.Y == EmptyPoint.Y+90) && btn.Location.X == EmptyPoint.X)
            {
                Point swap = btn.Location;
                btn.Location = EmptyPoint;
                EmptyPoint = swap;
            }

            if(EmptyPoint.X == 180 && EmptyPoint.Y == 180)
            {
                CheckIfCorrect();
            }
        }

        private void CheckIfCorrect()
        {
            int count = 0, index;
            foreach(Button btn in panel1.Controls)
            {
                index = (btn.Location.Y/90)*3 + btn.Location.X / 90;
                if (pictures[index] == btn.Image)
                {
                    count++;
                }
            }
            
            if(count == 8)
            {
                DialogResult dg = MessageBox.Show("WELL DONE. YOU WIN!!!", "Winner",MessageBoxButtons.OK);
                if(dg == DialogResult.OK)
                {
                    this.Close();
                    isFinished = true;
                }
            }
        }
    }
}
