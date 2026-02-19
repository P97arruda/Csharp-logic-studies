using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExemploFormsApp
{
    public partial class Form2 : Form
    {

        //Criar botões para o ToolStrip
        ToolStripButton btnNew = new ToolStripButton("Novo");
        ToolStripButton btnOpen = new ToolStripButton("Salvar");
        ToolStripButton btnSave = new ToolStripButton("Salvar");

        public Form2()
        {
            //Criar o ToolStrip
            ToolStrip toolStrip1 = new ToolStrip();

            //Adicionar os botões ao ToolStrip
            btnNew.Click += (s, ee) => MessageBox.Show("Novo arquivo criado!");
            btnOpen.Click += (sender, e) => MessageBox.Show("Abrir arquivo!");
            btnSave.Click += (sender, e) => MessageBox.Show("Salvar arquivo!");

            // Adicionar os botões ao ToolStrip

            toolStrip1.Items.Add(btnNew);
            toolStrip1.Items.Add(btnOpen);
            toolStrip1.Items.Add(btnSave);

            // Adicionar o ToolStrip ao formulário

            this.Controls.Add(toolStrip1);


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                textBox1.ForeColor = MyDialog.Color;

            btnNew.Click += (s, ee) => MessageBox.Show("Novo arquivo criado!");

        }

       
    }
}
