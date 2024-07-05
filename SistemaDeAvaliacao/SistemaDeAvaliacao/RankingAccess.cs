using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

namespace SistemaDeAvaliacao
{
    public class RankingAccess
    {
        private string connectionString = "Server=localhost, 1433;Database=AvaliadorDeProjeto;User ID=sa;Password=Brbr109br@;Trusted_Connection=false;TrustServerCertificate=true";
        public string SqlGet = "SELECT [Nota], [Turma] FROM [Avaliacoes] ORDER BY [Nota] DESC";
        public IEnumerable<INota> GetRanking()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var notas = connection.Query<INota>(SqlGet);
                return notas;
            }
        }
    }
}
