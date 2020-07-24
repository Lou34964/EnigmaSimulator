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

        }

        private void SwitchBoardSelect(object sender, EventArgs e)
        {
            if (tb1.Text != "")
            {
                tb1.Text = (sender as Label).Text;
                
            }
            else
            {
                tb2.Text = (sender as Label).Text;
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
        }
    }
}
