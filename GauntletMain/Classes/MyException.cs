using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrialOfFortune
{
    public  class MyException : Exception
    {
        public MyException(Exception e, string message)
        {
            var dr = MessageBox.Show("The application will be closed!\n"+ message + "\nErrorMessage:\n"+e.Message+"\nWould you like to report the error to Trial Of Fortune Team?","Attention!", MessageBoxButtons.YesNoCancel );

            if (dr == DialogResult.Yes) MessageBox.Show("The error was reported!");
            System.Environment.Exit(0);
        }
    }
}
