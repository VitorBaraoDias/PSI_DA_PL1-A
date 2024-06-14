using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
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

namespace iCantina
{
    public partial class FuncionarioForm : Form
    {
        FuncionariosController funcionarioController;

        CantinaContext db;
        internal FuncionarioForm(CantinaContext db)
        {
            InitializeComponent();
           this.db = db;
           funcionarioController = new FuncionariosController(db);
        }

        private void FuncionarioForm_Load(object sender, EventArgs e)
        {


            dataGridViewfFuncionario.DataSource = funcionarioController.obterListaFuncionarios();
            // TODO: esta linha de código carrega dados na tabela '_iCantina_Model_CantinaContextDataSet1.Utilizadors'. Você pode movê-la ou removê-la conforme necessário.
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(CheckTextBox(tbNome) && CheckTextBox(tbNIF) && CheckTextBox(tbUsername) == true )
            {
                FuncionariosController funcionarios = new FuncionariosController(db);

                funcionarios.inserirFuncionario(tbNome.Text, Convert.ToInt32(tbNIF.Text), tbUsername.Text);

                dataGridViewfFuncionario.DataSource = funcionarios.obterListaFuncionarios();

            }
        }

        

        private bool CheckTextBox( BunifuTextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show(tb.Name + "must be filled");

                return false;
            }
            
            
            return true;
        }

        private void tbNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }


}

