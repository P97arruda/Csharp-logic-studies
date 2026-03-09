namespace ProcjetPost
{
    partial class FormPrinciapll
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
            BtnCriaPost = new Button();
            SuspendLayout();
            // 
            // BtnCriaPost
            // 
            BtnCriaPost.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnCriaPost.Location = new Point(596, 332);
            BtnCriaPost.Name = "BtnCriaPost";
            BtnCriaPost.Size = new Size(148, 69);
            BtnCriaPost.TabIndex = 0;
            BtnCriaPost.Text = "Criar Post";
            BtnCriaPost.UseVisualStyleBackColor = true;
            BtnCriaPost.Click += BtnCriaPost_Click;
            // 
            // FormPrinciapll
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 430);
            Controls.Add(BtnCriaPost);
            Name = "FormPrinciapll";
            Text = "Post";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCriaPost;
    }
}
