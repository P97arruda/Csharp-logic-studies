namespace ProjectBalao
{
    partial class FormEscolherBalao
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
            radioButtonAzul = new RadioButton();
            radioButtonVerde = new RadioButton();
            radioButtonRainbow = new RadioButton();
            radioButtonRosa = new RadioButton();
            radioButtonVermelho = new RadioButton();
            radioButtonAmarelo = new RadioButton();
            btnIniciar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // radioButtonAzul
            // 
            radioButtonAzul.AutoSize = true;
            radioButtonAzul.BackColor = Color.Cyan;
            radioButtonAzul.Font = new Font("Segoe UI", 10F);
            radioButtonAzul.Location = new Point(105, 54);
            radioButtonAzul.Name = "radioButtonAzul";
            radioButtonAzul.Size = new Size(64, 27);
            radioButtonAzul.TabIndex = 0;
            radioButtonAzul.TabStop = true;
            radioButtonAzul.Text = "Azul";
            radioButtonAzul.UseVisualStyleBackColor = false;
            // 
            // radioButtonVerde
            // 
            radioButtonVerde.AutoSize = true;
            radioButtonVerde.BackColor = Color.FromArgb(128, 255, 128);
            radioButtonVerde.Font = new Font("Segoe UI", 10F);
            radioButtonVerde.Location = new Point(243, 54);
            radioButtonVerde.Name = "radioButtonVerde";
            radioButtonVerde.Size = new Size(75, 27);
            radioButtonVerde.TabIndex = 1;
            radioButtonVerde.TabStop = true;
            radioButtonVerde.Text = "Verde";
            radioButtonVerde.UseVisualStyleBackColor = false;
            // 
            // radioButtonRainbow
            // 
            radioButtonRainbow.AutoSize = true;
            radioButtonRainbow.Font = new Font("Segoe UI", 10F);
            radioButtonRainbow.Location = new Point(383, 56);
            radioButtonRainbow.Name = "radioButtonRainbow";
            radioButtonRainbow.Size = new Size(96, 27);
            radioButtonRainbow.TabIndex = 2;
            radioButtonRainbow.TabStop = true;
            radioButtonRainbow.Text = "Rainbow";
            radioButtonRainbow.UseVisualStyleBackColor = true;
            // 
            // radioButtonRosa
            // 
            radioButtonRosa.AutoSize = true;
            radioButtonRosa.BackColor = Color.FromArgb(255, 128, 255);
            radioButtonRosa.Location = new Point(383, 92);
            radioButtonRosa.Name = "radioButtonRosa";
            radioButtonRosa.Size = new Size(62, 24);
            radioButtonRosa.TabIndex = 3;
            radioButtonRosa.TabStop = true;
            radioButtonRosa.Text = "Rosa";
            radioButtonRosa.UseVisualStyleBackColor = false;
        
            // 
            // radioButtonVermelho
            // 
            radioButtonVermelho.AutoSize = true;
            radioButtonVermelho.BackColor = Color.Red;
            radioButtonVermelho.Font = new Font("Segoe UI", 10F);
            radioButtonVermelho.Location = new Point(243, 92);
            radioButtonVermelho.Name = "radioButtonVermelho";
            radioButtonVermelho.Size = new Size(104, 27);
            radioButtonVermelho.TabIndex = 4;
            radioButtonVermelho.TabStop = true;
            radioButtonVermelho.Text = "Vermelho";
            radioButtonVermelho.UseVisualStyleBackColor = false;
            // 
            // radioButtonAmarelo
            // 
            radioButtonAmarelo.AutoSize = true;
            radioButtonAmarelo.BackColor = Color.FromArgb(255, 255, 128);
            radioButtonAmarelo.Font = new Font("Segoe UI", 10F);
            radioButtonAmarelo.Location = new Point(105, 92);
            radioButtonAmarelo.Name = "radioButtonAmarelo";
            radioButtonAmarelo.Size = new Size(95, 27);
            radioButtonAmarelo.TabIndex = 5;
            radioButtonAmarelo.TabStop = true;
            radioButtonAmarelo.Text = "Amarelo";
            radioButtonAmarelo.UseVisualStyleBackColor = false;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(0, 192, 192);
            btnIniciar.Location = new Point(495, 198);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(113, 29);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(365, 198);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormEscolherBalao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 237);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(radioButtonAmarelo);
            Controls.Add(radioButtonVermelho);
            Controls.Add(radioButtonRosa);
            Controls.Add(radioButtonRainbow);
            Controls.Add(radioButtonVerde);
            Controls.Add(radioButtonAzul);
            Name = "FormEscolherBalao";
            Text = "FormEscolherBalao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonAzul;
        private RadioButton radioButtonVerde;
        private RadioButton radioButtonRainbow;
        private RadioButton radioButtonRosa;
        private RadioButton radioButtonVermelho;
        private RadioButton radioButtonAmarelo;
        private Button btnIniciar;
        private Button btnCancelar;
    }
}