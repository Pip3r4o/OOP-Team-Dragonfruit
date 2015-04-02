using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrialOfFortune.Classes;

namespace TrialOfFortune
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }
                
        public static void  ShowResults(Highscore h)
        {
            List<Highscore.Record> results = h.ReadScoresFromFile("..//..//scores.txt");
            results = results.OrderByDescending(x => x.Score).ToList();
            ResultsForm f = new ResultsForm();
            f.dgvResults1 .UpdateDgv(results);
            f.dgvResults1.FormatDgv(h);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public  class dgvResults : DataGridView
    {
        public   void UpdateDgv(List<Highscore.Record> lis)
        {
            this.DataSource = new List <dgvline >();
            
            foreach (var x in lis) dgvList.Add(new dgvline(x));
       
            this.DataSource = dgvList;
        }

        private class dgvline
        {
            public dgvline(Highscore .Record rec )
            {
                this.r = rec;
            }

            public  Highscore.Record r ;

            public string Player
            {
                get
                {
                    return r.Name;
                }
            }

            public string Result
            {
                get
                {
                    return r.Score.ToString ();
                }
            }
            public string Date
            {
                get
                {
                    return r.Date.ToString("dd.MM.yyyy");
                }
            }
        }

        private List<dgvline> dgvList = new List<dgvline>();

        public  void FormatDgv(Highscore currScore)
        {
            this.Columns[0].Width = 200;
            this.Columns[1].Width = 150;
            this.Columns[2].Width = 130;

            this.Columns[0].HeaderText = "Player";
            this.Columns[1].HeaderText = "Result";
            this.Columns[2].HeaderText = "Date";

            

            int currPlayerRow= this.dgvList.FindIndex (x => x.r.UID == currScore.PlayerScore.UID);

            if (currPlayerRow>=0) this.Rows[currPlayerRow].Cells[0].Style.BackColor  = Color.Yellow;
            this.Refresh();
        }

    }
}
