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

        public List<Prato> Pratos { get; set; }

        public List<Extra> Extras { get; set; }



    }
}
