using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectBalao
{
    public partial class FormEscolherBalao : Form
    {
        Form1 _formPrinciapal;
        public FormEscolherBalao(Form1 princiapl)
        {
            InitializeComponent();
            _formPrinciapal = princiapl;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
