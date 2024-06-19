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
    public partial class ExtrasForm : Form
    {

        ExtrasController extrasController;
        CantinaContext db;
        List<Extra> extrasList = new List<Extra>();
        internal ExtrasForm(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            extrasController = new ExtrasController(db);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbDescricao) && CheckTextBox(tbPreco) == true)
            {
                bool estado;
                if (checkboxAtivo.Checked == true)
                {
                    estado = true;

                }
                else
                {
                    estado = false;
                }

                try
                {
                    extrasController.inserirExtra(tbDescricao.Text, float.Parse(tbPreco.Text), estado);
                    extrasList = extrasController.obterListaExtras();
                    dataGridViewfExtras.DataSource = extrasList;
                    clearText();

                    btneEdite.Enabled = false;
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Introduza um caractere válido");
                }

                
                
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
            tbPreco.Text = "";
        }

       

        private void ExtrasForm_Load(object sender, EventArgs e)
        {
            extrasList = extrasController.obterListaExtras();
            dataGridViewfExtras.DataSource = extrasList;
        }

        private void dataGridViewfExtras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada é válida
            {
                // Obter o Extra selecionado
                Extra extra = (Extra)dataGridViewfExtras.Rows[e.RowIndex].DataBoundItem;

                // Preencher os campos do formulário com os dados do Extra sele cionado
                tbDescricao.Text = extra.Descricao;
                tbPreco.Text = extra.Preco.ToString();
                checkboxAtivo.Checked = extra.Ativo;    

                btneEdite.Enabled = true;
            }
        }

        private void btneEdite_Click_1(object sender, EventArgs e)
        {
            if (CheckTextBox(tbDescricao) && CheckTextBox(tbPreco))
            {
                if (dataGridViewfExtras.SelectedRows.Count > 0)
                {
                    // Obter a linha selecionada
                    DataGridViewRow selectedRow = dataGridViewfExtras.SelectedRows[0];

                    // Obter o objeto Funcionario da linha selecionada
                    Extra extraAntigo = (Extra)selectedRow.DataBoundItem;

                    Extra extraNovo = new Extra
                    {
                        Descricao = tbDescricao.Text,
                        Preco = float.Parse(tbPreco.Text),
                        Ativo = checkboxAtivo.Checked

                    };

                    try 
                    { 
                    extrasController.editarExtra(extraAntigo, extraNovo);

                    // Atualizar a lista de funcionários e a DataGridView
                    extrasList = extrasController.obterListaExtras();
                    dataGridViewfExtras.DataSource = extrasList;

                    btneEdite.Enabled = false;
                    clearText();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Introduza um caractere válido");
                    }



                }
                else
                {
                    MessageBox.Show("Por favor, selecione um extra para editar.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text == "") //caixa de texto vazia, preenche a dataView
            {
                dataGridViewfExtras.DataSource = extrasList;

            }
            // Verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevenir o som do sistema para a tecla Enter
                e.Handled = true;

                // Chamar o método de pesquisa
                var listaFiltrada = extrasList.Where(f => f.Descricao.Equals(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                // Atualizar o DataGridView com a lista filtrada
                dataGridViewfExtras.DataSource = listaFiltrada;

                // Opcional: Mostrar uma mensagem se nenhum resultado for encontrado
                if (listaFiltrada.Count == 0)
                {
                    txtSearch.Text = "";
                    dataGridViewfExtras.DataSource = extrasList;
                    MessageBox.Show("Nenhum prato encontrado.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewfExtras.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja eliminar este extras?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar se o usuário confirmou a deleção
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewfExtras.SelectedRows[0];
                    Extra extraEliminar = (Extra)selectedRow.DataBoundItem;


                    extrasController.eliminarExtra(extraEliminar);
                    extrasList = extrasController.obterListaExtras();
                    dataGridViewfExtras.DataSource = extrasList;
                    clearText();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um prato para eliminar.", "Eliminação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
