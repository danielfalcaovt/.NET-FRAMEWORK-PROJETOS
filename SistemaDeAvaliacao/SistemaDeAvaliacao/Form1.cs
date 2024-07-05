using Microsoft.Data.SqlClient;
using Dapper;
using System.ComponentModel;

namespace SistemaDeAvaliacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Int32 frmNota = Convert.ToInt32(tbNota.Value);
            string frmProfessor = (string)txtAvaliador.SelectedItem;
            string frmTurma = (string)cbTurma.SelectedItem;
            try
            {
                if (!string.IsNullOrEmpty(frmTurma) && !string.IsNullOrEmpty(frmProfessor))
                {
                    button1.Visible = false;
                    btnRanking.Visible = false;
                    Avaliacao novaAvaliacao = new Avaliacao(frmProfessor, frmNota, frmTurma);
                    var notas = novaAvaliacao.Avaliar();
                    foreach (var nota in notas)
                    {
                        lblTeste.Text = $"{nota.Turma} {nota.Professor} {nota.Nota}";
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Você não pode avaliar a mesma turma 2 vezes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                button1.Visible = true;
                btnRanking.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbNota_ValueChanged(object sender, EventArgs e)
        {
            lblNota.Text = $"{tbNota.Value}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            Ranking rankForm = new Ranking();
            rankForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRanking_MouseEnter(object sender, EventArgs e)
        {
            btnRanking.BackColor = Color.White;
            btnRanking.ForeColor = Color.FromArgb(181, 150, 231);
        }

        private void btnRanking_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnRanking_MouseLeave(object sender, EventArgs e)
        {
            btnRanking.BackColor = Color.Transparent;
            btnRanking.ForeColor = Color.White;
        }
    }
}
