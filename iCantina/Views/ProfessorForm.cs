using iCantina.Controllers;
using iCantina.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;


namespace iCantina.Views
{
    public partial class ProfessorForm : Form
    {
        ProfessorController professorController;

        CantinaContext db;
        List<Professor> professorList = new List<Professor>();

        internal ProfessorForm(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            professorController = new ProfessorController(db);
        }

        private void ProfessorForm_Load(object sender, EventArgs e)
        {
            professorList = professorController.obterListaProfessor();
            dataGridViewProfessores.DataSource = professorList;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbNome) && CheckTextBox(tbNIF) && CheckTextBox(tbEmail) && CheckTextBox(tbSaldo) == true)
            {
                if (IsValidEmail(tbEmail.Text)){

                    try
                    {
                        professorController.inserirProfessor(tbNome.Text, float.Parse(tbSaldo.Text), Convert.ToInt32(tbNIF.Text), tbEmail.Text);

                        professorList = professorController.obterListaProfessor();
                        dataGridViewProfessores.DataSource = professorList;
                        clearText();
                        btneEdite.Enabled = false;
                    }
                    catch {
                        MessageBox.Show("Dados inválidos! Porfavor verifique os seus dados");
                    }




                    
                }
                else
                {

                    MessageBox.Show("Formato de email inválido", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void clearText()
        {
            tbNome.Text = "";
            tbSaldo.Text = "";
            tbNIF.Text = "";
            tbEmail.Text = "";
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
        private bool IsValidEmail(string email)
        {
            bool valido = false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (string.IsNullOrWhiteSpace(email))
            {
                valido = false;

            }
            Regex regex = new Regex(pattern);
            valido = regex.IsMatch(email);

            return valido;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSearch.Text == "") //caixa de texto vazia, preenche a dataView
            {
                dataGridViewProfessores.DataSource = professorList;

            }
            // Verifica se a tecla pressionada é Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Prevenir o som do sistema para a tecla Enter
                e.Handled = true;

                // Chamar o método de pesquisa
                var listaFiltrada = professorList.Where(f => f.Nome.Equals(txtSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();

                // Atualizar o DataGridView com a lista filtrada
                dataGridViewProfessores.DataSource = listaFiltrada;

                // Opcional: Mostrar uma mensagem se nenhum resultado for encontrado
                if (listaFiltrada.Count == 0)
                {
                    txtSearch.Text = "";
                    dataGridViewProfessores.DataSource = professorList;
                    MessageBox.Show("Nenhum professor encontrado com o nome fornecido.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridViewProfessores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada é válida
            {
                // Obter o funcionário selecionado
                Professor professor = (Professor)dataGridViewProfessores.Rows[e.RowIndex].DataBoundItem;

                // Preencher os campos do formulário com os dados do funcionário selecionado
                tbNome.Text = professor.Nome;
                tbSaldo.Text = professor.Saldo.ToString();
                tbEmail.Text = professor.Email;
                tbNIF.Text = professor.NIF.ToString();

                btneEdite.Enabled = true;
            }
        }

        private void btneEdite_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(tbNome) && CheckTextBox(tbNIF) && CheckTextBox(tbSaldo) && CheckTextBox(tbEmail))
            {
                if (dataGridViewProfessores.SelectedRows.Count > 0)
                {
                    // Obter a linha selecionada
                    DataGridViewRow selectedRow = dataGridViewProfessores.SelectedRows[0];
                    Professor professorAntigo = (Professor)selectedRow.DataBoundItem;

                    Professor professorEdit = new Professor
                    {
                        Nome = tbNome.Text,
                        Saldo = int.Parse(tbSaldo.Text),
                        NIF = int.Parse(tbNIF.Text),
                        Email = tbEmail.Text
                    };
                    professorController.editarProfessor(professorAntigo, professorEdit);

                    // Atualizar a lista de funcionários e a DataGridView
                    professorList = professorController.obterListaProfessor();
                    dataGridViewProfessores.DataSource = professorList;

                    btneEdite.Enabled = false;
                    clearText();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um professor para editar.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewProfessores.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja eliminar este professor?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar se o usuário confirmou a deleção
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewProfessores.SelectedRows[0];
                    Professor professor = (Professor)selectedRow.DataBoundItem;


                    professorController.eliminarProfessor(professor);
                    professorList = professorController.obterListaProfessor();
                    dataGridViewProfessores.DataSource = professorList;
                    clearText();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um professor para eliminar.", "Eliminação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
