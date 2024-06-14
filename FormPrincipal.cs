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
    public partial class Form1 : Form
    {
        //Instanciar o contexto da base de dados
        CantinaContext db = new CantinaContext();

        Dictionary<string, Form> dicionario = new Dictionary<string, Form>();


        public Form1()
        {

            InitializeComponent();

            dicionario.Add("Funcionários", new FuncionarioForm(db));
            
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
