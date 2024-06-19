
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

        internal void editarFuncionario(Funcionario funcionario, Funcionario funcionarioNovo)
        {


            var funcionarioSelect = db.Funcionarios.Find(funcionario.Id);

            if (funcionarioSelect != null)
            {
                // Atualize as propriedades do objeto existente
                funcionarioSelect.Nome = funcionarioNovo.Nome;
                funcionarioSelect.NIF = funcionarioNovo.NIF;
                funcionarioSelect.Username = funcionarioNovo.Username;

                // Salve as alterações no contexto
                db.SaveChanges();
            }
        }

        internal List<Funcionario> obterListaFuncionarios()
        {

            List<Funcionario> listaFuncionarios = db.Funcionarios.ToList();
            return listaFuncionarios;
            
        }
        internal void eliminarFuncionario(Funcionario funcionario)
        {
            if (funcionario != null)
            {
                var funcionarioSelect = db.Funcionarios.Find(funcionario.Id);

                if (funcionarioSelect != null)
                {
                    // Remova a entidade do contexto
                    db.Funcionarios.Remove(funcionarioSelect);

                    // Salve as alterações no contexto
                    db.SaveChanges();
                }
            }
        }

    }
}
