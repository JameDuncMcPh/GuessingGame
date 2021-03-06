﻿/// Description: The program generates a random number between 1-100 which
///              the use must guess
/// Author:      Mr. T

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        //creates a random number between 1 and 100 and stores it in a global 
        //variable that can be used throughout the program 
        public static Random randNum = new Random();
        public static List<int> guessList = new List<int>();
        int rand = randNum.Next(1, 101);
        int guess = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // get the users guess and place into a variable
            try
            {
                guess = Convert.ToInt16(inputBox.Text);
                guessList.Add(guess);
            }
            catch
            {
                guess = 0;
                guessList.Add(guess);
            }

            // check guess against the random value and output appropriate message
            if (guess < rand)
            {
                outputLabel.Text = "Too Low!";
            }
            else if (guess > rand)
            {
                outputLabel.Text = "Too High!";
            }
            else
            {
                outputLabel.Text = "You Got it!";

                //Create new login screen
                loginScreen ls = new loginScreen();
                this.Controls.Add(ls);
                ls.BringToFront();
            }

            // clear out the input box 
            inputBox.Text = "";
        }
    }
}
