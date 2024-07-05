using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeAvaliacao
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            RankingAccess ranking = new RankingAccess();
            var notas = ranking.GetRanking();
            List<INota> Ranking = new List<INota>();
            foreach (var nota in notas)
            {
                if (Ranking.Count != 0)
                {
                    var checkIfAlreadyHas = Ranking.Find(x => x.Turma == nota.Turma);
                    if (checkIfAlreadyHas != null)
                    {
                        Ranking[Ranking.IndexOf(checkIfAlreadyHas)].Nota += nota.Nota;
                    }
                    else
                    {
                        Ranking.Add(nota);
                    }
                }
                else
                {
                    Ranking.Add(nota);
                }

            }
            Ranking.Sort((n1, n2) => n2.Nota.CompareTo(n1.Nota));
            foreach (var nota in Ranking)
            {
                txtRanking.Text += $"{nota.Turma}\t{nota.Nota}{Environment.NewLine}";
            }
            txtVencedor.Text = Convert.ToString(Ranking.First().Turma);
        }
    }
}
