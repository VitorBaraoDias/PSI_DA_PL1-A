using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class ReservasController
    {
        CantinaContext db;

        internal ReservasController(CantinaContext db)
        {
            this.db = db;
        }

        internal void inserirReservas(Cliente cliente, Menu menu, Prato prato, List<Extra> extras, Multa multa)
        {

           
            Reserva reserva = new Reserva { Cliente = cliente, Menu = menu, Prato = prato, Extras = extras, Multa = multa };

            if (reserva != null)
            {
                db.Reservas.Add(reserva);
                db.SaveChanges();
            }
        }
        internal List<Reserva> obterListaReservas()
        {


            return db.Reservas
                           .Include(r => r.Cliente)
                           .Include(r => r.Prato)
                           .Include(r => r.Menu)
                           .Include(r => r.Multa)
                           .Include(r => r.Extras) // Se Extras é uma coleção
                           .ToList();
        }
        internal bool verificarReservaCliente(Cliente cliente, Menu menu)
        {
            return obterListaReservas().Exists(r => r.Cliente == cliente && r.Menu.Id == menu.Id);
        }
    }
}
