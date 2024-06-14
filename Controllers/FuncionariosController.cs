
using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class FuncionariosController
    {
        CantinaContext db;

        internal FuncionariosController(CantinaContext db)
        {
            this.db = db;
        }

        internal void inserirFuncionario( string nomeFuncionario, int nifFuncionario, string usernameFuncionario)
        {
           
                Funcionario funcionario = new Funcionario { Nome = nomeFuncionario, NIF = nifFuncionario, Username = usernameFuncionario };

                if(funcionario != null ) {
                    db.Funcionarios.Add(funcionario);
                    db.SaveChanges();
                }
        }

        internal void editarFuncionario(Funcionario funcionario, string nomeFuncionario, int nifFuncionario, string usernameFuncionario)
        {

            funcionario.Nome = nomeFuncionario;
            funcionario.NIF = nifFuncionario;
            funcionario.Username = usernameFuncionario;

            if (funcionario != null)
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
            }
        }



        internal List<Funcionario> obterListaFuncionarios()
        {

            List<Funcionario> listaFuncionarios = db.Funcionarios.ToList();
            return listaFuncionarios;
            
        }
    }
}
