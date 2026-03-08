namespace Televisao.Forms
{
    partial class frmPrincial
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
            btnOnOff = new Button();
            lblInfo = new Label();
            groupBoxCanais = new GroupBox();
            lblCanal = new Label();
            btnAumentaCanal = new Button();
            btnDiminuiCanal = new Button();
            groupBoxVolume = new GroupBox();
            progressBarVolume = new ProgressBar();
            btnAumenteVolume = new Button();
            btndiminuiVolume = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            lblTotalCanais = new Label();
            btnMute = new Button();
            groupBoxCanais.SuspendLayout();
            groupBoxVolume.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOnOff
            // 
            btnOnOff.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOnOff.Location = new Point(666, 310);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(141, 95);
            btnOnOff.TabIndex = 0;
            btnOnOff.Text = "Ligar";
            btnOnOff.UseVisualStyleBackColor = true;
            btnOnOff.Click += btnOnOff_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInfo.Location = new Point(12, 355);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(320, 28);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Não existe nenhuma Box criada!";
            // 
            // groupBoxCanais
            // 
            groupBoxCanais.Controls.Add(lblCanal);
            groupBoxCanais.Controls.Add(btnAumentaCanal);
            groupBoxCanais.Controls.Add(btnDiminuiCanal);
            groupBoxCanais.Enabled = false;
            groupBoxCanais.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxCanais.Location = new Point(486, 26);
            groupBoxCanais.Name = "groupBoxCanais";
            groupBoxCanais.Size = new Size(321, 204);
            groupBoxCanais.TabIndex = 2;
            groupBoxCanais.TabStop = false;
            groupBoxCanais.Text = "Canais";
            // 
            // lblCanal
            // 
            lblCanal.AutoSize = true;
            lblCanal.Location = new Point(158, 105);
            lblCanal.Name = "lblCanal";
            lblCanal.Size = new Size(20, 28);
            lblCanal.TabIndex = 2;
            lblCanal.Text = "-";
            // 
            // btnAumentaCanal
            // 
            btnAumentaCanal.Location = new Point(222, 97);
            btnAumentaCanal.Name = "btnAumentaCanal";
            btnAumentaCanal.Size = new Size(93, 44);
            btnAumentaCanal.TabIndex = 1;
            btnAumentaCanal.Text = "+";
            btnAumentaCanal.UseVisualStyleBackColor = true;
            btnAumentaCanal.Click += btnAumentaCanal_Click;
            // 
            // btnDiminuiCanal
            // 
            btnDiminuiCanal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDiminuiCanal.Location = new Point(17, 97);
            btnDiminuiCanal.Name = "btnDiminuiCanal";
            btnDiminuiCanal.Size = new Size(95, 44);
            btnDiminuiCanal.TabIndex = 0;
            btnDiminuiCanal.Text = "-";
            btnDiminuiCanal.UseVisualStyleBackColor = true;
            btnDiminuiCanal.Click += btnDiminuiCanal_Click;
            // 
            // groupBoxVolume
            // 
            groupBoxVolume.Controls.Add(btnMute);
            groupBoxVolume.Controls.Add(progressBarVolume);
            groupBoxVolume.Controls.Add(btnAumenteVolume);
            groupBoxVolume.Controls.Add(btndiminuiVolume);
            groupBoxVolume.Enabled = false;
            groupBoxVolume.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxVolume.Location = new Point(30, 31);
            groupBoxVolume.Name = "groupBoxVolume";
            groupBoxVolume.Size = new Size(339, 216);
            groupBoxVolume.TabIndex = 3;
            groupBoxVolume.TabStop = false;
            groupBoxVolume.Text = "Volume ";
            // 
            // progressBarVolume
            // 
            progressBarVolume.Location = new Point(20, 121);
            progressBarVolume.Name = "progressBarVolume";
            progressBarVolume.Size = new Size(268, 25);
            progressBarVolume.TabIndex = 2;
            // 
            // btnAumenteVolume
            // 
            btnAumenteVolume.Location = new Point(194, 39);
            btnAumenteVolume.Name = "btnAumenteVolume";
            btnAumenteVolume.Size = new Size(94, 55);
            btnAumenteVolume.TabIndex = 1;
            btnAumenteVolume.Text = "+";
            btnAumenteVolume.UseVisualStyleBackColor = true;
            btnAumenteVolume.Click += btnAumenteVolume_Click;
            // 
            // btndiminuiVolume
            // 
            btndiminuiVolume.Location = new Point(20, 39);
            btndiminuiVolume.Name = "btndiminuiVolume";
            btndiminuiVolume.Size = new Size(90, 55);
            btndiminuiVolume.TabIndex = 0;
            btndiminuiVolume.Text = "-";
            btndiminuiVolume.UseVisualStyleBackColor = true;
            btndiminuiVolume.Click += btndiminuiVolume_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(819, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "&Nova Box";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(91, 24);
            toolStripMenuItem1.Text = "&Nova Box ";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // lblTotalCanais
            // 
            lblTotalCanais.AutoSize = true;
            lblTotalCanais.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalCanais.Location = new Point(12, 405);
            lblTotalCanais.Name = "lblTotalCanais";
            lblTotalCanais.Size = new Size(128, 23);
            lblTotalCanais.TabIndex = 5;
            lblTotalCanais.Text = "Total de Cais: -";
            lblTotalCanais.Click += lblTotalCanais_Click;
            // 
            // btnMute
            // 
            btnMute.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnMute.Location = new Point(122, 159);
            btnMute.Name = "btnMute";
            btnMute.Size = new Size(82, 40);
            btnMute.TabIndex = 3;
            btnMute.Text = "Mute";
            btnMute.UseVisualStyleBackColor = true;
            btnMute.Click += btnMute_Click;
            // 
            // frmPrincial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 434);
            Controls.Add(lblTotalCanais);
            Controls.Add(groupBoxVolume);
            Controls.Add(groupBoxCanais);
            Controls.Add(lblInfo);
            Controls.Add(btnOnOff);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincial";
            Text = "POO - Televisão";
            Load += frmPrincial_Load;
            groupBoxCanais.ResumeLayout(false);
            groupBoxCanais.PerformLayout();
            groupBoxVolume.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOnOff;
        private Label lblInfo;
        private GroupBox groupBoxCanais;
        private Button btnAumentaCanal;
        private Button btnDiminuiCanal;
        private Label lblCanal;
        private GroupBox groupBoxVolume;
        private ProgressBar progressBarVolume;
        private Button btnAumenteVolume;
        private Button btndiminuiVolume;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label lblTotalCanais;
        private Button btnMute;
    }
}
