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
        List<Funcionario> funcionariosList = new List<Funcionario>();
        internal FuncionarioForm(CantinaContext db)
        {
            InitializeComponent();
           this.db = db;
           funcionarioController = new FuncionariosController(db);
        }

        private void FuncionarioForm_Load(object sender, EventArgs e)
        {
            funcionariosList = funcionarioController.obterListaFuncionarios();
            dataGridViewfFuncionario.DataSource = funcionariosList;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(CheckTextBox(tbNome) && CheckTextBox(tbNIF) && CheckTextBox(tbUsername) == true )
            {
                funcionarioController.inserirFuncionario(tbNome.Text, Convert.ToInt32(tbNIF.Text), tbUsername.Text);


                funcionariosList = funcionarioController.obterListaFuncionarios();
                dataGridViewfFuncionario.DataSource = funcionariosList;
                clearText();

                btneEdite.Enabled = false;

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

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text == "") //caixa de texto vazia, preenche a dataView
            {
                dataGridViewfFuncionario.DataSource = funcionariosList;

            }
            // Verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevenir o som do sistema para a tecla Enter
                e.Handled = true;

                // Chamar o método de pesquisa
                var listaFiltrada = funcionariosList.Where(f => f.Username.Equals(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                // Atualizar o DataGridView com a lista filtrada
                dataGridViewfFuncionario.DataSource = listaFiltrada;

                // Opcional: Mostrar uma mensagem se nenhum resultado for encontrado
                if (listaFiltrada.Count == 0)
                {
                    txtSearch.Text = "";
                    dataGridViewfFuncionario.DataSource = funcionariosList;
                    MessageBox.Show("Nenhum funcionário encontrado com o username fornecido.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        private void dataGridViewfFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada é válida
            {
                // Obter o funcionário selecionado   
                Funcionario funcionario = (Funcionario)dataGridViewfFuncionario.Rows[e.RowIndex].DataBoundItem;

                // Preencher os campos do formulário com os dados do funcionário sele cionado
                tbNome.Text = funcionario.Nome;
                tbUsername.Text = funcionario.Username;
                tbNIF.Text = funcionario.NIF.ToString();

                btneEdite.Enabled = true;
            }
        }

        private void btneEdite_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbNome) && CheckTextBox(tbNIF) && CheckTextBox(tbUsername))
            {
                if (dataGridViewfFuncionario.SelectedRows.Count > 0)
                {
                    // Obter a linha selecionada
                    DataGridViewRow selectedRow = dataGridViewfFuncionario.SelectedRows[0];

                    // Obter o objeto Funcionario da linha selecionada
                    Funcionario funcionarioAntigo = (Funcionario)selectedRow.DataBoundItem;

                    Funcionario funcionarioNovo = new Funcionario
                    {
                        Nome = tbNome.Text,
                        NIF = int.Parse(tbNIF.Text),
                        Username = tbUsername.Text
                    };
                    funcionarioController.editarFuncionario(funcionarioAntigo, funcionarioNovo);

                    // Atualizar a lista de funcionários e a DataGridView
                    funcionariosList = funcionarioController.obterListaFuncionarios();
                    dataGridViewfFuncionario.DataSource = funcionariosList;

                    btneEdite.Enabled = false;
                    clearText();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um funcionário para editar.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewfFuncionario.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja eliminar este funcionário?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar se o usuário confirmou a deleção
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewfFuncionario.SelectedRows[0];
                    Funcionario funcionarioEliminar = (Funcionario)selectedRow.DataBoundItem;

               
                    funcionarioController.eliminarFuncionario(funcionarioEliminar);
                    funcionariosList = funcionarioController.obterListaFuncionarios();
                    dataGridViewfFuncionario.DataSource = funcionariosList;
                    clearText();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para eliminar.", "Eliminação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void clearText()
        {
            tbNome.Text = "";
            tbNIF.Text = "";
            tbUsername.Text = "";
        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }
    }


}

