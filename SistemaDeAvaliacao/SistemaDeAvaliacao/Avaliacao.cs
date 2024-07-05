using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

namespace SistemaDeAvaliacao
{
    public class Avaliacao
    {
        private string connectionString = "Server=localhost, 1433;Database=AvaliadorDeProjeto;User ID=sa;Password=Brbr109br@;Trusted_Connection=false;TrustServerCertificate=true";
        public Guid Id { get; set; }
        public string Professor { get; set; }
        public int Nota { get; set; }
        public string Turma { get; set; }
        public Avaliacao(string professor, int nota, string turma)
        {
            Id = Guid.NewGuid();
            Professor = professor;
            Nota = nota;
            Turma = turma;
        }
        public IEnumerable<INota> Avaliar()
        {
            var SqlInsert = "INSERT INTO [Avaliacoes] VALUES(@id, @professor, @nota, @turma)";
            var SqlGet = "SELECT * FROM [Avaliacoes] WHERE [Id] = @id";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(SqlInsert, new
                {
                    id = Id,
                    professor = Professor,
                    nota = Nota,
                    turma = Turma
                });
                var notas = connection.Query<INota>(SqlGet, new
                {
                    id = Id
                });
                return notas;
            }
        }
    }
}
