using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using iCantina.Controllers;
using iCantina.Model;
using Bunifu.UI.WinForms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCantina.Views
{
    public partial class EstudanteForm : Form
    {
        EstudanteController estudanteController;

        CantinaContext db;
        List<Estudante> estudantesList = new List<Estudante>();


        internal EstudanteForm(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            estudanteController = new EstudanteController(db);
        }
        private void EstudanteForm_Load(object sender, EventArgs e)
        {
            estudantesList = estudanteController.obterListaEstudantes();
            dataGridViewCliente.DataSource = estudantesList;
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbNome) && CheckTextBox(tbNIF) && CheckTextBox(tbNumeroEstudante) && CheckTextBox(tbSaldo)  == true)
            {
                try
                {
                    estudanteController.inserirEstudante(tbNome.Text, float.Parse(tbSaldo.Text), Convert.ToInt32(tbNIF.Text), Convert.ToInt32(tbNumeroEstudante.Text));
                    estudantesList = estudanteController.obterListaEstudantes();
                    dataGridViewCliente.DataSource = estudantesList;
                    clearText();

                    btneEdite.Enabled = false;
                } 
                catch {
                    MessageBox.Show("Dados inválidos! Porfavor verifique os seus dados");
                }





            }
        }
        private bool CheckTextBox(BunifuTextBox tb)
        {
            bool valid = true;
            if (string.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show(tb.Name + "must be filled");

                valid = false;
            }

            return valid;
        }
        private void clearText()
        {
            tbNome.Text = "";
            tbSaldo.Text = "";
            tbNIF.Text = "";
            tbNumeroEstudante.Text = "";
        }
        private void validarNumero(object sender, KeyPressEventArgs e)
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
                dataGridViewCliente.DataSource = estudantesList;

            }
            // Verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevenir o som do sistema para a tecla Enter
                e.Handled = true;

                // Chamar o método de pesquisa
                var listaFiltrada = estudantesList.Where(f => f.Nome.Equals(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                // Atualizar o DataGridView com a lista filtrada
                dataGridViewCliente.DataSource = listaFiltrada;

                // Opcional: Mostrar uma mensagem se nenhum resultado for encontrado
                if (listaFiltrada.Count == 0)
                {
                    txtSearch.Text = "";
                    dataGridViewCliente.DataSource = estudantesList;
                    MessageBox.Show("Nenhum estudante encontrado com o nome fornecido.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridViewCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada é válida
            {
                // Obter o funcionário selecionado
                Estudante estudante = (Estudante)dataGridViewCliente.Rows[e.RowIndex].DataBoundItem;

                // Preencher os campos do formulário com os dados do funcionário selecionado
                tbNome.Text = estudante.Nome;
                tbSaldo.Text = estudante.Saldo.ToString();
                tbNumeroEstudante.Text = estudante.NumEstudante.ToString();
                tbNIF.Text = estudante.NIF.ToString();

                btneEdite.Enabled = true;
            }
        }

        private void btneEdite_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbNome) && CheckTextBox(tbNIF) && CheckTextBox(tbNumeroEstudante))
            {
                if (dataGridViewCliente.SelectedRows.Count > 0)
                {
                    // Obter a linha selecionada
                    DataGridViewRow selectedRow = dataGridViewCliente.SelectedRows[0];

                    // Obter o objeto Funcionario da linha selecionada
                    Estudante estudante = (Estudante)selectedRow.DataBoundItem;

                    Estudante estudanteEdit = new Estudante
                    {
                        Nome = tbNome.Text,
                        Saldo = int.Parse(tbSaldo.Text),
                        NIF = int.Parse(tbNIF.Text),
                        NumEstudante = int.Parse(tbNumeroEstudante.Text)
                    };
                    estudanteController.editarEstudante(estudante, estudanteEdit);

                    // Atualizar a lista de funcionários e a DataGridView
                    estudantesList = estudanteController.obterListaEstudantes();
                    dataGridViewCliente.DataSource = estudantesList;

                    btneEdite.Enabled = false;
                    clearText();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um estudante para editar.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewCliente.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja eliminar este funcionário?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar se o usuário confirmou a deleção
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewCliente.SelectedRows[0];
                    Estudante estudante = (Estudante)selectedRow.DataBoundItem;


                    estudanteController.eliminarEstudante(estudante);
                    estudantesList = estudanteController.obterListaEstudantes();
                    dataGridViewCliente.DataSource = estudantesList;
                    clearText();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um funcionário para eliminar.", "Eliminação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
