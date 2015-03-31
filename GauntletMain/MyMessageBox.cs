using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrialOfFortune
{
    public partial class MyMessageBox : Form
    {
        public MyMessageBox(string title, string message)
            : base()
        {
            InitializeComponent();
        }

        public static void Show(string title, string message)
        {
            MyMessageBox m = new MyMessageBox(title, message);
            m.label1.Text = title;
            m.label2.Text = message;
            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
