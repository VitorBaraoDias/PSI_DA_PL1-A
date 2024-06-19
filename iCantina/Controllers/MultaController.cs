using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class MultaController
    {
        CantinaContext db;

        internal MultaController(CantinaContext db)
        {
            this.db = db;
        } 

        internal void inserirMulta(int valorMulta, int numHoras)
        {

            Multa multa = new Multa { Valor = valorMulta, NumHoras = numHoras};

            if (multa != null)
            {
                db.Multas.Add(multa);
                db.SaveChanges();
            }
        }

        internal void editarMulta(Multa multa, Multa multaNova)
        {


            var multaSelect = db.Multas.Find(multa.Id);

            if (multaSelect != null)
            {
                // Atualize as propriedades do objeto existente
                multaSelect.Valor = multaNova.Valor;
                multaSelect.NumHoras = multaNova.NumHoras;

                // Salve as alterações no contexto
                db.SaveChanges();
            }
        }

        internal List<Multa> obterListaMultas()
        {

            List<Multa> listaMultas = db.Multas.ToList();
            return listaMultas;

        }
        internal void eliminarMulta(Multa multa)
        {
            if (multa != null)
            {
                var multaSelect = db.Multas.Find(multa.Id);

                if (multaSelect != null)
                {
                    // Remova a entidade do contexto
                    db.Multas.Remove(multaSelect);

                    // Salve as alterações no contexto
                    db.SaveChanges();
                }
            }
        }

    }
}
