using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class Reserva
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Menu Menu { get; set; }
        public Prato Prato { get; set; }
        public List<Extra> Extras { get; set; }

        public Multa Multa { get; set; } 
        //public bool estado { get; set; }
       
    }
}
