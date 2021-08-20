
namespace FormDeteccaoDeRosto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abrirImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iniciarWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagemToolStripMenuItem,
            this.iniciarWebCamToolStripMenuItem,
            this.paraWebCamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abrirImagemToolStripMenuItem
            // 
            this.abrirImagemToolStripMenuItem.Name = "abrirImagemToolStripMenuItem";
            this.abrirImagemToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.abrirImagemToolStripMenuItem.Text = "Abrir Imagem";
            this.abrirImagemToolStripMenuItem.Click += new System.EventHandler(this.abrirImagemToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // iniciarWebCamToolStripMenuItem
            // 
            this.iniciarWebCamToolStripMenuItem.Name = "iniciarWebCamToolStripMenuItem";
            this.iniciarWebCamToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.iniciarWebCamToolStripMenuItem.Text = "Iniciar WebCam";
            this.iniciarWebCamToolStripMenuItem.Click += new System.EventHandler(this.iniciarWebCamToolStripMenuItem_Click);
            // 
            // paraWebCamToolStripMenuItem
            // 
            this.paraWebCamToolStripMenuItem.Name = "paraWebCamToolStripMenuItem";
            this.paraWebCamToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.paraWebCamToolStripMenuItem.Text = "Para WebCam";
            this.paraWebCamToolStripMenuItem.Click += new System.EventHandler(this.paraWebCamToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Detecção de rosto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirImagemToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem iniciarWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraWebCamToolStripMenuItem;
    }
}

