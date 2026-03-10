namespace ProcjetPost
{
    partial class FormCriaPost
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
            lblTituloPost = new Label();
            textBoxTituloPost = new TextBox();
            lblDescricao = new Label();
            textBoxDescricao = new TextBox();
            btnPublicarPost = new Button();
            btnCancelarPost = new Button();
            SuspendLayout();
            // 
            // lblTituloPost
            // 
            lblTituloPost.AutoSize = true;
            lblTituloPost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloPost.Location = new Point(72, 39);
            lblTituloPost.Name = "lblTituloPost";
            lblTituloPost.Size = new Size(150, 28);
            lblTituloPost.TabIndex = 0;
            lblTituloPost.Text = "Titulo do post:";
            // 
            // textBoxTituloPost
            // 
            textBoxTituloPost.Location = new Point(72, 70);
            textBoxTituloPost.Multiline = true;
            textBoxTituloPost.Name = "textBoxTituloPost";
            textBoxTituloPost.Size = new Size(711, 97);
            textBoxTituloPost.TabIndex = 1;
            textBoxTituloPost.TextChanged += textBoxTituloPost_TextChanged;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescricao.Location = new Point(72, 170);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(186, 28);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Descrição do post:";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.Location = new Point(72, 201);
            textBoxDescricao.Multiline = true;
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(711, 181);
            textBoxDescricao.TabIndex = 3;
          
            // 
            // btnPublicarPost
            // 
            btnPublicarPost.BackColor = Color.LightCoral;
            btnPublicarPost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPublicarPost.Location = new Point(647, 420);
            btnPublicarPost.Name = "btnPublicarPost";
            btnPublicarPost.Size = new Size(136, 36);
            btnPublicarPost.TabIndex = 4;
            btnPublicarPost.Text = "Publicar Post";
            btnPublicarPost.UseVisualStyleBackColor = false;
            btnPublicarPost.Click += btnPublicarPost_Click;
            // 
            // btnCancelarPost
            // 
            btnCancelarPost.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelarPost.Location = new Point(516, 420);
            btnCancelarPost.Name = "btnCancelarPost";
            btnCancelarPost.Size = new Size(125, 36);
            btnCancelarPost.TabIndex = 5;
            btnCancelarPost.Text = "Cancelar";
            btnCancelarPost.UseVisualStyleBackColor = true;
            btnCancelarPost.Click += btnCancelarPost_Click;
            // 
            // FormCriaPost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 468);
            Controls.Add(btnCancelarPost);
            Controls.Add(btnPublicarPost);
            Controls.Add(textBoxDescricao);
            Controls.Add(lblDescricao);
            Controls.Add(textBoxTituloPost);
            Controls.Add(lblTituloPost);
            Name = "FormCriaPost";
            Text = "Defina um titulo e uma descrição para o post";
            Load += FormCriaPost_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPost;
        private TextBox textBoxTituloPost;
        private Label lblDescricao;
        private TextBox textBoxDescricao;
        private Button btnPublicarPost;
        private Button btnCancelarPost;
    }
}