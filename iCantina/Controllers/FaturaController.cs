using iCantina.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCantina.Controllers
{
    internal class FaturaController
    {
        CantinaContext db;
        internal FaturaController(CantinaContext db)
        {
            this.db = db;
        }
        internal Fatura inserirFatura( Reserva reserva, float Total)
        {
            //inserir todos os itens fatura
            Fatura fatura = new Fatura { Total = Total, Cliente = reserva.Cliente, ItemsFatura = getItensDaFatura(reserva)};

            if (reserva != null)
            {
                db.Faturas.Add(fatura);
                db.SaveChanges();
            }

            return fatura;
        }
        private List<ItemFatura> getItensDaFatura(Reserva reserva)
        {
            List<ItemFatura> itensFatura = new List<ItemFatura>();

            float valorPrato = 0;

            if (reserva.Cliente is Estudante)
            {
                valorPrato = reserva.Menu.PrecoEstudante; 
            }
            else if (reserva.Cliente is Professor)
            {
                valorPrato = reserva.Menu.PrecoEstudante;
            }

            itensFatura.Add(new ItemFatura
            {
                Descricao = "Prato:"+ reserva.Prato.Descricao,
                Preco = valorPrato
            });
            foreach (var extra in reserva.Extras)
            {
                itensFatura.Add(new ItemFatura
                {
                    Descricao = "Extra:" + extra.Descricao,
                    Preco = extra.Preco
                });
            }
            if (reserva.Multa != null)
            {
                itensFatura.Add(new ItemFatura
                {
                    Descricao = "Multa por atraso:",
                    Preco= reserva.Multa.Valor
                });
            }

            db.ItemFaturas.AddRange(itensFatura);
            db.SaveChanges();
            return itensFatura;

        }

    }
}
