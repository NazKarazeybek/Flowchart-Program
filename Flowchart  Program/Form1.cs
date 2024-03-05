using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Flowchart__Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void startButton_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            Refresh();
            textLabel.Text = "";

            string textfirst = "Hello World";

            foreach (char c in textfirst)
            {
                textLabel.Text += c;              
                textLabel.Refresh();
            }

            Thread.Sleep(3000);


            this.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            this.BackColor = Color.Black;
            Refresh();
            Thread.Sleep(400);

            this.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            this.BackColor = Color.Black;
            Refresh();
            Thread.Sleep(400);


            textLabel.Text = ""; 
            string textlast = "Press the exit button";
            textLabel.Text = "";

            foreach (char c in textlast)
            {
                textLabel.Text += c;
                textLabel.Refresh();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exitButton.Visible = false;
            startButton.Visible = false;
            textLabel.Text = "";

            string text = "Good Bye";

            foreach (char c in text)
            {
                textLabel.Text += c;
                textLabel.Refresh();
            }
            Thread.Sleep(2500);

            Application.Exit();
        }
    
    }
}
