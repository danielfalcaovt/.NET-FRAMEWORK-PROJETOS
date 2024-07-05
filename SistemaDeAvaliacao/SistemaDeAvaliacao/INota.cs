using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeAvaliacao
{
    public class INota
    {
        public Guid Id { get; set; }
        public string Professor { get; set; }
        public int Nota { get; set; }
        public string Turma { get; set; }
    }
}
