using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class Multa
    {
        public int Id { get; set; }

        public float Valor { get; set; }

        public int NumHoras { get; set; }

        public List<Reserva> Reservas { get; set;}
    }
}
