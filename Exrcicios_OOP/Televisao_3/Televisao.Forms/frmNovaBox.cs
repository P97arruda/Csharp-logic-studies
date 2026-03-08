using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Televisao.Console;

namespace Televisao.Forms
{
    public partial class frmNovaBox : Form
    {
         frmPrincial  _formPrincipal;

        public frmNovaBox(frmPrincial principal)
        {
            InitializeComponent();
           _formPrincipal = principal;
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(numericUpDownCanais.Value <= 0)
            {
                MessageBox.Show("Tem que escolher um numero Total de canais", "Faltam dados", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            // se a outra box estiver ligar 
            //aviso para desligar e só depois é que 
            //aceito uma nova com o número de canais pretendidos 

            if(_formPrincipal.Meo != null && _formPrincipal.Meo.Estado)
            {
                MessageBox.Show("Tem que primeiro desligar a box, para poder criar outra");
                return;
            }

            //Criara o nova tv com os canis 

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
