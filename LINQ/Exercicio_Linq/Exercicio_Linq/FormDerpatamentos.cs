using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicio_Linq
{
    public partial class FormDerpatamentos : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public FormDerpatamentos()
        {
            InitializeComponent();
        }

        private void FormDerpatamentos_Load(object sender, EventArgs e)
        {
            CarregaLista();
            
        }

        //private void AtualizaId()
        //{
        //    int proximoId = 1;

        //    var lista = from Departamento in dc.Departamentos select Departamento;

        //    foreach (Departamento d in lista)
        //    {
        //        if (d.Id >= proximoId)
        //            proximoId = d.Id + 1;
        //    }

        //    textId.Text = proximoId.ToString();
        //}

        private void CarregaLista()
        {
            listBox1.Items.Clear();

            var lista = from Departamento in dc.Departamentos select Departamento;
            foreach (Departamento d in lista)
            {
                listBox1.Items.Add(d.Sigla + " - " + d.Nome);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textId.Text))
            {
                MessageBox.Show("Preencha a sigla do departamento.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDepartamento.Text))
            {
                MessageBox.Show("Preencha o nome do departamento.");
                return;
            }

            // verifica se a sigla já existe
            var lista = from Departamento in dc.Departamentos select Departamento;
            foreach (Departamento d in lista)
            {
                if (d.Sigla == textId.Text)
                {
                    MessageBox.Show("Já existe um departamento com essa sigla.");
                    return;
                }
            }

            Departamento dep = new Departamento();
            dep.Sigla = textId.Text;
            dep.Nome = textBoxDepartamento.Text;

            dc.Departamentos.InsertOnSubmit(dep);
            dc.SubmitChanges();

            CarregaLista();
            textId.Clear();
            textBoxDepartamento.Clear();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
