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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rotors.SetRotors();
            Reflectors.SetReflectors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rotors.A = Rotors.I;
            Rotors.B = Rotors.III;
            Rotors.C = Rotors.II;
            Reflectors.A = Reflectors.II;
            MessageBox.Show(Rotors.C.GetIncr(Rotors.B.GetIncr(Rotors.A.GetIncr(Reflectors.A.GetIncr(Rotors.A.GetIncr(Rotors.B.GetIncr(Rotors.C.GetIncr(char.Parse(textBox1.Text)))))))).ToString());
        }
    }
}
