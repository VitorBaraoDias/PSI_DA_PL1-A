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
            dataGridViewReservasMarcadas.DataSource = reservasController.obterListaReservas();
        }
    }
}
