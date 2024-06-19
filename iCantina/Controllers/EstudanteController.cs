using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class EstudanteController
    {
        CantinaContext db;

        internal EstudanteController(CantinaContext db)
        {
            this.db = db;
        }

        internal void inserirEstudante(string nomeFuncionario, float saldo, int nifFuncionario, int NumEstudante)
        {

            Estudante estudante = new Estudante { Nome = nomeFuncionario, Saldo = saldo, NIF = nifFuncionario, NumEstudante = NumEstudante };

            if (estudante != null)
            {
                db.Estudantes.Add(estudante);
                db.SaveChanges();
            }
        }

        internal void editarEstudante(Estudante estudanteAntigo, Estudante estudanteNovo)
        {


            var estudanteSelect = db.Estudantes.Find(estudanteAntigo.Id);

            if (estudanteSelect != null)
            {
                // Atualize as propriedades do objeto existente
                estudanteSelect.Nome = estudanteNovo.Nome;
                estudanteSelect.Saldo = estudanteNovo.Saldo;
                estudanteSelect.NIF = estudanteNovo.NIF;
                estudanteSelect.NumEstudante = estudanteNovo.NumEstudante;

                // Salve as alterações no contexto
                db.SaveChanges();
            }
        }

        internal List<Estudante> obterListaEstudantes()
        {

            List<Estudante> listaEstudantes = db.Estudantes.ToList();
            return listaEstudantes;

        }
        internal void eliminarEstudante(Estudante estudante)
        {
            if (estudante != null)
            {
                var funcionarioSelect = db.Estudantes.Find(estudante.Id);

                if (funcionarioSelect != null)
                {
                    // Remova a entidade do contexto
                    db.Estudantes.Remove(funcionarioSelect);

                    // Salve as alterações no contexto
                    db.SaveChanges();
                }
            }
        }

    }
}
