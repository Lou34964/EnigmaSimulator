using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaSimulator
{
    public partial class SwitchBoardForm : Form
    {
        public SwitchBoardForm()
        {
            InitializeComponent();
        }

        private void SwitchBoardForm_Load(object sender, EventArgs e)
        {
            //taco
        }

        private void SwitchBoardSelect(object sender, EventArgs e)
        {
            (sender as Label).Visible = false;
            if (tb1.Text == "")
            {
                tb1.Text = (sender as Label).Text;
                (sender as Label).Visible = false;
            }
            else
            {
                tb2.Text = (sender as Label).Text;
                string s = tb1.Text;
                switch (s)
                {
                    case "A":
                        SwitchBoard.A = char.Parse(tb2.Text);
                        break;
                    case "B":
                        SwitchBoard.B = char.Parse(tb2.Text);
                        break;
                    case "C":
                        SwitchBoard.C = char.Parse(tb2.Text);
                        break;
                    case "D":
                        SwitchBoard.D = char.Parse(tb2.Text);
                        break;
                    case "E":
                        SwitchBoard.E = char.Parse(tb2.Text);
                        break;
                    case "F":
                        SwitchBoard.F = char.Parse(tb2.Text);
                        break;
                    case "G":
                        SwitchBoard.G = char.Parse(tb2.Text);
                        break;
                    case "H":
                        SwitchBoard.H = char.Parse(tb2.Text);
                        break;
                    case "I":
                        SwitchBoard.I = char.Parse(tb2.Text);
                        break;
                    case "J":
                        SwitchBoard.J = char.Parse(tb2.Text);
                        break;
                    case "K":
                        SwitchBoard.K = char.Parse(tb2.Text);
                        break;
                    case "L":
                        SwitchBoard.L = char.Parse(tb2.Text);
                        break;
                    case "M":
                        SwitchBoard.M = char.Parse(tb2.Text);
                        break;
                    case "N":
                        SwitchBoard.N = char.Parse(tb2.Text);
                        break;
                    case "O":
                        SwitchBoard.O = char.Parse(tb2.Text);
                        break;
                    case "P":
                        SwitchBoard.P = char.Parse(tb2.Text);
                        break;
                    case "Q":
                        SwitchBoard.Q = char.Parse(tb2.Text);
                        break;
                    case "R":
                        SwitchBoard.R = char.Parse(tb2.Text);
                        break;
                    case "S":
                        SwitchBoard.S = char.Parse(tb2.Text);
                        break;
                    case "T":
                        SwitchBoard.T = char.Parse(tb2.Text);
                        break;
                    case "U":
                        SwitchBoard.U = char.Parse(tb2.Text);
                        break;
                    case "V":
                        SwitchBoard.V = char.Parse(tb2.Text);
                        break;
                    case "W":
                        SwitchBoard.W = char.Parse(tb2.Text);
                        break;
                    case "X":
                        SwitchBoard.X = char.Parse(tb2.Text);
                        break;
                    case "Y":
                        SwitchBoard.Y = char.Parse(tb2.Text);
                        break;
                    case "Z":
                        SwitchBoard.Z = char.Parse(tb2.Text);
                        break;
                    default:
                        tb1.Text = tb1.Text;
                        break;
                }
                s = tb2.Text;
                switch (s)
                {
                    case "A":
                        SwitchBoard.A = char.Parse(tb1.Text);
                        break;
                    case "B":
                        SwitchBoard.B = char.Parse(tb1.Text);
                        break;
                    case "C":
                        SwitchBoard.C = char.Parse(tb1.Text);
                        break;
                    case "D":
                        SwitchBoard.D = char.Parse(tb1.Text);
                        break;
                    case "E":
                        SwitchBoard.E = char.Parse(tb1.Text);
                        break;
                    case "F":
                        SwitchBoard.F = char.Parse(tb1.Text);
                        break;
                    case "G":
                        SwitchBoard.G = char.Parse(tb1.Text);
                        break;
                    case "H":
                        SwitchBoard.H = char.Parse(tb1.Text);
                        break;
                    case "I":
                        SwitchBoard.I = char.Parse(tb1.Text);
                        break;
                    case "J":
                        SwitchBoard.J = char.Parse(tb1.Text);
                        break;
                    case "K":
                        SwitchBoard.K = char.Parse(tb1.Text);
                        break;
                    case "L":
                        SwitchBoard.L = char.Parse(tb1.Text);
                        break;
                    case "M":
                        SwitchBoard.M = char.Parse(tb1.Text);
                        break;
                    case "N":
                        SwitchBoard.N = char.Parse(tb1.Text);
                        break;
                    case "O":
                        SwitchBoard.O = char.Parse(tb1.Text);
                        break;
                    case "P":
                        SwitchBoard.P = char.Parse(tb1.Text);
                        break;
                    case "Q":
                        SwitchBoard.Q = char.Parse(tb1.Text);
                        break;
                    case "R":
                        SwitchBoard.R = char.Parse(tb1.Text);
                        break;
                    case "S":
                        SwitchBoard.S = char.Parse(tb1.Text);
                        break;
                    case "T":
                        SwitchBoard.T = char.Parse(tb1.Text);
                        break;
                    case "U":
                        SwitchBoard.U = char.Parse(tb1.Text);
                        break;
                    case "V":
                        SwitchBoard.V = char.Parse(tb1.Text);
                        break;
                    case "W":
                        SwitchBoard.W = char.Parse(tb1.Text);
                        break;
                    case "X":
                        SwitchBoard.X = char.Parse(tb1.Text);
                        break;
                    case "Y":
                        SwitchBoard.Y = char.Parse(tb1.Text);
                        break;
                    case "Z":
                        SwitchBoard.Z = char.Parse(tb1.Text);
                        break;
                    default:
                        tb1.Text = tb1.Text;
                        break;
                }
                tb1.Text = ""; tb2.Text = "";
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            foreach(Label l in this.Controls.OfType<Label>())
            {
                l.Visible = true;
            }
            SwitchBoard.Reset();
        }
    }
}
