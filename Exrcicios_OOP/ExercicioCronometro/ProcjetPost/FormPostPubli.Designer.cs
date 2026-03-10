namespace ProcjetPost
{
    partial class FormPostPubli
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
            lblTitulo = new Label();
            lblDescricao = new Label();
            lblLikes = new Label();
            lblDislikes = new Label();
            lblData = new Label();
            btnLikes = new Button();
            btnDislike = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 9F);
            lblTitulo.Location = new Point(41, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(25, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "\" \"";
            // 
            // lblDescricao
            // 
            lblDescricao.Font = new Font("Segoe UI", 9F);
            lblDescricao.Location = new Point(41, 105);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(50, 20);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "\" \"";
            // 
            // lblLikes
            // 
            lblLikes.AutoSize = true;
            lblLikes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLikes.Location = new Point(41, 288);
            lblLikes.Name = "lblLikes";
            lblLikes.Size = new Size(91, 28);
            lblLikes.TabIndex = 2;
            lblLikes.Text = "Likes - 0";
            // 
            // lblDislikes
            // 
            lblDislikes.AutoSize = true;
            lblDislikes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDislikes.Location = new Point(176, 288);
            lblDislikes.Name = "lblDislikes";
            lblDislikes.Size = new Size(117, 28);
            lblDislikes.TabIndex = 3;
            lblDislikes.Text = "Dislikes - 0";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 11F);
            lblData.Location = new Point(29, 406);
            lblData.Name = "lblData";
            lblData.Size = new Size(108, 25);
            lblData.TabIndex = 4;
            lblData.Text = "Criado em: ";
            // 
            // btnLikes
            // 
            btnLikes.BackColor = Color.FromArgb(128, 255, 128);
            btnLikes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLikes.Location = new Point(29, 351);
            btnLikes.Name = "btnLikes";
            btnLikes.Size = new Size(103, 40);
            btnLikes.TabIndex = 5;
            btnLikes.Text = "Like";
            btnLikes.UseVisualStyleBackColor = false;
            btnLikes.Click += btnLikes_Click;
            // 
            // btnDislike
            // 
            btnDislike.BackColor = Color.Red;
            btnDislike.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDislike.Location = new Point(176, 351);
            btnDislike.Name = "btnDislike";
            btnDislike.Size = new Size(100, 40);
            btnDislike.TabIndex = 6;
            btnDislike.Text = "Dislike";
            btnDislike.UseVisualStyleBackColor = false;
            btnDislike.Click += btnDislike_Click;
            // 
            // FormPostPubli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDislike);
            Controls.Add(btnLikes);
            Controls.Add(lblData);
            Controls.Add(lblDislikes);
            Controls.Add(lblLikes);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Name = "FormPostPubli";
            Text = "FormPostPubli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescricao;
        private Label lblLikes;
        private Label lblDislikes;
        private Label lblData;
        private Button btnLikes;
        private Button btnDislike;
    }
}