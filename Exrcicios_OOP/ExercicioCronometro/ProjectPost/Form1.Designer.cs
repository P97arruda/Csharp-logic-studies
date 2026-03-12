namespace ProjectPost
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
            btnCriaPost = new Button();
            lblTitulo = new Label();
            lblDescricao = new Label();
            lblLike = new Label();
            lblDisLike = new Label();
            btnLike = new Button();
            btnDislike = new Button();
            lblData = new Label();
            panelPost = new Panel();
            panelPost.SuspendLayout();
            SuspendLayout();
            // 
            // btnCriaPost
            // 
            btnCriaPost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCriaPost.Location = new Point(654, 355);
            btnCriaPost.Name = "btnCriaPost";
            btnCriaPost.Size = new Size(122, 73);
            btnCriaPost.TabIndex = 0;
            btnCriaPost.Text = "Cria Post";
            btnCriaPost.UseVisualStyleBackColor = true;
            btnCriaPost.Click += btnCriaPost_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(49, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 28);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "\" \"";
            lblTitulo.Visible = false;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescricao.Location = new Point(49, 148);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(38, 28);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "\" \"";
            lblDescricao.Visible = false;
            // 
            // lblLike
            // 
            lblLike.AutoSize = true;
            lblLike.Location = new Point(15, 255);
            lblLike.Name = "lblLike";
            lblLike.Size = new Size(45, 20);
            lblLike.TabIndex = 3;
            lblLike.Text = "Like -";
            lblLike.Visible = false;
            // 
            // lblDisLike
            // 
            lblDisLike.AutoSize = true;
            lblDisLike.BackColor = Color.WhiteSmoke;
            lblDisLike.Location = new Point(182, 255);
            lblDisLike.Name = "lblDisLike";
            lblDisLike.Size = new Size(66, 20);
            lblDisLike.TabIndex = 4;
            lblDisLike.Text = "DisLike -";
            lblDisLike.Visible = false;
            // 
            // btnLike
            // 
            btnLike.BackColor = Color.Lime;
            btnLike.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLike.Location = new Point(15, 297);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(95, 56);
            btnLike.TabIndex = 5;
            btnLike.Text = "Like";
            btnLike.UseVisualStyleBackColor = false;
            btnLike.Visible = false;
            btnLike.Click += btnLike_Click;
            // 
            // btnDislike
            // 
            btnDislike.BackColor = Color.Red;
            btnDislike.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDislike.Location = new Point(182, 297);
            btnDislike.Name = "btnDislike";
            btnDislike.Size = new Size(105, 56);
            btnDislike.TabIndex = 6;
            btnDislike.Text = "Dislike";
            btnDislike.UseVisualStyleBackColor = false;
            btnDislike.Visible = false;
            btnDislike.Click += btnDislike_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(25, 372);
            lblData.Name = "lblData";
            lblData.Size = new Size(85, 20);
            lblData.TabIndex = 7;
            lblData.Text = "Criado em: ";
            lblData.Visible = false;
            // 
            // panelPost
            // 
            panelPost.Controls.Add(btnDislike);
            panelPost.Controls.Add(lblData);
            panelPost.Controls.Add(btnLike);
            panelPost.Controls.Add(lblTitulo);
            panelPost.Controls.Add(lblDescricao);
            panelPost.Controls.Add(lblLike);
            panelPost.Controls.Add(lblDisLike);
            panelPost.Location = new Point(12, 12);
            panelPost.Name = "panelPost";
            panelPost.Size = new Size(599, 402);
            panelPost.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 450);
            Controls.Add(panelPost);
            Controls.Add(btnCriaPost);
            Name = "Form1";
            Text = "Post";
            panelPost.ResumeLayout(false);
            panelPost.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCriaPost;
        private Label lblTitulo;
        private Label lblDescricao;
        private Label lblLike;
        private Label lblDisLike;
        private Button btnLike;
        private Button btnDislike;
        private Label lblData;
        private Panel panelPost;
    }
}
