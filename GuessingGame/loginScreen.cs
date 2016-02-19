using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class loginScreen : UserControl
    {
        public loginScreen()
        {
            InitializeComponent();

            numberLabel.Text = Convert.ToString(Form1.guessList.Count());

            foreach (int number in Form1.guessList)
            {
                orderLabel.Text += Convert.ToString(number) + ",";
            }

            Form1.guessList.Sort();

            foreach (int number in Form1.guessList)
            {
                numberedLabel.Text += Convert.ToString(number) + ",";
            }
        }
    }
}
