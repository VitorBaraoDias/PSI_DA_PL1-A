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
using Bunifu.UI.WinForms;


namespace iCantina.Views
{
    public partial class PratosForm : Form
    {
        PratosController pratoController;

        CantinaContext db;
        List<Prato> pratosList = new List<Prato>();
        internal PratosForm(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            pratoController = new PratosController(db);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbDescricao) == true && comboBoxTipo.Text != "" )
            {
                bool estado;
                if (checkboxAtivo.Checked == true)
                {
                    estado = true;

                } else
                {
                    estado = false;
                }


                pratoController.inserirPrato(tbDescricao.Text, comboBoxTipo.Text, estado);


                pratosList = pratoController.obterListaPratos();
                dataGridViewfPrato.DataSource = pratosList;
                clearText();

                btneEdite.Enabled = false;

            }
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


        private void clearText()
        {
            tbDescricao.Text = "";
            comboBoxTipo.Text = "";
        }

        private void btneEdite_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbDescricao) && comboBoxTipo.Text != "")
            {
                if (dataGridViewfPrato.SelectedRows.Count > 0)
                {
                    // Obter a linha selecionada
                    DataGridViewRow selectedRow = dataGridViewfPrato.SelectedRows[0];

                    // Obter o objeto Funcionario da linha selecionada
                    Prato pratoAntigo = (Prato)selectedRow.DataBoundItem;

                    Prato pratoNovo = new Prato
                    {
                        Descricao = tbDescricao.Text,
                        Tipo = comboBoxTipo.Text,
                        Ativo = checkboxAtivo.Checked
                    };
                    pratoController.editarPrato(pratoAntigo, pratoNovo);

                    // Atualizar a lista de funcionários e a DataGridView
                    pratosList = pratoController.obterListaPratos();
                    dataGridViewfPrato.DataSource = pratosList;

                    btneEdite.Enabled = false;
                    clearText();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um prato para editar.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void PratosForm_Load_1(object sender, EventArgs e)
        {
            pratosList = pratoController.obterListaPratos();
            dataGridViewfPrato.DataSource = pratosList;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text == "") //caixa de texto vazia, preenche a dataView
            {
                dataGridViewfPrato.DataSource = pratosList;

            }
            // Verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevenir o som do sistema para a tecla Enter
                e.Handled = true;

                // Chamar o método de pesquisa
                var listaFiltrada = pratosList.Where(f => f.Descricao.Equals(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                // Atualizar o DataGridView com a lista filtrada
                dataGridViewfPrato.DataSource = listaFiltrada;

                // Opcional: Mostrar uma mensagem se nenhum resultado for encontrado
                if (listaFiltrada.Count == 0)
                {
                    txtSearch.Text = "";
                    dataGridViewfPrato.DataSource = pratosList;
                    MessageBox.Show("Nenhum prato encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewfPrato.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja eliminar este prato?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar se o usuário confirmou a deleção
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewfPrato.SelectedRows[0];
                    Prato pratoEliminar = (Prato)selectedRow.DataBoundItem;


                    pratoController.eliminarPrato(pratoEliminar);
                    pratosList = pratoController.obterListaPratos();
                    dataGridViewfPrato.DataSource = pratosList;
                    clearText();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um prato para eliminar.", "Eliminação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewfPrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada é válida
            {
                // Obter o funcionário selecionado
                Prato prato = (Prato)dataGridViewfPrato.Rows[e.RowIndex].DataBoundItem;

                // Preencher os campos do formulário com os dados do funcionário sele cionado
                tbDescricao.Text = prato.Descricao;
                comboBoxTipo.Text = prato.Tipo;
                checkboxAtivo.Checked = prato.Ativo;


                btneEdite.Enabled = true;
            }
        }

        
    }
}
