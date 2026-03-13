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
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
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
            lblCorAtual.BackColor = Color.FromArgb(255, 192, 192);
            lblCorAtual.Location = new Point(957, 281);
            lblCorAtual.Name = "lblCorAtual";
            lblCorAtual.Size = new Size(71, 20);
            lblCorAtual.TabIndex = 8;
            lblCorAtual.Text = "Cor Atual";
            lblCorAtual.Click += lblCorAtual_Click;
            // 
            // lblDirecaoAltural
            // 
            lblDirecaoAltural.AutoSize = true;
            lblDirecaoAltural.BackColor = Color.FromArgb(255, 192, 192);
            lblDirecaoAltural.Location = new Point(938, 342);
            lblDirecaoAltural.Name = "lblDirecaoAltural";
            lblDirecaoAltural.Size = new Size(100, 20);
            lblDirecaoAltural.TabIndex = 9;
            lblDirecaoAltural.Text = "Direção Atual";
            // 
            // lblAtitudeAtual
            // 
            lblAtitudeAtual.AutoSize = true;
            lblAtitudeAtual.BackColor = Color.FromArgb(255, 192, 192);
            lblAtitudeAtual.Location = new Point(941, 395);
            lblAtitudeAtual.Name = "lblAtitudeAtual";
            lblAtitudeAtual.Size = new Size(97, 20);
            lblAtitudeAtual.TabIndex = 10;
            lblAtitudeAtual.Text = "Atitude Atual";
            // 
            // btnAlterarCor
            // 
            btnAlterarCor.Location = new Point(909, 12);
            btnAlterarCor.Name = "btnAlterarCor";
            btnAlterarCor.Size = new Size(157, 35);
            btnAlterarCor.TabIndex = 11;
            btnAlterarCor.Text = "Alterar Cor";
            btnAlterarCor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(47, 40);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(509, 241);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(59, 41);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(205, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(358, 41);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(59, 77);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 24);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(208, 80);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(117, 24);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "radioButton5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(358, 80);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(117, 24);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "radioButton6";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(400, 195);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(300, 195);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 649);
            Controls.Add(groupBox2);
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private Button button1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
    }
}
