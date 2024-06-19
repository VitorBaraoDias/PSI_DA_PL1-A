using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class Utilizador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int NIF { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
