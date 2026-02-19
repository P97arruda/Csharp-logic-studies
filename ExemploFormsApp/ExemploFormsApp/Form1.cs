using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploFormsApp
{
    public partial class frmPrincial : Form
    {
        int conta = 0;
        public frmPrincial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Ola mundo, ja carregou no button!";
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            conta++;
            label1.Text = $"Clicou {conta} vezes.";
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            lblNomeCompleto.Text = $" Olá {txtNome.Text} , Bem vindo ao winforms"; 
            LimpaCaixasDeTextoNomeEApelido();

        }

        private void LimpaCaixasDeTextoNomeEApelido()
        {
            txtNome.Text = string.Empty;
            
        }
    }
}
