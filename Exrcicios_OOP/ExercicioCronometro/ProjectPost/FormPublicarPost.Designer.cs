namespace ProjectPost
{
    partial class FormPublicarPost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTitulo = new TextBox();
            textBoxDescricao = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnPublicar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(50, 49);
            textBoxTitulo.Multiline = true;
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(714, 93);
            textBoxTitulo.TabIndex = 0;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(50, 186);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(714, 163);
            textBoxDescricao.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(50, 16);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 2;
            label1.Text = "Titulo do Post:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(58, 156);
            label2.Name = "label2";
            label2.Size = new Size(192, 28);
            label2.TabIndex = 3;
            label2.Text = "Descrição do post: ";
            // 
            // btnPublicar
            // 
            btnPublicar.BackColor = Color.Red;
            btnPublicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPublicar.Location = new Point(625, 396);
            btnPublicar.Name = "btnPublicar";
            btnPublicar.Size = new Size(139, 42);
            btnPublicar.TabIndex = 4;
            btnPublicar.Text = "Publicar Post";
            btnPublicar.UseVisualStyleBackColor = false;
            btnPublicar.Click += btnPublicar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.Location = new Point(461, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 42);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormPublicarPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnPublicar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDescricao);
            Controls.Add(textBoxTitulo);
            Name = "FormPublicarPost";
            Text = "FormPublicarPost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitulo;
        private TextBox textBoxDescricao;
        private Label label1;
        private Label label2;
        private Button btnPublicar;
        private Button btnCancelar;
    }
}