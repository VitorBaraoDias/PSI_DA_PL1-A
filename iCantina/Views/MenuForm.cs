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
using Menu = iCantina.Model.Menu;


namespace iCantina.Views
{
    public partial class MenuForm : Form
    {
        List<Menu> menuList = new List<Menu>();
        ExtrasController extrasController;
        PratosController pratosController;
        MenuController menuController;


        DateTime dataAtual;
        bool formdialog = false;

        internal MenuForm(CantinaContext db, bool dialog, DateTime dataRecebida)
        {
            InitializeComponent();
            extrasController = new ExtrasController(db);
            pratosController = new PratosController(db);
            menuController = new MenuController(db);

            //diz se o form atual e uma dialog
            this.formdialog = dialog;
            this.dataAtual = dataRecebida;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

            comboExtras.DataSource = extrasController.obterListaExtrasAtivos();
            //
            comboPratoCarne.DataSource = pratosController.obterListaPratosTipo("carne");
            comboPratoPeixe.DataSource = pratosController.obterListaPratosTipo("peixe");
            comboPratoVegetariano.DataSource = pratosController.obterListaPratosTipo("vegetariano");
            //
            maskBoxData.Text = dataAtual.ToString("dd/MM/yyyy HH:mm");
            //
            if (!formdialog)
            {
                dataGridViewMenus.DataSource = menuController.obterMenusPorData(dataAtual);

            }

            checkDialogForm(formdialog);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (comboExtras.Text != "" && numericExtra.Value > 0)
            {
                //criar objeto quantidaeExtra

                QuantidadeExtra quantidadeExtra = new QuantidadeExtra { Quantidade = (int)numericExtra.Value, Extra = (Extra)comboExtras.SelectedItem };
                QuantidadeExtra ExtraToRemove = new QuantidadeExtra();

                foreach (QuantidadeExtra item in comboExtrasSelect.Items)
                {
                    if (item.Extra == quantidadeExtra.Extra)
                    {
                        quantidadeExtra.Quantidade = item.Quantidade + quantidadeExtra.Quantidade;
                        ExtraToRemove = item;
                    }
                }
                comboExtrasSelect.Items.Remove(ExtraToRemove);
                comboExtrasSelect.Items.Add(quantidadeExtra);
                comboExtrasSelect.SelectedItem = quantidadeExtra;

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

            if (comboExtrasSelect.Text != "")
            {
                //criar objeto quantidaeExtra
                QuantidadeExtra extraQuantidadeSelect = (QuantidadeExtra)comboExtrasSelect.SelectedItem;
                comboExtrasSelect.Items.Remove(extraQuantidadeSelect);
                comboExtrasSelect.Text = "";
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DateTime parsedDate;


            if (CheckTextBox(txtPrecoEstudante) && CheckTextBox(txtPrecoProfessor))
            {
                if (numericPeixe.Value != 0 && numericCarne.Value != 0 && numericVegetariano.Value != 0)
                {
                    // Tenta analisar a data e hora no formato "dd/MM/yyyy HH:mm"
                    if (DateTime.TryParse(maskBoxData.Text, out parsedDate))
                    {
                        //valido
                        //os pratos e a sua quantidade e inserir na lista
                        List<QuantidadePrato> quantidadePratos = new List<QuantidadePrato>{

                        new QuantidadePrato { Prato = (Prato)comboPratoCarne.SelectedItem,Quantidade = (int)numericCarne.Value },
                        new QuantidadePrato { Prato = (Prato)comboPratoPeixe.SelectedItem,Quantidade = (int)numericPeixe.Value },
                        new QuantidadePrato { Prato = (Prato)comboPratoVegetariano.SelectedItem,Quantidade = (int)numericVegetariano.Value },};

                        try
                        {
                            int quantidade = (int)(numericCarne.Value + numericPeixe.Value + numericVegetariano.Value);
                            menuController.inserirMenu(parsedDate, quantidade, float.Parse(txtPrecoEstudante.Text), float.Parse(txtPrecoProfessor.Text), quantidadePratos,comboExtrasSelect.Items.OfType<QuantidadeExtra>().ToList());



                            dataGridViewMenus.DataSource = null;
                            dataGridViewMenus.DataSource = menuController.obterListaMenu();
                            clearText();
                            // se o menu form for um dialog para criacao rapida de menu, insere e fecha
                            if (formdialog)
                            {
                                MessageBox.Show("Menu foi adicionado com sucesso!");
                                this.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Dados invalidos!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Data e hora inválidas!");
                    }
                }
                else
                {
                    MessageBox.Show("Adicione pelo menos 1 prato de carne, 1 de peixe e 1 vegetariano!");
                }

            }
        }
        private bool CheckTextBox(BunifuTextBox tb)
        {
            if (string.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show(tb.Name + "tem de ser preenchido!");

                return false;
            }

            return true;
        }

        private void clearText()
        {
            txtPrecoEstudante.Text = "";
            txtPrecoProfessor.Text = "";
            numericCarne.Value = 0;
            numericPeixe.Value = 0;
            numericVegetariano.Value = 0;
            numericExtra.Value = 0;
            comboExtrasSelect.Items.Clear();
        }

        private void btneEdite_Click(object sender, EventArgs e)
        {
            DateTime parsedDate;

            //checka
            if (CheckTextBox(txtPrecoEstudante) && CheckTextBox(txtPrecoProfessor))
            {
                if (numericPeixe.Value != 0 && numericCarne.Value != 0 && numericVegetariano.Value != 0)
                {


                    // Tenta analisar a data e hora no formato "dd/MM/yyyy HH:mm"
                    if (DateTime.TryParse(maskBoxData.Text, out parsedDate))
                    {
                        //valido
                        //os pratos e a sua quantidade e inserir na lista
                        List<QuantidadePrato> quantidadePratos = new List<QuantidadePrato>
                    {

                        new QuantidadePrato { Prato = (Prato)comboPratoCarne.SelectedItem,Quantidade = (int)numericCarne.Value },
                        new QuantidadePrato { Prato = (Prato)comboPratoPeixe.SelectedItem,Quantidade = (int)numericPeixe.Value },
                        new QuantidadePrato { Prato = (Prato)comboPratoVegetariano.SelectedItem,Quantidade = (int)numericVegetariano.Value },
                    };
                        int quantidade = (int)(numericCarne.Value + numericPeixe.Value + numericVegetariano.Value);



                        if (dataGridViewMenus.SelectedRows.Count > 0)
                        {
                            // Obter a linha selecionada
                            DataGridViewRow selectedRow = dataGridViewMenus.SelectedRows[0];

                            // Obter o objeto menu da linha selecionada
                            Menu menuAntigo = (Menu)selectedRow.DataBoundItem;

                            Menu menuNovo = new Menu
                            {
                                DataHora = parsedDate,
                                QtdDisponivel = quantidade,
                                PrecoEstudante = float.Parse(txtPrecoEstudante.Text),
                                PrecoProfessor = float.Parse(txtPrecoProfessor.Text),
                                QuantidadePrato = quantidadePratos,
                                QuantidadeExtra = comboExtrasSelect.Items.OfType<QuantidadeExtra>().ToList()
                            };
                            menuController.editarMenu(menuAntigo, menuNovo);

                            // Atualizar a lista de funcionários e a DataGridView


                            dataGridViewMenus.DataSource = null;
                            dataGridViewMenus.DataSource = menuController.obterListaMenu();
                            btneEdite.Enabled = false;
                            clearText();

                        }
                        else
                        {
                            MessageBox.Show("Por favor, selecione um prato para editar.", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void dataGridViewMenus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Certifique-se de que a linha clicada é válida
            {
                //block button inserir
                //limpo a lista de extras antiga
                // Obter o funcionário selecionado
                Menu menu = (Menu)dataGridViewMenus.Rows[e.RowIndex].DataBoundItem;

                // Preencher os campos do formulário com os dados do funcionário sele cionado
                maskBoxData.Text = menu.DataHora.ToString();
                txtPrecoEstudante.Text = menu.PrecoEstudante.ToString();
                txtPrecoProfessor.Text = menu.PrecoProfessor.ToString();


                comboPratoCarne.SelectedItem = menu.QuantidadePrato[0].Prato.Descricao;
                numericCarne.Value = menu.QuantidadePrato[0].Quantidade;


                comboPratoPeixe.SelectedItem = menu.QuantidadePrato[1].Prato.Descricao;
                numericPeixe.Value = menu.QuantidadePrato[1].Quantidade;


                comboPratoVegetariano.SelectedItem = menu.QuantidadePrato[2].Prato.Descricao;
                numericVegetariano.Value = menu.QuantidadePrato[2].Quantidade;


                //vou buscar a lista atualizada

                comboExtrasSelect.Items.Clear();
                comboExtrasSelect.Items.AddRange(menu.QuantidadeExtra.ToArray());
                if(comboExtrasSelect.Items.Count > 0)
                {
                    comboExtrasSelect.SelectedIndex = 0;
                }

                btneEdite.Enabled = true;
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja eliminar este menu?", "Confirmar Deleção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar se o usuário confirmou a deleção
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridViewMenus.SelectedRows[0];
                    Menu menuEliminar = (Menu)selectedRow.DataBoundItem;


                    menuController.eliminarMenu(menuEliminar);
                    menuList = menuController.obterListaMenu();
                    dataGridViewMenus.DataSource = menuList;
                    clearText();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um prato para eliminar.", "Eliminação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            menuList = menuController.obterMenusPorData(selectedDate);
            dataGridViewMenus.DataSource = null;
            dataGridViewMenus.DataSource = menuList;
        }

        private void checkDialogForm(Boolean formdialog)
        {
            if (formdialog)
            {
                //alterar ui
                this.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.Width = 340;
                btneEdite.Enabled = false;
                bunifuButton3.Enabled = false;
            }
        }
    }
}


