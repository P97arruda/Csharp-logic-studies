namespace ProjectCarro
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
            groupBoxDadosVeiculo = new GroupBox();
            btnCancelar = new Button();
            btnIniciar = new Button();
            numeDownConsumo = new NumericUpDown();
            label3 = new Label();
            numeUpDown1Capacidade = new NumericUpDown();
            label2 = new Label();
            textBoxM3 = new TextBox();
            textBoxM2 = new TextBox();
            textBoxM1 = new TextBox();
            label1 = new Label();
            groupBoxMeuCarro = new GroupBox();
            label8 = new Label();
            label6 = new Label();
            numericUpLitros = new NumericUpDown();
            numericUpKM = new NumericUpDown();
            btnViajar = new Button();
            btnAbastecer = new Button();
            btnMostrarDetalhe = new Button();
            lblDeposito = new Label();
            lblQuilomentragem = new Label();
            label12 = new Label();
            lblViagens = new Label();
            label10 = new Label();
            label9 = new Label();
            lblKMdisponiveis = new Label();
            label7 = new Label();
            lblMatricula = new Label();
            label5 = new Label();
            label4 = new Label();
            btnCriarNovoCarro = new Button();
            groupBoxDadosVeiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numeDownConsumo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeUpDown1Capacidade).BeginInit();
            groupBoxMeuCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpLitros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpKM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDadosVeiculo
            // 
            groupBoxDadosVeiculo.BackColor = SystemColors.ActiveCaption;
            groupBoxDadosVeiculo.Controls.Add(btnCancelar);
            groupBoxDadosVeiculo.Controls.Add(btnIniciar);
            groupBoxDadosVeiculo.Controls.Add(numeDownConsumo);
            groupBoxDadosVeiculo.Controls.Add(label3);
            groupBoxDadosVeiculo.Controls.Add(numeUpDown1Capacidade);
            groupBoxDadosVeiculo.Controls.Add(label2);
            groupBoxDadosVeiculo.Controls.Add(textBoxM3);
            groupBoxDadosVeiculo.Controls.Add(textBoxM2);
            groupBoxDadosVeiculo.Controls.Add(textBoxM1);
            groupBoxDadosVeiculo.Controls.Add(label1);
            groupBoxDadosVeiculo.Location = new Point(12, 21);
            groupBoxDadosVeiculo.Name = "groupBoxDadosVeiculo";
            groupBoxDadosVeiculo.Size = new Size(458, 235);
            groupBoxDadosVeiculo.TabIndex = 0;
            groupBoxDadosVeiculo.TabStop = false;
            groupBoxDadosVeiculo.Text = "Dados Do novo Veiculo";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(242, 187);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Gold;
            btnIniciar.Location = new Point(342, 187);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(103, 29);
            btnIniciar.TabIndex = 8;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // numeDownConsumo
            // 
            numeDownConsumo.Location = new Point(192, 124);
            numeDownConsumo.Name = "numeDownConsumo";
            numeDownConsumo.Size = new Size(54, 27);
            numeDownConsumo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 125);
            label3.Name = "label3";
            label3.Size = new Size(168, 20);
            label3.TabIndex = 6;
            label3.Text = "Consumo médio (km/L):";
            // 
            // numeUpDown1Capacidade
            // 
            numeUpDown1Capacidade.Location = new Point(233, 80);
            numeUpDown1Capacidade.Name = "numeUpDown1Capacidade";
            numeUpDown1Capacidade.Size = new Size(47, 27);
            numeUpDown1Capacidade.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(214, 23);
            label2.TabIndex = 4;
            label2.Text = "Capacidade total deposito:";
            // 
            // textBoxM3
            // 
            textBoxM3.Location = new Point(233, 34);
            textBoxM3.Name = "textBoxM3";
            textBoxM3.Size = new Size(43, 27);
            textBoxM3.TabIndex = 3;
            // 
            // textBoxM2
            // 
            textBoxM2.Location = new Point(174, 34);
            textBoxM2.Name = "textBoxM2";
            textBoxM2.Size = new Size(44, 27);
            textBoxM2.TabIndex = 2;
            // 
            // textBoxM1
            // 
            textBoxM1.Location = new Point(113, 34);
            textBoxM1.Name = "textBoxM1";
            textBoxM1.Size = new Size(44, 27);
            textBoxM1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 0;
            label1.Text = "Matricula: ";
            // 
            // groupBoxMeuCarro
            // 
            groupBoxMeuCarro.BackColor = Color.LightPink;
            groupBoxMeuCarro.Controls.Add(label8);
            groupBoxMeuCarro.Controls.Add(label6);
            groupBoxMeuCarro.Controls.Add(numericUpLitros);
            groupBoxMeuCarro.Controls.Add(numericUpKM);
            groupBoxMeuCarro.Controls.Add(btnViajar);
            groupBoxMeuCarro.Controls.Add(btnAbastecer);
            groupBoxMeuCarro.Controls.Add(btnMostrarDetalhe);
            groupBoxMeuCarro.Controls.Add(lblDeposito);
            groupBoxMeuCarro.Controls.Add(lblQuilomentragem);
            groupBoxMeuCarro.Controls.Add(label12);
            groupBoxMeuCarro.Controls.Add(lblViagens);
            groupBoxMeuCarro.Controls.Add(label10);
            groupBoxMeuCarro.Controls.Add(label9);
            groupBoxMeuCarro.Controls.Add(lblKMdisponiveis);
            groupBoxMeuCarro.Controls.Add(label7);
            groupBoxMeuCarro.Controls.Add(lblMatricula);
            groupBoxMeuCarro.Controls.Add(label5);
            groupBoxMeuCarro.Controls.Add(label4);
            groupBoxMeuCarro.Location = new Point(538, 21);
            groupBoxMeuCarro.Name = "groupBoxMeuCarro";
            groupBoxMeuCarro.Size = new Size(561, 517);
            groupBoxMeuCarro.TabIndex = 1;
            groupBoxMeuCarro.TabStop = false;
            groupBoxMeuCarro.Text = "O meu veiculo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(33, 424);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 17;
            label8.Text = "Litros :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 378);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 16;
            label6.Text = "Km viagem:";
            // 
            // numericUpLitros
            // 
            numericUpLitros.Location = new Point(118, 422);
            numericUpLitros.Name = "numericUpLitros";
            numericUpLitros.Size = new Size(66, 27);
            numericUpLitros.TabIndex = 15;
            // 
            // numericUpKM
            // 
            numericUpKM.Location = new Point(118, 376);
            numericUpKM.Name = "numericUpKM";
            numericUpKM.Size = new Size(66, 27);
            numericUpKM.TabIndex = 14;
            // 
            // btnViajar
            // 
            btnViajar.Location = new Point(158, 286);
            btnViajar.Name = "btnViajar";
            btnViajar.Size = new Size(94, 29);
            btnViajar.TabIndex = 13;
            btnViajar.Text = "Viajar";
            btnViajar.UseVisualStyleBackColor = true;
            btnViajar.Click += btnViajar_Click;
            // 
            // btnAbastecer
            // 
            btnAbastecer.Location = new Point(273, 286);
            btnAbastecer.Name = "btnAbastecer";
            btnAbastecer.Size = new Size(94, 29);
            btnAbastecer.TabIndex = 12;
            btnAbastecer.Text = "Abastecer";
            btnAbastecer.UseVisualStyleBackColor = true;
            btnAbastecer.Click += btnAbastecer_Click;
            // 
            // btnMostrarDetalhe
            // 
            btnMostrarDetalhe.Location = new Point(384, 286);
            btnMostrarDetalhe.Name = "btnMostrarDetalhe";
            btnMostrarDetalhe.Size = new Size(148, 29);
            btnMostrarDetalhe.TabIndex = 11;
            btnMostrarDetalhe.Text = "Mostrar Detalhes ";
            btnMostrarDetalhe.UseVisualStyleBackColor = true;
            btnMostrarDetalhe.Click += btnMostrarDetalhe_Click;
            // 
            // lblDeposito
            // 
            lblDeposito.AutoSize = true;
            lblDeposito.Location = new Point(89, 125);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(25, 20);
            lblDeposito.TabIndex = 10;
            lblDeposito.Text = "\" \"";
            // 
            // lblQuilomentragem
            // 
            lblQuilomentragem.AutoSize = true;
            lblQuilomentragem.Location = new Point(412, 139);
            lblQuilomentragem.Name = "lblQuilomentragem";
            lblQuilomentragem.Size = new Size(25, 20);
            lblQuilomentragem.TabIndex = 9;
            lblQuilomentragem.Text = "\" \"";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(289, 139);
            label12.Name = "label12";
            label12.Size = new Size(117, 20);
            label12.TabIndex = 8;
            label12.Text = "Quilometragem:";
            // 
            // lblViagens
            // 
            lblViagens.AutoSize = true;
            lblViagens.Location = new Point(89, 176);
            lblViagens.Name = "lblViagens";
            lblViagens.Size = new Size(25, 20);
            lblViagens.TabIndex = 7;
            lblViagens.Text = "\" \"";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 176);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 6;
            label10.Text = "Viagens: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 125);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 5;
            label9.Text = "Depósito:";
            // 
            // lblKMdisponiveis
            // 
            lblKMdisponiveis.AutoSize = true;
            lblKMdisponiveis.Location = new Point(412, 84);
            lblKMdisponiveis.Name = "lblKMdisponiveis";
            lblKMdisponiveis.Size = new Size(25, 20);
            lblKMdisponiveis.TabIndex = 4;
            lblKMdisponiveis.Text = "\" \"";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 84);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 3;
            label7.Text = "Kms disponiveis: ";
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Location = new Point(99, 82);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(29, 20);
            lblMatricula.TabIndex = 2;
            lblMatricula.Text = "\"  \"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 82);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 1;
            label5.Text = "Matriculo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 34);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 0;
            label4.Text = "Veiculo";
            // 
            // btnCriarNovoCarro
            // 
            btnCriarNovoCarro.BackColor = Color.FromArgb(128, 255, 128);
            btnCriarNovoCarro.Location = new Point(922, 586);
            btnCriarNovoCarro.Name = "btnCriarNovoCarro";
            btnCriarNovoCarro.Size = new Size(177, 36);
            btnCriarNovoCarro.TabIndex = 18;
            btnCriarNovoCarro.Text = "Criar Novo Carro";
            btnCriarNovoCarro.UseVisualStyleBackColor = false;
            btnCriarNovoCarro.Click += btnCriarNovoCarro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 634);
            Controls.Add(btnCriarNovoCarro);
            Controls.Add(groupBoxMeuCarro);
            Controls.Add(groupBoxDadosVeiculo);
            Name = "Form1";
            Text = "Form1";
            groupBoxDadosVeiculo.ResumeLayout(false);
            groupBoxDadosVeiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numeDownConsumo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeUpDown1Capacidade).EndInit();
            groupBoxMeuCarro.ResumeLayout(false);
            groupBoxMeuCarro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpLitros).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpKM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDadosVeiculo;
        private TextBox textBoxM3;
        private TextBox textBoxM2;
        private TextBox textBoxM1;
        private Label label1;
        private Label label3;
        private NumericUpDown numeUpDown1Capacidade;
        private Label label2;
        private NumericUpDown numeDownConsumo;
        private Button btnCancelar;
        private Button btnIniciar;
        private GroupBox groupBoxMeuCarro;
        private Label lblQuilomentragem;
        private Label label12;
        private Label lblViagens;
        private Label label10;
        private Label label9;
        private Label lblKMdisponiveis;
        private Label label7;
        private Label lblMatricula;
        private Label label5;
        private Label label4;
        private Button btnViajar;
        private Button btnAbastecer;
        private Button btnMostrarDetalhe;
        private Label lblDeposito;
        private Label label8;
        private Label label6;
        private NumericUpDown numericUpLitros;
        private NumericUpDown numericUpKM;
        private Button btnCriarNovoCarro;
    }
}
