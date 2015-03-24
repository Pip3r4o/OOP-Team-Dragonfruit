using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GauntletMain
{
    public partial class GameForm : GameUIForm
    {//dimitar

        public GameForm()
        {
            InitializeComponent();
            BeginNewGame();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }


    }
}
