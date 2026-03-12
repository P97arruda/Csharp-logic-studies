namespace ProjectBalao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIniciaBalao = new Button();
            pictureBox1 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            btnCima = new Button();
            btnDireita = new Button();
            btnEsquerda = new Button();
            btnBaixo = new Button();
            lblCorAtual = new Label();
            lblDirecaoAltural = new Label();
            lblAtitudeAtual = new Label();
            btnAlterarCor = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnIniciaBalao
            // 
            btnIniciaBalao.BackColor = Color.FromArgb(0, 192, 192);
            btnIniciaBalao.Location = new Point(653, 517);
            btnIniciaBalao.Name = "btnIniciaBalao";
            btnIniciaBalao.Size = new Size(193, 45);
            btnIniciaBalao.TabIndex = 1;
            btnIniciaBalao.Text = "Iniciar balão";
            btnIniciaBalao.UseVisualStyleBackColor = false;
            btnIniciaBalao.Click += btnIniciaBalao_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vermelho;
            pictureBox1.Location = new Point(242, 432);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 130);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(706, 167);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // btnCima
            // 
            btnCima.BackColor = Color.FromArgb(192, 255, 255);
            btnCima.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCima.Location = new Point(706, 108);
            btnCima.Name = "btnCima";
            btnCima.Size = new Size(65, 53);
            btnCima.TabIndex = 4;
            btnCima.Text = "↑";
            btnCima.UseVisualStyleBackColor = false;
            // 
            // btnDireita
            // 
            btnDireita.BackColor = Color.FromArgb(128, 255, 255);
            btnDireita.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDireita.Location = new Point(777, 158);
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(69, 42);
            btnDireita.TabIndex = 5;
            btnDireita.Text = "→";
            btnDireita.UseVisualStyleBackColor = false;
            // 
            // btnEsquerda
            // 
            btnEsquerda.BackColor = Color.FromArgb(128, 255, 255);
            btnEsquerda.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEsquerda.Location = new Point(634, 160);
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(66, 44);
            btnEsquerda.TabIndex = 6;
            btnEsquerda.Text = "← ";
            btnEsquerda.UseVisualStyleBackColor = false;
            // 
            // btnBaixo
            // 
            btnBaixo.BackColor = Color.FromArgb(128, 255, 255);
            btnBaixo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBaixo.Location = new Point(706, 209);
            btnBaixo.Name = "btnBaixo";
            btnBaixo.Size = new Size(65, 51);
            btnBaixo.TabIndex = 7;
            btnBaixo.Text = "↓";
            btnBaixo.UseVisualStyleBackColor = false;
            btnBaixo.Click += btnBaixo_Click;
            // 
            // lblCorAtual
            // 
            lblCorAtual.AutoSize = true;
            lblCorAtual.BackColor = Color.FromArgb(255, 192, 192);
            lblCorAtual.Location = new Point(709, 287);
            lblCorAtual.Name = "lblCorAtual";
            lblCorAtual.Size = new Size(71, 20);
            lblCorAtual.TabIndex = 8;
            lblCorAtual.Text = "Cor Atual";
            // 
            // lblDirecaoAltural
            // 
            lblDirecaoAltural.AutoSize = true;
            lblDirecaoAltural.BackColor = Color.FromArgb(255, 192, 192);
            lblDirecaoAltural.Location = new Point(709, 363);
            lblDirecaoAltural.Name = "lblDirecaoAltural";
            lblDirecaoAltural.Size = new Size(100, 20);
            lblDirecaoAltural.TabIndex = 9;
            lblDirecaoAltural.Text = "Direção Atual";
            // 
            // lblAtitudeAtual
            // 
            lblAtitudeAtual.AutoSize = true;
            lblAtitudeAtual.BackColor = Color.FromArgb(255, 192, 192);
            lblAtitudeAtual.Location = new Point(709, 432);
            lblAtitudeAtual.Name = "lblAtitudeAtual";
            lblAtitudeAtual.Size = new Size(97, 20);
            lblAtitudeAtual.TabIndex = 10;
            lblAtitudeAtual.Text = "Atitude Atual";
            // 
            // btnAlterarCor
            // 
            btnAlterarCor.Location = new Point(653, 28);
            btnAlterarCor.Name = "btnAlterarCor";
            btnAlterarCor.Size = new Size(157, 35);
            btnAlterarCor.TabIndex = 11;
            btnAlterarCor.Text = "Alterar Cor";
            btnAlterarCor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 574);
            Controls.Add(btnAlterarCor);
            Controls.Add(lblAtitudeAtual);
            Controls.Add(lblDirecaoAltural);
            Controls.Add(lblCorAtual);
            Controls.Add(btnBaixo);
            Controls.Add(btnEsquerda);
            Controls.Add(btnDireita);
            Controls.Add(btnCima);
            Controls.Add(numericUpDown1);
            Controls.Add(pictureBox1);
            Controls.Add(btnIniciaBalao);
            Name = "Form1";
            Text = "Balão";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButtonRosa;
        private RadioButton radioButtonRainbow;
        private RadioButton radioButtonVermelho;
        private RadioButton radioButtonVerde;
        private RadioButton radioButtonAmarelo;
        private RadioButton radioButtonAzul;
        private Button btnIniciar;
        private Button btnCancelar;
        private Button btnIniciaBalao;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
        private Button btnCima;
        private Button btnDireita;
        private Button btnEsquerda;
        private Button btnBaixo;
        private Label lblCorAtual;
        private Label lblDirecaoAltural;
        private Label lblAtitudeAtual;
        private Button btnAlterarCor;
    }
}
