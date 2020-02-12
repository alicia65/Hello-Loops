using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_Loops
{
    public partial class Form1 : Form
    {
        private readonly object txtForLoop;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected = MessageBox.Show("Do you want to see some MessageBox dialogs?", "While", MessageBoxButtons.YesNo);

            while(selected == DialogResult.Yes)
            {
                selected = MessageBox.Show("Here's a MessageBox. Do you want another?", "While", MessageBoxButtons.YesNo);
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            DialogResult selected;

            do
            {
                selected = MessageBox.Show("Do you want another MessageBox?", "Do While", MessageBoxButtons.YesNo);
            } while (selected == DialogResult.Yes);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            /*user moves and sets trackbar by moving it left to right. 
            Furthermore, when user clicks on the for button, message window displays number 
            of time the message will be appearing on the window
            base on the value during setting phase. */
            for (int m = 0; m < trkForLoop.Value; m++)
            {
                MessageBox.Show("Here's MessageBox" + m);
            }
        }

        private void trkForLoop_Scroll(object sender, EventArgs e)
        {
            trkForLoop.Text = "" + trkForLoop.Value;  //show value in track the for loop        
        }
    }
}
