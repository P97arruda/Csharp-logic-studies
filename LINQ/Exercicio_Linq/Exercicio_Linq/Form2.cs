using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Exercicio_Linq
{
    public partial class Form2 : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        int _id;
        public Form2(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // carrega departamentos no ComboBox
            var listaDept = from Departamento in dc.Departamentos select Departamento;
            foreach (Departamento d in listaDept)
            {
                comboBoxDepat.Items.Add(d.Sigla);
            }

            // carrega os dados do funcionário
            var lista = from Funcionario in dc.Funcionarios select Funcionario;
            foreach (Funcionario f in lista)
            {
                if (f.Id == _id)
                {
                    textBoxId.Text = f.Id.ToString();
                    textBoxNome.Text = f.Nome;
                    comboBoxDepat.Text = f.Departamento;
                }
            }

            textBoxId.ReadOnly = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var lista = from Funcionario in dc.Funcionarios select Funcionario;
            foreach (Funcionario func in lista)
            {
                if (func.Id == _id)
                {
                    func.Nome = textBoxNome.Text;
                    func.Departamento = comboBoxDepat.SelectedItem.ToString();
                }
            }
            dc.SubmitChanges();
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
