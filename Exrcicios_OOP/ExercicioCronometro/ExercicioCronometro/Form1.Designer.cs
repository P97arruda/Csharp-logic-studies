namespace ExercicioCronometro
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
            components = new System.ComponentModel.Container();
            ButtonOnOff = new Button();
            labelContador = new Label();
            TimerRelogio = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ButtonOnOff
            // 
            ButtonOnOff.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            ButtonOnOff.Location = new Point(658, 319);
            ButtonOnOff.Name = "ButtonOnOff";
            ButtonOnOff.Size = new Size(114, 103);
            ButtonOnOff.TabIndex = 0;
            ButtonOnOff.Text = "Ligar";
            ButtonOnOff.UseVisualStyleBackColor = true;
            ButtonOnOff.Click += ButtonOnOff_Click;
            // 
            // labelContador
            // 
            labelContador.AutoSize = true;
            labelContador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelContador.Location = new Point(309, 179);
            labelContador.Name = "labelContador";
            labelContador.Size = new Size(135, 28);
            labelContador.TabIndex = 1;
            labelContador.Text = "00:00:00:000";
            // 
            // TimerRelogio
            // 
            TimerRelogio.Tick += TimerRelogio_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelContador);
            Controls.Add(ButtonOnOff);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonOnOff;
        private Label labelContador;
        private System.Windows.Forms.Timer TimerRelogio;
    }
}
