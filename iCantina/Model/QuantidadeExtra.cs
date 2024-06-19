using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class QuantidadeExtra 
    {
        public int Id { get; set; }

        public Menu Menu { get; set; }
        public Extra Extra { get; set; }
        public int Quantidade { get; set; }

        public override string ToString()
        {
            return Extra.Descricao  + "Qtd:" + Quantidade + "; ";
        }
    }
}
