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
            orderLabel.Text = Form1.guessList.ToString();
          //  numberedLabel.Text = ;
        }
    }
}
