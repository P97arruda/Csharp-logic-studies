using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Exercicio_Linq
{
    public partial class FormEditarDepartamento : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();

        private FormDerpatamentos _departa;
        private string _sigla;
        public FormEditarDepartamento(FormDerpatamentos departa, string sigla)
        {
            InitializeComponent();
            _departa = departa;
            _sigla = sigla;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDepartamento.Text))
            {
                MessageBox.Show("Preencha o nome do departamento.");
                return;
            }

            var listaDept = from Departamento in dc.Departamentos select Departamento;
            foreach (Departamento d in listaDept)
            {
                if (d.Sigla == _sigla)
                {
                    d.Nome = textBoxDepartamento.Text;
                    break;
                }
            }

            dc.SubmitChanges();
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarDepartamento_Load(object sender, EventArgs e)
        {
            var lista = from Departamento in dc.Departamentos select Departamento;
            foreach (Departamento d in lista)
            {
                if (d.Sigla == _sigla)
                {
                    texSigla.Text = d.Sigla;
                    textBoxDepartamento.Text = d.Nome;
                }
            }

            // sigla não pode ser alterada
            texSigla.ReadOnly = true;

        }
    }
}
