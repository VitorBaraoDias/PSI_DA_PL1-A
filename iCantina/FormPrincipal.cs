using iCantina.Controllers;
using iCantina.Model;
using iCantina.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina
{
    public partial class Form1 : Form
    {
        //Instanciar o contexto da base de dados
        CantinaContext db = new CantinaContext();

        Dictionary<string, Form> dicionario = new Dictionary<string, Form>();


        public Form1()
        {

            InitializeComponent();

            dicionario.Add("Funcionários", new FuncionarioForm(db));
            dicionario.Add("Estudantes", new EstudanteForm(db));
            dicionario.Add("Professores", new ProfessorForm(db));
            dicionario.Add("Multas", new MultaForm(db));
            dicionario.Add("Pratos", new PratosForm(db));
            dicionario.Add("Extras", new ExtrasForm(db));
            dicionario.Add("Menus", new MenuForm(db, false, DateTime.Now.Date));
            dicionario.Add("Home", new HomeForm(db));
            dicionario.Add("Reservas efetuadas", new ReservasEfetuadasForm(db));


            containerPai.AutoSize = false;
            containerPai.AutoScroll = true; // Para habilitar a rolagem se necessário
            containerPai.WrapContents = false; // Para garantir que os controles sejam empilhados verticalmente ou horizontalmente
          
            setPage(btnHome, null);
            FuncionariosController funcionariosController = new FuncionariosController(db);

            dropFuncionario.DataSource = funcionariosController.obterListaFuncionarios();

        }




        private void setPage(object sender, EventArgs e)
        {

            Form formSelect = dicionario[((Control)sender).Text];

            containerPai.Controls.Clear();
            formSelect.MdiParent = this;
            containerPai.Controls.Add(formSelect);
            formSelect.Show();

        }
    }
}
