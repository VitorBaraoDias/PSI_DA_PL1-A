using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class Fatura
    {
        
        public float Total;
        public int Id { get; set; }
        public Cliente Cliente;
        public List<ItemFatura> ItemsFatura { get; set; }

    }
}
