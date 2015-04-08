using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void ShowResults(Highscore highscore)
        {
            List<Record> results = highscore.ReadScoresFromFile("..//..//scores.txt");
            results = results.OrderByDescending(x => x.Score).ToList();
            ResultsForm f = new ResultsForm();
            f.dgvResults1.UpdateDgv(results);
            f.dgvResults1.FormatDgv(highscore);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class dgvResults : DataGridView
    {
        public dgvResults()
            : base()
        {

        }

        public void UpdateDgv(List<Record> lis)
        {
            this.DataSource = new List<dgvline>();

            foreach (var x in lis) dgvList.Add(new dgvline(x));

            this.DataSource = dgvList;
        }

        private class dgvline
        {
            public dgvline(Record rec)
            {
                this.r = rec;
            }

            public Record r;

            public string gameUID = "";

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
                    return r.Score.ToString();
                }
            }
            public string Date
            {
                get
                {
                    return r.Date.ToString("dd.MM.yyyy");
                }
            }

            public string You
            {
                get
                {
                    return gameUID == r.UID ? "x" : "";
                }
            }
        }

        private List<dgvline> dgvList = new List<dgvline>();


        public void FormatDgv(Highscore currScore)
        {
            this.Columns[0].Width = 200;
            this.Columns[1].Width = 80;
            this.Columns[2].Width = 130;
            this.Columns[3].Width = 50;

            this.Columns[0].HeaderText = "Player";
            this.Columns[1].HeaderText = "Result";
            this.Columns[2].HeaderText = "Date";
            this.Columns[3].HeaderText = "You";

            for (int i = 0; i < dgvList.Count(); i++)
            {
                dgvline l = dgvList[i];
                if (l.r.UID == currScore.playerScore.UID)
                {
                    l.gameUID = currScore.playerScore.UID;
                    continue;
                }
            }


            int currPlayerRow = this.dgvList.FindIndex(x => x.r.UID == currScore.playerScore.UID);

            if (currPlayerRow >= 0) dgvList[currPlayerRow].gameUID = currScore.playerScore.UID;

            //  if (currPlayerRow>=0) this.Rows[currPlayerRow].Cells[0].Style.BackColor  = Color.Yellow;
            this.Refresh();
        }

    }
}
