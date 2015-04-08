using System;
using System.Windows.Forms;

namespace TrialOfFortune.Classes
{
    class InvalidHighscoresDataException : Exception
    {
        public InvalidHighscoresDataException(string message)
        {
            var dialogResult = MessageBox.Show("The application will be closed!\n" + message + "\nErrorMessage:\n" + message + "\nWould you like to report the error to Trial Of Fortune Team?", "Attention!",
                MessageBoxButtons.YesNoCancel);

            if (dialogResult == DialogResult.Yes) MessageBox.Show("The error was reported!");
            System.Environment.Exit(0);
        }
    }
}