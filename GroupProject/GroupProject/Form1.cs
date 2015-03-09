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

            //makes back key not key entries - but delete the last char of the string
            if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                if (label1.Text != "") //ensures no errors will be incurred by checking label if empty
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1);//removes last char from string
            }
            //else if (e.KeyChar == Convert.ToChar(Keys.Delete))
            //{
            //    if (label1.Text != "") //ensures no errors will be incurred by checking label if empty
            //        label1.Text = label1.Text.Remove(label1.Text.Length - 1);//removes last char from string
            //}
            else
            { 
                //adds the key entry into a label
                label1.Text = label1.Text + c.ToString();
            }

            //uses an if statement to determine if the return or fullstop key is pressed
            if (e.KeyChar == Convert.ToChar(Keys.Return) || c == '.')
            {
                label1.Text = ""; //resets label
            }

            

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //getting the current date and time
            DateTime timestamp = DateTime.Now;
            label2.Text = "The time and date is " + timestamp.ToString();

            //getting the computer name 
            string computer = System.Environment.MachineName;
            label3.Text = "The name of the computer is " + computer.ToString();

        }
        



        
    }
}
