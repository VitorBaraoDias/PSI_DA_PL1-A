using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class ProfessorController
    {
        CantinaContext db;

        internal ProfessorController(CantinaContext db)
        {
            this.db = db;
        }

        internal void inserirProfessor(string nomProfessor, float saldo, int nifProfessor, string email)
        {

            Professor professor = new Professor { Nome = nomProfessor, Saldo = saldo, NIF = nifProfessor, Email = email };

            if (professor != null)
            {
                db.Professores.Add(professor);
                db.SaveChanges();
            }
        }

        internal void editarProfessor(Professor professorAntigo, Professor professorNovo)
        {


            var professorSelect = db.Professores.Find(professorAntigo.Id);

            if (professorSelect != null)
            {
                // Atualize as propriedades do objeto existente
                professorSelect.Nome = professorNovo.Nome;
                professorSelect.Saldo = professorNovo.Saldo;
                professorSelect.NIF = professorNovo.NIF;
                professorSelect.Email = professorNovo.Email;

                // Salve as alterações no contexto
                db.SaveChanges();
            }
        }

        internal List<Professor> obterListaProfessor()
        {
            List<Professor> listaProfessors = db.Professores.ToList();
            return listaProfessors;

        }
        internal void eliminarProfessor(Professor professor)
        {
            if (professor != null)
            {
                var professorSelect = db.Professores.Find(professor.Id);

                if (professorSelect != null)
                {
                    // Remova a entidade do contexto
                    db.Professores.Remove(professorSelect);

                    // Salve as alterações no contexto
                    db.SaveChanges();
                }
            }
        }

    }
}
