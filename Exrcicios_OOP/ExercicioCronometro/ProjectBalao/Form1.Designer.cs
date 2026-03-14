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
            groupBox = new GroupBox();
            btnGrupBoxCancelar = new Button();
            btnGrupBoxIniciar = new Button();
            radioButtonRosa = new RadioButton();
            radioButtonVermelho = new RadioButton();
            radioButtonAmarelo = new RadioButton();
            radioButtonRainbow = new RadioButton();
            radioButtonVerde = new RadioButton();
            radioButtonAzul = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciaBalao
            // 
            btnIniciaBalao.BackColor = Color.FromArgb(0, 192, 192);
            btnIniciaBalao.Location = new Point(895, 592);
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
            pictureBox1.Location = new Point(631, 498);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 130);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(957, 159);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // btnCima
            // 
            btnCima.BackColor = Color.FromArgb(192, 255, 255);
            btnCima.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCima.Location = new Point(957, 100);
            btnCima.Name = "btnCima";
            btnCima.Size = new Size(65, 53);
            btnCima.TabIndex = 4;
            btnCima.Text = "↑";
            btnCima.UseVisualStyleBackColor = false;
            btnCima.Click += btnCima_Click;
            // 
            // btnDireita
            // 
            btnDireita.BackColor = Color.FromArgb(128, 255, 255);
            btnDireita.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDireita.Location = new Point(1028, 152);
            btnDireita.Name = "btnDireita";
            btnDireita.Size = new Size(60, 42);
            btnDireita.TabIndex = 5;
            btnDireita.Text = "→";
            btnDireita.UseVisualStyleBackColor = false;
            btnDireita.Click += btnDireita_Click;
            // 
            // btnEsquerda
            // 
            btnEsquerda.BackColor = Color.FromArgb(128, 255, 255);
            btnEsquerda.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEsquerda.Location = new Point(885, 151);
            btnEsquerda.Name = "btnEsquerda";
            btnEsquerda.Size = new Size(66, 44);
            btnEsquerda.TabIndex = 6;
            btnEsquerda.Text = "← ";
            btnEsquerda.UseVisualStyleBackColor = false;
            btnEsquerda.Click += btnEsquerda_Click;
            // 
            // btnBaixo
            // 
            btnBaixo.BackColor = Color.FromArgb(128, 255, 255);
            btnBaixo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBaixo.Location = new Point(957, 192);
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
            lblCorAtual.BackColor = Color.White;
            lblCorAtual.Location = new Point(969, 313);
            lblCorAtual.Name = "lblCorAtual";
            lblCorAtual.Size = new Size(29, 20);
            lblCorAtual.TabIndex = 8;
            lblCorAtual.Text = "\"  \"";
            lblCorAtual.Click += lblCorAtual_Click;
            // 
            // lblDirecaoAltural
            // 
            lblDirecaoAltural.AutoSize = true;
            lblDirecaoAltural.BackColor = Color.WhiteSmoke;
            lblDirecaoAltural.Location = new Point(969, 372);
            lblDirecaoAltural.Name = "lblDirecaoAltural";
            lblDirecaoAltural.Size = new Size(25, 20);
            lblDirecaoAltural.TabIndex = 9;
            lblDirecaoAltural.Text = "\" \"";
            // 
            // lblAtitudeAtual
            // 
            lblAtitudeAtual.AutoSize = true;
            lblAtitudeAtual.BackColor = Color.WhiteSmoke;
            lblAtitudeAtual.Location = new Point(969, 443);
            lblAtitudeAtual.Name = "lblAtitudeAtual";
            lblAtitudeAtual.Size = new Size(25, 20);
            lblAtitudeAtual.TabIndex = 10;
            lblAtitudeAtual.Text = "\" \"";
            // 
            // btnAlterarCor
            // 
            btnAlterarCor.Location = new Point(909, 12);
            btnAlterarCor.Name = "btnAlterarCor";
            btnAlterarCor.Size = new Size(157, 35);
            btnAlterarCor.TabIndex = 11;
            btnAlterarCor.Text = "Alterar Cor";
            btnAlterarCor.UseVisualStyleBackColor = true;
            btnAlterarCor.Click += btnAlterarCor_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(btnGrupBoxCancelar);
            groupBox.Controls.Add(btnGrupBoxIniciar);
            groupBox.Controls.Add(radioButtonRosa);
            groupBox.Controls.Add(radioButtonVermelho);
            groupBox.Controls.Add(radioButtonAmarelo);
            groupBox.Controls.Add(radioButtonRainbow);
            groupBox.Controls.Add(radioButtonVerde);
            groupBox.Controls.Add(radioButtonAzul);
            groupBox.Location = new Point(47, 40);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(509, 241);
            groupBox.TabIndex = 12;
            groupBox.TabStop = false;
            groupBox.Text = "Escolher a cor do Balão";
            // 
            // btnGrupBoxCancelar
            // 
            btnGrupBoxCancelar.Location = new Point(266, 195);
            btnGrupBoxCancelar.Name = "btnGrupBoxCancelar";
            btnGrupBoxCancelar.Size = new Size(94, 29);
            btnGrupBoxCancelar.TabIndex = 7;
            btnGrupBoxCancelar.Text = "Cancelar";
            btnGrupBoxCancelar.UseVisualStyleBackColor = true;
            btnGrupBoxCancelar.Click += btnGrupBoxCancelar_Click;
            // 
            // btnGrupBoxIniciar
            // 
            btnGrupBoxIniciar.BackColor = Color.FromArgb(0, 192, 192);
            btnGrupBoxIniciar.Location = new Point(389, 195);
            btnGrupBoxIniciar.Name = "btnGrupBoxIniciar";
            btnGrupBoxIniciar.Size = new Size(94, 29);
            btnGrupBoxIniciar.TabIndex = 6;
            btnGrupBoxIniciar.Text = "Iniciar";
            btnGrupBoxIniciar.UseVisualStyleBackColor = false;
            btnGrupBoxIniciar.Click += btnGrupBoxIniciar_Click;
            // 
            // radioButtonRosa
            // 
            radioButtonRosa.AutoSize = true;
            radioButtonRosa.BackColor = Color.FromArgb(255, 128, 255);
            radioButtonRosa.Location = new Point(358, 80);
            radioButtonRosa.Name = "radioButtonRosa";
            radioButtonRosa.Size = new Size(62, 24);
            radioButtonRosa.TabIndex = 5;
            radioButtonRosa.TabStop = true;
            radioButtonRosa.Text = "Rosa";
            radioButtonRosa.UseVisualStyleBackColor = false;
            // 
            // radioButtonVermelho
            // 
            radioButtonVermelho.AutoSize = true;
            radioButtonVermelho.BackColor = Color.Red;
            radioButtonVermelho.Location = new Point(208, 80);
            radioButtonVermelho.Name = "radioButtonVermelho";
            radioButtonVermelho.Size = new Size(93, 24);
            radioButtonVermelho.TabIndex = 4;
            radioButtonVermelho.TabStop = true;
            radioButtonVermelho.Text = "Vermelho";
            radioButtonVermelho.UseVisualStyleBackColor = false;
            // 
            // radioButtonAmarelo
            // 
            radioButtonAmarelo.AutoSize = true;
            radioButtonAmarelo.BackColor = Color.FromArgb(255, 255, 128);
            radioButtonAmarelo.Location = new Point(59, 77);
            radioButtonAmarelo.Name = "radioButtonAmarelo";
            radioButtonAmarelo.Size = new Size(87, 24);
            radioButtonAmarelo.TabIndex = 3;
            radioButtonAmarelo.TabStop = true;
            radioButtonAmarelo.Text = "Amarelo";
            radioButtonAmarelo.UseVisualStyleBackColor = false;
            // 
            // radioButtonRainbow
            // 
            radioButtonRainbow.AutoSize = true;
            radioButtonRainbow.Location = new Point(358, 41);
            radioButtonRainbow.Name = "radioButtonRainbow";
            radioButtonRainbow.Size = new Size(88, 24);
            radioButtonRainbow.TabIndex = 2;
            radioButtonRainbow.TabStop = true;
            radioButtonRainbow.Text = "Rainbow";
            radioButtonRainbow.UseVisualStyleBackColor = true;
            // 
            // radioButtonVerde
            // 
            radioButtonVerde.AutoSize = true;
            radioButtonVerde.BackColor = Color.FromArgb(128, 255, 128);
            radioButtonVerde.Location = new Point(205, 41);
            radioButtonVerde.Name = "radioButtonVerde";
            radioButtonVerde.Size = new Size(68, 24);
            radioButtonVerde.TabIndex = 1;
            radioButtonVerde.TabStop = true;
            radioButtonVerde.Text = "Verde";
            radioButtonVerde.UseVisualStyleBackColor = false;
            // 
            // radioButtonAzul
            // 
            radioButtonAzul.AutoSize = true;
            radioButtonAzul.BackColor = SystemColors.Highlight;
            radioButtonAzul.Location = new Point(59, 41);
            radioButtonAzul.Name = "radioButtonAzul";
            radioButtonAzul.Size = new Size(59, 24);
            radioButtonAzul.TabIndex = 0;
            radioButtonAzul.TabStop = true;
            radioButtonAzul.Text = "Azul";
            radioButtonAzul.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(957, 278);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 13;
            label1.Text = "Cor Atual";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 192);
            label2.Location = new Point(957, 352);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 14;
            label2.Text = "Direçõo Atual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(957, 423);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 15;
            label3.Text = "Atitude Atual";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 649);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox);
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
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region 


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

        private GroupBox groupBox;
        private Button btnGrupBoxCancelar;
        private Button btnGrupBoxIniciar;

        private RadioButton radioButtonRosa;
        private RadioButton radioButtonRainbow;
        private RadioButton radioButtonVermelho;
        private RadioButton radioButtonVerde;
        private RadioButton radioButtonAmarelo;
        private RadioButton radioButtonAzul;

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }



}
