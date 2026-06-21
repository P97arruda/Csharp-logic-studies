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

        

        private void CarregaLista()
        {
            listBox1.Items.Clear();

            DataClasses1DataContext dcNovo = new DataClasses1DataContext();
            var lista = from Departamento in dcNovo.Departamentos select Departamento;
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
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um departamento para editar.");
                return;
            }

            // pega a sigla directamente do listBox, não do textId
            string item = listBox1.SelectedItem.ToString();
            string[] partes = item.Split('-');
            string sigla = partes[0].Trim();

            FormEditarDepartamento formEditar = new FormEditarDepartamento(this, sigla);
            formEditar.ShowDialog();
            CarregaLista();
            textId.Clear();
            textBoxDepartamento.Clear();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecione um departamento para apagar.");
                return;
            }

            // verifica se existe algum funcionário ligado a este departamento
            var listaFunc = from Funcionario in dc.Funcionarios select Funcionario;
            foreach (Funcionario f in listaFunc)
            {
                if (f.Departamento == textId.Text)
                {
                    MessageBox.Show("Não é possível apagar este departamento pois tem funcionários associados.");
                    return;
                }
            }

            DialogResult res = MessageBox.Show(
                "Tem a certeza que deseja apagar o departamento \"" + textId.Text + "\"?",
                "Confirmar",
                MessageBoxButtons.OKCancel
            );

            if (res == DialogResult.OK)
            {
                var lista = from Departamento in dc.Departamentos select Departamento;
                foreach (Departamento d in lista)
                {
                    if (d.Sigla == textId.Text)
                    {
                        dc.Departamentos.DeleteOnSubmit(d);
                        break;
                    }
                }

                dc.SubmitChanges();
                CarregaLista();
                textId.Clear();
                textBoxDepartamento.Clear();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;

            string item = listBox1.SelectedItem.ToString();
            string[] partes = item.Split('-');
            textId.Text = partes[0].Trim();
            textBoxDepartamento.Text = partes[1].Trim();

        }
    }
}
