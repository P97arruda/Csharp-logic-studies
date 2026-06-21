using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Exercicio_Linq
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // carrega departamentos no ComboBox
            var listaDept = from Departamento in dc.Departamentos select Departamento;
            foreach (Departamento d in listaDept)
            {
                comboBoxDepat.Items.Add(d.Sigla);
            }

            CarregaLista();
            AtualizaId();
        }

        private void AtualizaId()
        {
            int proximoId = 1;
            var lista = from Funcionario in dc.Funcionarios select Funcionario;
            foreach (Funcionario funcionario in lista)
            {
                if (funcionario.Id >= proximoId)
                    proximoId = funcionario.Id + 1;
            }
            textBoxId.Text = proximoId.ToString();
        }

        private void CarregaLista()
        {
            listBox1.Items.Clear();

            DataClasses1DataContext dcNovo = new DataClasses1DataContext();
            var lista = from Funcionario in dcNovo.Funcionarios select Funcionario;
            foreach (Funcionario funcionario in lista)
            {
                listBox1.Items.Add(funcionario.Id + " - " + funcionario.Departamento + " - " + funcionario.Nome);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            string item = listBox1.SelectedItem.ToString();
            string[] partes = item.Split('-');
            textBoxId.Text = partes[0].Trim();
            comboBoxDepat.Text = partes[1].Trim();
            textBoxNome.Text = partes[2].Trim();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Funcionario func = null;
            var lista = from Funcionario in dc.Funcionarios select Funcionario;
            foreach (Funcionario f in lista)
            {
                if (f.Id == int.Parse(textBoxId.Text))
                    func = f;
            }

            if (func == null)
            {
                MessageBox.Show("Funcionário não encontrado!");
                return;
            }

            dc.Funcionarios.DeleteOnSubmit(func);
            dc.SubmitChanges();
            CarregaLista();
            AtualizaId();

        }

        private void btnALterar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um funcionário!");
                return;
            }

            int id = int.Parse(textBoxId.Text);
            Form2 form2 = new Form2(id);
            form2.ShowDialog();
            CarregaLista();
            AtualizaId();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int proximoId = 1;
            var lista = from Funcionario in dc.Funcionarios select Funcionario;
            foreach (Funcionario f in lista)
            {
                if (f.Id >= proximoId)
                    proximoId = f.Id + 1;
            }

            Departamento depto = null;
            var listaDept = from Departamento in dc.Departamentos select Departamento;
            foreach (Departamento d in listaDept)
            {
                if (d.Sigla == comboBoxDepat.SelectedItem.ToString())
                    depto = d;
            }

            if (depto == null)
            {
                MessageBox.Show("Departamento não encontrado!");
                return;
            }

            Funcionario funcionario = new Funcionario();
            funcionario.Id = proximoId;
            funcionario.Nome = textBoxNome.Text;
            funcionario.Departamento1 = depto;
            dc.Funcionarios.InsertOnSubmit(funcionario);
            dc.SubmitChanges();
            CarregaLista();
            AtualizaId();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDerpatamentos formdepartamento = new FormDerpatamentos();
            formdepartamento.ShowDialog();

            // recarrega o comboBox depois de fechar o FormDepartamentos
            comboBoxDepat.Items.Clear();
            var listaDept = from Departamento in dc.Departamentos select Departamento;
            foreach (Departamento d in listaDept)
            {
                comboBoxDepat.Items.Add(d.Sigla);
            }
        }
    }
}
