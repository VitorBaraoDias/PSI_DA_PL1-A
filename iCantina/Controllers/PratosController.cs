using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class PratosController
    {
        CantinaContext db;

        internal PratosController(CantinaContext db)
        {
            this.db = db;
        }

        internal void inserirPrato(string descricaoPrato, string tipoPrato, Boolean ativoPrato)
        {

            Prato prato = new Prato { Descricao = descricaoPrato, Tipo = tipoPrato, Ativo = ativoPrato };

            if (prato != null)
            {
                db.Prato.Add(prato);
                db.SaveChanges();
            }

        }

        internal void editarPrato(Prato prato, Prato pratoNovo)
        {


            var pratoSelect = db.Prato.Find(prato.Id);

            if (pratoSelect != null)
            {
                // Atualize as propriedades do objeto existente
                pratoSelect.Descricao = pratoNovo.Descricao;
                pratoSelect.Tipo = pratoNovo.Tipo;
                pratoSelect.Ativo = pratoNovo.Ativo;

                // Salve as alterações no contexto
                db.SaveChanges();
            }
        }

        internal List<Prato> obterListaPratos()
        {

            List<Prato> listaPratos = db.Prato.ToList();
            return listaPratos;

        }
        internal List<Prato> obterListaPratosTipo(string tipo)
        {
            return db.Prato.Where(p => p.Tipo.ToLower() == tipo.ToLower() && p.Ativo).ToList();
        }



        internal void eliminarPrato(Prato prato)
        {
            if (prato != null)
            {
                var pratoSelect = db.Prato.Find(prato.Id);

                if (pratoSelect != null)
                {
                    // Remova a entidade do contexto
                    db.Prato.Remove(pratoSelect);

                    // Salve as alterações no contexto
                    db.SaveChanges();
                }
            }
        }

    }
}
