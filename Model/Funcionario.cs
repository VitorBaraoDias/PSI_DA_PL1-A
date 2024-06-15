using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Model
{
    internal class Funcionario : Utilizador
    {

        public string Username { get; set; }


        public override string ToString()
        {
            return Username + "," + NIF;
        }
    }
}
