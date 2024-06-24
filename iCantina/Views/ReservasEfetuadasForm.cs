using iCantina.Controllers;
using iCantina.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class ReservasEfetuadasForm : Form
    {
        CantinaContext db;
        ReservasController reservasController;

        internal ReservasEfetuadasForm(CantinaContext db)
        {
            InitializeComponent();

            this.db = db;


            reservasController = new ReservasController(db);

        }

        private void ReservasEfetuadasForm_Load(object sender, EventArgs e)
        {
            dataGridViewReservasEfetuadas.DataSource = reservasController.obterReservasEfetuadas();
            dataGridViewReservasMarcadas.DataSource = reservasController.obterReservasNaoEfetuadas();
            //buscar reservas efetuadas
        }

        private void dataGridViewReservasMarcadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja marcar a reserva como efetuada?", "Confirmar reservar efetuada", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar se o usuário confirmou a deleção
            if (result == DialogResult.Yes)
            {
                DataGridViewRow selectedRow = dataGridViewReservasMarcadas.SelectedRows[0];
                Reserva reserva = (Reserva)selectedRow.DataBoundItem;

                Reserva reservaEfetuarda = reserva;
                reservaEfetuarda.estado = true;
                reservasController.editarReserva_para_Efetuada(reserva, reservaEfetuarda);

                //atualizar datasgrid
                dataGridViewReservasEfetuadas.DataSource = reservasController.obterReservasEfetuadas();
                dataGridViewReservasMarcadas.DataSource = reservasController.obterReservasNaoEfetuadas();
            }
        }

        private void ReservasEfetuadasForm_Activated(object sender, EventArgs e)
        {
            //atualizar datasgrid
            dataGridViewReservasEfetuadas.DataSource = reservasController.obterReservasEfetuadas();
            dataGridViewReservasMarcadas.DataSource = reservasController.obterReservasNaoEfetuadas();
        }
    }
}
