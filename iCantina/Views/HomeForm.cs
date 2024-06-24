using iCantina.Controllers;
using iCantina.Model;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Menu = iCantina.Model.Menu;

namespace iCantina.Views
{
    public partial class HomeForm : Form
    {
        CantinaContext db;
        MenuController menuController;
        List<Menu> menuList = new List<Menu>();

        //Controllers

        EstudanteController estudanteController;
        ProfessorController professorController;
        ReservasController reservasController;
        MultaController multaController;
        FaturaController faturaController;


        //menu
        Menu menu;
        internal HomeForm(CantinaContext db)
        {
            InitializeComponent();
            this.db = db;
            menuController = new MenuController(db);
            estudanteController = new EstudanteController(db);
            professorController = new ProfessorController(db);
            reservasController = new ReservasController(db);
            multaController = new MultaController(db);
            faturaController = new FaturaController(db);

        }

        private void ReservasForm_Load(object sender, EventArgs e)
        {
            menuList = menuController.obterListaMenu();
            MarcarDias(menuList.Select(menu => menu.DataHora.Date).ToList());
        }

        private void MarcarDias(List<DateTime> dias)
        {
            foreach (var dia in dias)
            {
                monthCalendar1.BoldedDates = monthCalendar1.BoldedDates.Concat(new[] { dia }).ToArray();
            }
        }
        private void ExibirDetalhesMenu(Menu menu)
        {
            this.menu = menu;
            setCombos();
            txtPrecoCliente.Text = "";
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            clearText();

            // Obter a data selecionada
            DateTime selectedDate = e.Start;

            // Verificar se a data selecionada está na lista de datas marcadas
            if (monthCalendar1.BoldedDates.Contains(selectedDate))
            {

                // Aqui você pode adicionar a lógica desejada, por exemplo, exibir detalhes do menu
                Menu menuSelecionado = menuList.FirstOrDefault(menu => menu.DataHora.Date == selectedDate.Date);
                if (menuSelecionado != null && menuSelecionado.QtdDisponivel > 0 && DateTime.Now.Date <= menuSelecionado.DataHora.Date)
                {
                    // Exibir detalhes do menu selecionado
                    ExibirDetalhesMenu(menuSelecionado);
                }
                else
                {
                    menuInvalido(menuSelecionado);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja adicionar um menu para a data:" + selectedDate.Date.ToString() + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //se nao tiver um menu permite a criacao 
                    MenuForm menuForm = new MenuForm(db, true, selectedDate.Date);
                    menuForm.ShowDialog();
                    atualizaCalendarView_();
                }
            }
        }
        private void menuInvalido(Menu menuSelecionado)
        {
            if (menuSelecionado != null && menuSelecionado.QtdDisponivel == 0)
            {
                MessageBox.Show("Os menus estão esgotados!");
            }
            else
            {
                MessageBox.Show("O menu já não é mais válido para reservar!");
            }
        }
        //dispara quando o form for fechadp
        private void atualizaCalendarView_()
        {
            MessageBox.Show("O formulário menu foi fechado!");
            menuList = menuController.obterListaMenu();
            MarcarDias(menuList.Select(menu => menu.DataHora.Date).ToList());

        }
        private void comboTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboClientes.Items.Clear();
            lblSaldo.Visible = false;

            if (comboTipoCliente.SelectedItem.ToString() == "Professor")
            {
                comboClientes.Items.AddRange(professorController.obterListaProfessor().ToArray());
                txtPrecoCliente.Text = menu.PrecoProfessor.ToString();
            }
            else if (comboTipoCliente.SelectedItem.ToString() == "Estudante")
            {
                comboClientes.Items.AddRange(estudanteController.obterListaEstudantes().ToArray());
                txtPrecoCliente.Text = menu.PrecoEstudante.ToString();
            }

            //
        }
        private void setCombos()
        {
            //set comboExtras
            comboExtras.Items.Clear();
            comboExtras.Items.AddRange(menu.QuantidadeExtra.FindAll(qe => qe.Quantidade != 0).ToArray());
            //set comboPrato
            comboPrato.Items.Clear();
            comboPrato.Items.AddRange(menu.QuantidadePrato.FindAll(qp => qp.Quantidade != 0).ToArray());

            if (comboExtras.Items.Count > 0) comboExtras.SelectedIndex = 0;
            if (comboPrato.Items.Count > 0) comboPrato.SelectedIndex = 0;
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)comboClientes.SelectedItem;
            lblSaldo.Visible = true;
            lblSaldo.Text = "Saldo do cliente: " + cliente.Saldo.ToString() + "€";
        }

        private void HomeForm_Activated(object sender, EventArgs e)
        {
            menuList = menuController.obterListaMenu();
            MarcarDias(menuList.Select(menu => menu.DataHora.Date).ToList());
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            //so consegue realizar a reserva se for no proprio dia ou em dias anteriores
            if (DateTime.Now.Date <= menu.DataHora.Date)
            {
                if (CheckComboBox(comboPrato) && CheckComboBox(comboTipoCliente) && CheckComboBox(comboClientes))
                {
                    Cliente cliente = (Cliente)comboClientes.SelectedItem;

                    if (!reservasController.verificarReservaCliente(cliente, menu))
                    {
                        processarReserva(cliente);
                    }
                    else
                    {
                        MessageBox.Show("O cliente nãp pode reservar duas vezes o mesmo menu!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os dados!");

                }
            }
            else
            {
                MessageBox.Show("Já não é possível efetuar uma reserva para este dia!");
            }

        }
        private void processarReserva(Cliente cliente)
        {
            if (cliente.Saldo >= float.Parse(txtPrecoCliente.Text))
            {
                Prato prato = ((QuantidadePrato)comboPrato.SelectedItem).Prato;
                List<Extra> extras = comboExtrasSelect.Items.OfType<Extra>().ToList();
                Multa multa = getMulta();

                Reserva reserva =  reservasController.inserirReservas(cliente, menu, prato, extras, multa);
                Menu menuAtualizado = updateQuantidateExtras_Prato(reserva.Menu, reserva.Extras);
                updateSaldo_gerarTalao(cliente, menuAtualizado, prato, extras, multa);

                //gearfatura
                generatePdf(faturaController.inserirFatura(reserva, getPrecoTotalReserva(reserva)));

                clearText();
                MessageBox.Show("Reserva efetuada!");
            }
            else
            {
                MessageBox.Show("Saldo insuficiente!");
            }
        }
        private Menu updateQuantidateExtras_Prato(Menu menuAtualizado, List<Extra> extras)
        {

            QuantidadePrato pratoAtualizado = (QuantidadePrato)comboPrato.SelectedItem;
            //vai buscar o obj quantidadePrato na lista e vai subtrair a quantidade
            menuAtualizado.QuantidadePrato.FirstOrDefault(p => p.Prato == pratoAtualizado.Prato).Quantidade -= 1;
            //percorrer a lista e fazer a soma da quantidade de pratos que existem
            menuAtualizado.QtdDisponivel = menuAtualizado.QuantidadePrato.Select(q => q.Quantidade).Sum();

            //PRECISO BUSCAR os extras que foram selecionados e subtrair a quantidade de extras no menu atualizado
            foreach (var extraSelecionado in extras)
            {
                menuAtualizado.QuantidadeExtra.FirstOrDefault(qe => qe.Extra.Id == extraSelecionado.Id).Quantidade -= 1;
            }

            menuController.editarMenu(menu, menuAtualizado);

            return menuAtualizado;
        }
        private void updateSaldo_gerarTalao(Cliente cliente, Menu menuAtualizado, Prato prato, List<Extra> extras, Multa multa)
        {
            float precoExtras = extras.Sum(q => q.Preco);
            float valorMulta = 0;

            if (multa != null)
            {
                valorMulta = multa.Valor;
            }
            if (comboTipoCliente.SelectedItem.ToString() == "Professor")
            {
                updateProfessorSaldo(menuAtualizado, precoExtras, multa);
                gerarTalao(cliente, "Professor", menuAtualizado, prato, extras, (menuAtualizado.PrecoProfessor + precoExtras + valorMulta), valorMulta);
            }
            else if (comboTipoCliente.SelectedItem.ToString() == "Estudante")
            {
                updateEstudanteSaldo(menuAtualizado, precoExtras, multa);
                gerarTalao(cliente, "Estudante", menuAtualizado, prato, extras, (menuAtualizado.PrecoEstudante + precoExtras + valorMulta), valorMulta);

            }
        }
        private void updateProfessorSaldo(Menu menuAtualizado, float precoExtras, Multa multa)
        {
            float valorMulta = 0;

            if (multa != null)
            {
                valorMulta = multa.Valor;
            }
            Professor professor = (Professor)comboClientes.SelectedItem;
            professor.Saldo -= (menuAtualizado.PrecoProfessor + precoExtras + valorMulta);
            professorController.editarProfessor(professor, professor);
        }

        private void updateEstudanteSaldo(Menu menuAtualizado, float precoExtras, Multa multa)
        {
            float valorMulta = 0;

            if (multa != null)
            {
                valorMulta = multa.Valor;
            }

            Estudante estudante = (Estudante)comboClientes.SelectedItem;
            estudante.Saldo -= (menuAtualizado.PrecoEstudante + precoExtras + valorMulta);
            estudanteController.editarEstudante(estudante, estudante);
        }
        private void btnAddExtras_Click(object sender, EventArgs e)
        {
            //so pode inserir se o extra for menor ou igual há quantidade disponivel e enquanto tiver selecioado menos de 3 extras
            if (comboExtras.Text != "" && comboExtrasSelect.Items.Count < 3)
            {
                QuantidadeExtra quantidadeExtra = new QuantidadeExtra { Quantidade = 1, Extra = ((QuantidadeExtra)comboExtras.SelectedItem).Extra };

                if (!comboExtrasSelect.Items.Contains(quantidadeExtra.Extra))
                {
                    comboExtrasSelect.Items.Add(quantidadeExtra.Extra);
                    comboExtrasSelect.SelectedItem = quantidadeExtra.Extra;
                }

            }
            else
            {
                MessageBox.Show("Não pode exceder os extras possíveis!");

            }
        }
        private void btnRemoveExtra_Click(object sender, EventArgs e)
        {
            if (comboExtrasSelect.Text != "")
            {
                //criar objeto quantidaeExtra
                Extra extra = (Extra)comboExtrasSelect.SelectedItem;
                comboExtrasSelect.Items.Remove(extra);
                comboExtrasSelect.Text = "";
            }
        }
        private bool CheckComboBox(ComboBox cb)
        {
            if (string.IsNullOrEmpty(cb.Text))
            {
                MessageBox.Show(cb.Name + "tem de ser preenchido!");

                return false;
            }

            return true;
        }
        private Multa getMulta()
        {
            Multa multa = null;

            // Se o dia for igual ao dia do menu e se a hora da reserva for superior à hora do menu, verificar o valor da multa
            if (DateTime.Now.Date == menu.DataHora.Date && DateTime.Now.Hour > menu.DataHora.Hour)
            {
                int difHora = DateTime.Now.Hour - menu.DataHora.Hour;

                List<Multa> multas = multaController.obterListaMultas();
                // Encontra a multa correspondente à diferença de horas
                multa = multas.FirstOrDefault(m => m.NumHoras == difHora);

                if (multa == null)
                {
                    MessageBox.Show("Não foi encontrada nenhuma multa para a diferença de horas especificada.");
                }
            }
            return multa;
        }
        private void clearText()
        {
            comboClientes.Items.Clear();
            comboPrato.Items.Clear();
            comboExtrasSelect.Items.Clear();
            comboExtras.Items.Clear();

            txtPrecoCliente.Clear();
            lblSaldo.Text = "Saldo do Cliente: 0€";
        }


        //ficheiros

        private void gerarTalao(Cliente cliente, string tipoCliente, Menu menuAtualizado, Prato prato, List<Extra> extras, float total, float valorMulta)
        {
            string nomeFicheiro = "Talao_" + cliente.Nome + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            //enviar para area de trabalho
            string caminhoFicheiro = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nomeFicheiro);

            using (StreamWriter sw = new StreamWriter(caminhoFicheiro))
            {
                sw.WriteLine("-------- Talão de Reserva --------");
                sw.WriteLine("Cliente:" + cliente.Nome);
                sw.WriteLine("Tipo:" + tipoCliente);
                sw.WriteLine("Menu:" + menu.Id);
                sw.WriteLine("Data e Hora:" + menu.DataHora);
                sw.WriteLine("Prato: " + prato.Descricao);
                sw.WriteLine("Extras:");
                sw.WriteLine("Valor da multa:" + valorMulta);

                foreach (var extra in extras)
                {
                    sw.WriteLine(" - " + extra.Descricao);
                }
                sw.WriteLine("----------------------------------");
                sw.WriteLine($"Total: " + total);
            }
            MessageBox.Show("Talão salvo em:" + caminhoFicheiro);
        } 
        private void generatePdf(Fatura fatura)
        {
            string nomeFicheiro = "reserva_" + fatura.Cliente.Nome + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";
            string caminhoFicheiro = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nomeFicheiro);

            // Cria um novo documento PDF
            PdfDocument pdfDocument = new PdfDocument(new PdfWriter(caminhoFicheiro));
            Document document = new Document(pdfDocument);
            PdfFont titleFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont normalFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            Paragraph title = new Paragraph("Detalhes da Reserva").SetFont(titleFont).SetFontSize(18).SetTextAlignment(TextAlignment.CENTER);
            document.Add(title);

            Paragraph cliente = new Paragraph("Cliente: " + fatura.Cliente.Nome).SetFont(titleFont).SetFontSize(18).SetTextAlignment(TextAlignment.CENTER);
            document.Add(cliente); 

            foreach (ItemFatura itemFatura in fatura.ItemsFatura)
            {
                Paragraph detalhes = new Paragraph(itemFatura.Descricao + " " + itemFatura.Preco + "€")
                .SetFont(normalFont)
                .SetFontSize(12);
                document.Add(detalhes);
            }

            Paragraph detalhesFinais = new Paragraph("Total: " + fatura.Total + "€").SetFont(normalFont).SetFontSize(12);
            document.Add(detalhesFinais);

            document.Close();
            MessageBox.Show("Detalhes da reserva foi guardada em pdf no caminho!" + caminhoFicheiro);

        }
        
        //funcao aux

        private float getPrecoTotalReserva(Reserva reserva){
            float valorMulta = 0;
            float precoTipoMenu = 0;
            float precoExtras = reserva.Extras.Sum(q => q.Preco);

            if (reserva.Multa != null)
            {
                valorMulta = reserva.Multa.Valor;
            }
            if (reserva.Cliente is Professor)
            {
                precoTipoMenu = menu.PrecoProfessor;
            }
            else if (reserva.Cliente is Estudante)
            {
                precoTipoMenu = menu.PrecoEstudante;
            }

            return precoTipoMenu + valorMulta + precoExtras;
        }


    }
}

