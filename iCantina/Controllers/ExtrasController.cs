using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class ExtrasController
    {
        CantinaContext db;

        internal ExtrasController(CantinaContext db)
        {
            this.db = db;
        }

        internal void inserirExtra(string descricaoExtra, float precoExtra, Boolean ativoExtra)
        {

            Extra extra = new Extra { Descricao = descricaoExtra, Preco = precoExtra, Ativo = ativoExtra };

            if (extra != null)
            {
                db.Extras.Add(extra);
                db.SaveChanges();
            }

        }

        internal void editarExtra(Extra extra, Extra extraNovo)
        {


            var extraSelect = db.Extras.Find(extra.Id);

            if (extraSelect != null)
            {
                // Atualize as propriedades do objeto existente
                extraSelect.Descricao = extraNovo.Descricao;
                extraSelect.Preco = extraNovo.Preco;
                extraSelect.Ativo = extraNovo.Ativo;

                // Salve as alterações no contexto
                db.SaveChanges();
            }
        }

        internal List<Extra> obterListaExtras()
        {

            List<Extra> listaExtras = db.Extras.ToList();
            return listaExtras;

        }

        internal List<Extra> obterListaExtrasAtivos()
        {

            List<Extra> listaExtras = db.Extras.ToList();
            List<Extra> listaExtrasAtivos = new List<Extra>();


            foreach (var extra in listaExtras)
            {
                if (extra.Ativo == true)
                {
                    listaExtrasAtivos.Add(extra);
                }
            }


            return listaExtrasAtivos;

        }

        internal void eliminarExtra(Extra extra)
        {
            if (extra != null)
            {
                var extraSelect = db.Extras.Find(extra.Id);

                if (extraSelect != null)
                {
                    // Remova a entidade do contexto
                    db.Extras.Remove(extraSelect);

                    // Salve as alterações no contexto
                    db.SaveChanges();
                }
            }
        }

    }
}

