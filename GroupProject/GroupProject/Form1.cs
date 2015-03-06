using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //uses char to contain the key entry - strings will allow for storing of words too later
            char c;
            c = e.KeyChar;
            //adds the key entry into a label
            label1.Text = label1.Text + c.ToString();

            //uses an if statement to determine if the return, space or fullstop key is pressed
            if (e.KeyChar == Convert.ToChar(Keys.Return) || c == ' ' || c == '.')
            {
                //resets label
                label1.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
