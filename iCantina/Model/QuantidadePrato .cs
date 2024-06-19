using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class QuantidadePrato
    {
        public int Id { get; set; }

        public Menu Menu { get; set; }
        public Prato Prato { get; set; }
        public int Quantidade { get; set; }

        public override string ToString()
        {
            return Prato.Descricao + "Qtd:" + Quantidade + "; ";
        }
    }
}
