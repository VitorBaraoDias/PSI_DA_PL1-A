using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class Menu
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int QtdDisponivel {  get; set; }
        public float PrecoEstudante { get; set; }
        public float PrecoProfessor { get; set; }
        public List<Reserva> Reservas { get; set; }

        public List<QuantidadePrato> QuantidadePrato { get; set; }

        public List<QuantidadeExtra> QuantidadeExtra { get; set; }

        public override string ToString()
        {
            return DataHora.ToString();
        }

    }
}
