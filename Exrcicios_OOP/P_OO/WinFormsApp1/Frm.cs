using Exemplo_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    
    public partial class Frm : Form
    {
        Carro _boguinhas;
        public Frm(Carro carrinho)
        {
            _boguinhas = carrinho;
            InitializeComponent();
            numericUpDownVelocidade.Value = _boguinhas.VelocidadeMaxima;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _boguinhas.VelocidadeMaxima = Convert.ToInt32(numericUpDownVelocidade.Value);
            this.Close();

        }
    }
}
