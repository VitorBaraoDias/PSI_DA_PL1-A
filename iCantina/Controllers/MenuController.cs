using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace iCantina.Controllers
{
    internal class MenuController
    {
        CantinaContext db;

        internal MenuController(CantinaContext db)
        {
            this.db = db;
        }

        internal void inserirMenu(DateTime DataHora, int QtdDisponivel, float PrecoEstudante, float PrecoProfessor, List<QuantidadePrato> QuantidadePrato, List<QuantidadeExtra> QuantidadeExtra)
        {

            Menu menu = new Menu { DataHora = DataHora, QtdDisponivel = QtdDisponivel, PrecoEstudante = PrecoEstudante, PrecoProfessor = PrecoProfessor, QuantidadePrato = QuantidadePrato, QuantidadeExtra = QuantidadeExtra };

            if (menu != null)
            {
                db.Menus.Add(menu);
                db.SaveChanges();
            }

        }
        internal List<Menu> obterListaMenu()
        {
            List<Menu> menus = db.Menus
                                 .Include(m => m.QuantidadePrato.Select(qp => qp.Prato))
                                 .Include(m => m.QuantidadeExtra.Select(qe => qe.Extra))
                                 .ToList();
            return menus;
        }
        public List<Menu> obterMenusPorData(DateTime data)
        {
            DateTime startOfDay = data.Date;
            DateTime endOfDay = data.Date.AddDays(1).AddTicks(-1);

            return db.Menus
                .Include(m => m.QuantidadePrato.Select(qp => qp.Prato))
                .Include(m => m.QuantidadeExtra.Select(qe => qe.Extra))
                .Where(m => m.DataHora >= startOfDay && m.DataHora <= endOfDay)
                .ToList();
        }
        internal void editarMenu(Menu menu, Menu menuNovo)
        {

            var menuSelect = db.Menus.Find(menu.Id);

            if (menuSelect != null)
            {
                // Atualize as propriedades do objeto existente
                menuSelect.DataHora = menuNovo.DataHora;
                menuSelect.PrecoEstudante = menuNovo.PrecoEstudante;
                menuSelect.PrecoProfessor = menuNovo.PrecoProfessor;
                menuSelect.QtdDisponivel = menuNovo.QtdDisponivel;
                menuSelect.Reservas = menuNovo.Reservas;
                menuSelect.QuantidadePrato = menuNovo.QuantidadePrato;
                menuSelect.QuantidadeExtra = menuNovo.QuantidadeExtra;

                // Salve as alterações no contexto
                db.SaveChanges();
            }
        }
        internal void eliminarMenu(Menu menu)
        {
            if (menu != null)
            {
                var menuSelect = db.Menus.Find(menu.Id);

                if (menuSelect != null)
                {
                    // Remova a entidade do contexto
                    db.Menus.Remove(menuSelect);

                    // Salve as alterações no contexto
                    db.SaveChanges();
                }
            }
        }

    }
}
