using System;
using System.Windows.Forms;

namespace week10
{
    public partial class Form1 : Form
    {
        Random randomNumberGenerator = new Random();
        string hintLabelDefault = "??";

        int currentIndex = 0; // This int is incremented with each guess to traverse the array

        const int ARRAY_LENGTH = 100; // This const is used to define the length of the array that contains random numbers

        int correctCounter = 0;
        int incorrectCounter = 0;

        // An array is declared here to store the random values needed for the user to guess
        int[] randomArray = new int[ARRAY_LENGTH];

        public int[] getRandomArray()
        {
            int[] newRandomArray = new int[ARRAY_LENGTH];

            // A for loop is used to assign random ints to the array
            for(int num = 0; num < ARRAY_LENGTH; ++num)
            {
                newRandomArray[num] = randomNumberGenerator.Next(1, ARRAY_LENGTH + 1); // The Random() excludes the high number passed to it, hence +1
            }

            return newRandomArray;
        }

        public Form1()
        {
            InitializeComponent();

            randomArray = getRandomArray(); // The array is filled with random integers after the form is initialized

        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            // This integer is used with tryParse to test if the user entered an integer
            int tempGuess;
            if (!Int32.TryParse(guessTextBox.Text, out tempGuess))
            {
                guessTextBox.Clear();
                errorLabel.Text = "That is not a valid guess";
            }
            else {

                // If the guess is a valid int, the guess button is disable and the next guess button is enabled
                guessButton.Enabled = false;
                nextGuessButton.Enabled = true;

                // The guess is compared to the winning number in this if statement
                if (tempGuess == randomArray[currentIndex])
                {
                    ++correctCounter; // The correct counter is incremented
                    winLoseLabel.Text = "You Win"; // The user is informed they won
                    correctLabel.Text = "Correct: " + Convert.ToString(correctCounter); // The correct counter is updated
                }
                else
                {
                    ++incorrectCounter; // The incorrect counter is incremented

                    // The user is informed they are wrong
                    winLoseLabel.Text = "Sorry - You Lose.\nThe number is " + randomArray[currentIndex];
                    incorrectLabel.Text = "Incorrect: " + Convert.ToString(incorrectCounter); // The incorrect counter is updated
                }

                hintActivateLabel.Enabled = false; // This hint label is disabled until the next guess button is clicked
                nextGuessButton.Focus(); // Focus is given to the next guess button for convenience
            }

        }

        private void nextGuessButton_Click(object sender, EventArgs e)
        {
            // Clicking the Next Guess button resets all the fields and buttons
            guessButton.Enabled = true;
            winLoseLabel.Text = "";
            hintLabel.Text = hintLabelDefault;
            nextGuessButton.Enabled = false;
            hintActivateLabel.Enabled = true;
            guessTextBox.Clear();

            // A new winning number is chosen by incrementing the random array index
            if (currentIndex < randomArray.Length - 1) // -1 is required to prevent currentIndex from being equal to the array length and causing an exception
            {
                ++currentIndex;
            }
            else
            {
                currentIndex = 0; // The index is set to 0 if it is at the final index
                randomArray = getRandomArray(); // The array is populated with new random numbers
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hintActivateLabel_MouseMove(object sender, MouseEventArgs e)
        {
            // The hint is activated if the user's mouse moves over this lable

            // The hint is conditional based on the winning number
            if(randomArray[currentIndex] > 3 && randomArray[currentIndex] < 96)
            {
                hintLabel.Text = "It is not " + (randomArray[currentIndex] + 3);
            }
            else
            {
                hintLabel.Text = "It is not " + (randomArray[currentIndex] - 1);
            }
        }

        private void guessTextBox_Click(object sender, EventArgs e)
        {
            errorLabel.Text = ""; // Clicking on the guess textbox clears the error label
        }
    }
}
