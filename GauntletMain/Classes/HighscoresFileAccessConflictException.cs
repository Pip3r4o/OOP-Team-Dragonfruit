using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrialOfFortune
{
    public  class HighscoresFileAccessConflictException : Exception
    {
        public HighscoresFileAccessConflictException(Exception e, string message)
        {
            var dialogResult = MessageBox.Show("The application will be closed!\n"+ message + "\nErrorMessage:\n"+e.Message+"\nWould you like to report the error to Trial Of Fortune Team?","Attention!",
                MessageBoxButtons.YesNoCancel );

            if (dialogResult == DialogResult.Yes) MessageBox.Show("The error was reported!");
            System.Environment.Exit(0);
        }
    }
}
