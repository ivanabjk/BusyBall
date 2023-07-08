using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt
{
    public class Solution
    {
        public List<int> Matrix { get; set; } = new List<int>();
        public int GridSize { get; set; }
        public Button[,] GridButtons { get; set; }
        public int RandomNum { get; set; }
        public Solution(int gridSize, Button[,] gridButtons, int randomNum)
        {
            GridSize = gridSize;
            GridButtons = gridButtons;
            RandomNum = randomNum;
        }
        public List<int> InitializeMatrix()
        {
            if (RandomNum == 1)
            {
                Matrix = new List<int>{0, 0, 1, 1, 1, 0, 0, 0, 0, 0,
                0, 1, 1, 1, 1, 1, 0, 0, 0, 0,
                1, 1, 1, 1, 1, 1, 0, 0, 0, 0,
                1, 0, 0, 1, 1, 1, 0, 0, 0, 0,
                0, 0, 0, 1, 1, 1, 0, 0, 0, 0,
                0, 0, 1, 1, 1, 0, 0, 0, 0, 0,
                0, 1, 1, 1, 0, 0, 0, 0, 0, 0,
                0, 1, 1, 1, 0, 0, 1, 1, 1, 1,
                0, 1, 1, 1, 0, 1, 0, 0, 1, 1,
                0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
            }
            else if (RandomNum == 2)
            {
                Matrix = new List<int>{0, 1, 1, 0, 0, 0, 0, 1, 1, 1,
                1, 1, 1, 0, 0, 0, 0, 1, 0, 1,
                1, 1, 1, 0, 0, 0, 0, 0, 0, 1,
                0, 0, 1, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 1, 1, 1, 1, 1, 1, 0, 0,
                0, 1, 1, 1, 0, 0, 1, 1, 0, 0,
                0, 1, 0, 1, 0, 0, 1, 1, 1, 0,
                0, 0, 0, 1, 0, 0, 1, 0, 1, 0,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
                1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            }
            else
            {
                Matrix = new List<int>{0, 0, 0, 1, 0, 1, 0, 0, 0, 0,
                1, 1, 0, 1, 0, 1, 0, 1, 1, 0,
                0, 1, 1, 1, 1, 1, 1, 1, 0, 0,
                0, 0, 1, 0, 1, 1, 1, 0, 0, 0,
                0, 0, 1, 1, 1, 1, 1, 1, 0, 0,
                0, 0, 1, 1, 1, 1, 1, 1, 1, 0,
                0, 0, 1, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 1, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 1, 1, 1, 1, 1, 1, 1, 1,
                0, 0, 1, 1, 1, 1, 0, 0, 0, 0 };
            }
            return Matrix;
        }

        public string ColorButtons()
        {
            if(RandomNum == 1)
            {
                for(int i=0; i<GridSize; i++)
                {
                    for(int j=0; j<GridSize; j++)
                    {
                        GridButtons[i, j].BackgroundImage = null;
                        switch (i*10 + j)
                        {
                            case 12: case 21: case 22: case 61: case 71: case 78: case 81: case 86: case 91: GridButtons[i, j].BackColor = Color.FromArgb(253, 167, 169); break; // babypink

                            case 2: case 3: case 4: case 14: case 15: case 23: case 24: case 25:case 34:
                            case 35: case 44: case 45: case 52: case 53: case 54: case 62: case 63: case 72: case 73: case 79:
                            case 82: case 83: case 87: case 88: case 89: case 92: case 93: case 94: case 95: case 96: case 97:
                            case 98: case 99: GridButtons[i, j].BackColor = Color.FromArgb(251, 92, 110);  break;  

                            case 11: GridButtons[i, j].BackColor = Color.FromArgb(135, 25, 40); break;
                            case 20: GridButtons[i, j].BackColor = Color.FromArgb(107, 11, 20); break;
                            case 30: GridButtons[i, j].BackColor = Color.FromArgb(77, 11, 0); break; 
                            case 13: GridButtons[i, j].BackColor = Color.FromArgb(209, 105, 106); break;
                            case 33: GridButtons[i, j].BackColor = Color.FromArgb(221, 105, 106); break;
                            case 43: GridButtons[i, j].BackColor = Color.FromArgb(234, 105, 106); break;  

                            default: GridButtons[i, j].BackColor = Color.FromArgb(172, 241, 240); break;
                        }
                     
                    }
                }
                return "FLAMINGO";
            }
            if(RandomNum == 2)
            {
                for(int i=0; i<GridSize; i++)
                {
                    for(int j=0; j<GridSize; j++)
                    {
                        GridButtons[i, j].BackgroundImage = null;
                        switch (i*10 + j)
                        {
                            case 0: case 3: case 4: case 5: case 6: case 13: case 16: case 18: 
                            case 27: case 28: case 30: case 31: case 40: case 49: GridButtons[i, j].BackColor = Color.FromArgb(255, 128, 0); break; // glavna orange

                            case 14: case 15: case 23: case 24: case 25: case 26: case 41: case 48: case 50: case 58: 
                            case 59: case 60: case 69: case 70: case 79: GridButtons[i, j].BackColor = Color.FromArgb(255, 157, 0); break; // posvetla orange nekoja

                            case 54: case 55: case 62: case 64: case 65: case 71: 
                            case 72: case 74: case 75: case 77: GridButtons[i, j].BackColor = Color.FromArgb(255, 200, 0); break; // najsvetla

                            default: GridButtons[i, j].BackColor = Color.Black; break;
                        }
                     
                    }
                }
                return "MONKEY";
            }
            if(RandomNum == 3)
            {
                for(int i=0; i<GridSize; i++)
                {
                    for(int j=0; j<GridSize; j++)
                    {
                        GridButtons[i, j].BackgroundImage = null;
                        switch (i*10 + j)
                        {
                            case  3: case 5: GridButtons[i, j].BackColor = Color.FromArgb(25, 14, 4);  break;

                            case 33: case 36: GridButtons[i, j].BackColor = Color.FromArgb(76, 44, 11);  break;

                            case 67: case 69: GridButtons[i, j].BackColor = Color.FromArgb(93, 54, 14);  break; 

                            case 10: case 11: case 13: case 15:case 18: case 22: case 23: case 24: case 25:case 26:
                            case 32:case 34:case 35:case 42:case 43:case 44:case 45:case 46:case 47:case 52:case 53:
                            case 54:case 55:case 56:case 57:case 58:case 62:case 64:case 65:case 66:case 72:case 75:
                            case 76:case 82:case 86: case 92: GridButtons[i, j].BackColor = Color.FromArgb(226, 143, 57);  break;

                            case 17: case 21: case 27: GridButtons[i, j].BackColor = Color.FromArgb(234, 172, 108); break;

                            case 63: case 68: case 73: case 74:case 77: case 78: case 79: case 83: case 84:case 85:
                            case 87:case 88:case 89:case 93:case 94:case 95: GridButtons[i, j].BackColor = Color.FromArgb(162, 93, 24); break;

                            default: GridButtons[i, j].BackColor = Color.SkyBlue; break;

                        }
                     
                    }
                }
                return "GIRAFFE";
            }
            return "";
        }
    }
}
