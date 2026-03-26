using Televisao.Console;

namespace Televisao.Forms
{
    public partial class frmNovaBox : Form
    {
        // Referência ao form1 para atualizar a Box e a interface
        frmPrincial _formPrincipal;

        // Construtor: guarda a referência ao formulario principal 
        public frmNovaBox(frmPrincial principal)
        {
            InitializeComponent();
            _formPrincipal = principal;
        }
        
        // Fecha o formulário sem guardar alterações 
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Valida os dados, cria a nova Box a atualiza o formulario principal
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Validação: número de canais obrigatório
            if (numericUpDownCanais.Value <= 0)
            {
                MessageBox.Show("Tem que escolher um numero Total de canais", "Faltam dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            
            // Não é possivel criar uma nova Box enquanto a atual estiver ligada
            if (_formPrincipal.Meo != null && _formPrincipal.Meo.Estado)
            {
                MessageBox.Show("Tem que primeiro desligar a box, para poder criar outra");
                return;
            }
            
            //Criara o nova Box com número de canais indicado e atualiza o formulário principal
            Box novaBox = new Box();
            novaBox.NumeroCanais = Convert.ToInt16(numericUpDownCanais.Value);

            _formPrincipal.Meo = novaBox;

            _formPrincipal.AtualizarTotalCanais(novaBox.NumeroCanais);

            //_formPrincipal.Meo = new Box(Convert.ToInt16(numericUpDownCanais.Value));

            MessageBox.Show("Nova Box criada com " + numericUpDownCanais.Value + " canais.",
            "Nova Box", MessageBoxButtons.OK, MessageBoxIcon.Information);




            this.Close();
        }
    }
}
