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

namespace iCantina.Views
{
    public partial class MultaForm : Form
    {
        MultaController multaController;

        CantinaContext db;
        List<Multa> multasList = new List<Multa>();

        internal MultaForm(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            multaController = new MultaController(db);
        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void MultaForm_Load(object sender, EventArgs e)
        {
            multasList = multaController.obterListaMultas();
            dataGridViewfMulta.DataSource = multasList;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbNumHoras) && CheckTextBox(tbValor) == true)
            {
                multaController.inserirMulta(Convert.ToInt32(tbValor.Text), Convert.ToInt32(tbNumHoras.Text));


                multasList = multaController.obterListaMultas();
                dataGridViewfMulta.DataSource = multasList;
                clearText();

                btneEdite.Enabled = false;

            }
        }

        private void btneEdite_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbNumHoras) && CheckTextBox(tbValor))
            {
                if (dataGridViewfMulta.SelectedRows.Count > 0)
                {
                    // Obter a linha selecionada
                    DataGridViewRow selectedRow = dataGridViewfMulta.SelectedRows[0];

                    // Obter o objeto Funcionario da linha selecionada
                    Multa multaAntiga = (Multa)selectedRow.DataBoundItem;

                    Multa multaNova = new Multa
                    {
                        NumHoras = int.Parse(tbNumHoras.Text),
                        Valor = int.Parse(tbValor.Text),

                    };
                    multaController.editarMulta(multaAntiga, multaNova);

                    // Atualizar a lista de funcionários e a DataGridView
                    multasList = multaController.obterListaMultas();
                    dataGridViewfMulta.DataSource = multasList;

                    btneEdite.Enabled = false;
                    clearText();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um funcionário para editar.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void clearText()
        {
            tbValor.Text = "";
            tbNumHoras.Text = "";
        }

        private bool CheckTextBox(BunifuTextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show(tb.Name + "must be filled");

                return false;
            }


            return true;
        }

        private void dataGridViewfMulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewfMulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada é válida
            {
                // Obter o funcionário selecionado
                Multa multa = (Multa)dataGridViewfMulta.Rows[e.RowIndex].DataBoundItem;

                // Preencher os campos do formulário com os dados do funcionário selecionado
                tbValor.Text = Convert.ToString(multa.Valor);
                tbNumHoras.Text = Convert.ToString(multa.NumHoras);

                btneEdite.Enabled = true;
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewfMulta.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja eliminar esta multa?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar se o usuário confirmou a deleção
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewfMulta.SelectedRows[0];
                    Multa multaEliminar = (Multa)selectedRow.DataBoundItem;


                    multaController.eliminarMulta(multaEliminar);
                    multasList = multaController.obterListaMultas();
                    dataGridViewfMulta.DataSource = multasList;
                    clearText();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma multa para eliminar.", "Eliminação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text == "") //caixa de texto vazia, preenche a dataView
            {
                dataGridViewfMulta.DataSource = multasList;

            }
            // Verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevenir o som do sistema para a tecla Enter
                e.Handled = true;

                // Chamar o método de pesquisa
                var listaFiltrada = multasList.Where(f => Convert.ToString(f.NumHoras).Equals(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                // Atualizar o DataGridView com a lista filtrada
                dataGridViewfMulta.DataSource = listaFiltrada;

                // Opcional: Mostrar uma mensagem se nenhum resultado for encontrado
                if (listaFiltrada.Count == 0)
                {
                    txtSearch.Text = "";
                    dataGridViewfMulta.DataSource = multasList;
                    MessageBox.Show("Nenhuma multa encontrada com o número de horas fornecido.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tbValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
