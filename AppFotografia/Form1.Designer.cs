namespace AppFotografia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.pbGris = new System.Windows.Forms.PictureBox();
            this.pbBinario = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramietnasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenBNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenBinariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdArchivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBinario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbColor
            // 
            this.pbColor.Location = new System.Drawing.Point(12, 34);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(300, 300);
            this.pbColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColor.TabIndex = 0;
            this.pbColor.TabStop = false;
            // 
            // pbGris
            // 
            this.pbGris.Location = new System.Drawing.Point(327, 34);
            this.pbGris.Name = "pbGris";
            this.pbGris.Size = new System.Drawing.Size(300, 300);
            this.pbGris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGris.TabIndex = 1;
            this.pbGris.TabStop = false;
            // 
            // pbBinario
            // 
            this.pbBinario.Location = new System.Drawing.Point(646, 34);
            this.pbBinario.Name = "pbBinario";
            this.pbBinario.Size = new System.Drawing.Size(300, 300);
            this.pbBinario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBinario.TabIndex = 2;
            this.pbBinario.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.herramietnasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirArchivoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirArchivoToolStripMenuItem
            // 
            this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
            this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirArchivoToolStripMenuItem.Text = "Abrir archivo";
            this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoToolStripMenuItem_Click);
            // 
            // herramietnasToolStripMenuItem
            // 
            this.herramietnasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagenBNToolStripMenuItem,
            this.imagenBinariaToolStripMenuItem});
            this.herramietnasToolStripMenuItem.Name = "herramietnasToolStripMenuItem";
            this.herramietnasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramietnasToolStripMenuItem.Text = "Herramientas";
            // 
            // imagenBNToolStripMenuItem
            // 
            this.imagenBNToolStripMenuItem.Name = "imagenBNToolStripMenuItem";
            this.imagenBNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagenBNToolStripMenuItem.Text = "Imagen B/N";
            this.imagenBNToolStripMenuItem.Click += new System.EventHandler(this.imagenBNToolStripMenuItem_Click);
            // 
            // imagenBinariaToolStripMenuItem
            // 
            this.imagenBinariaToolStripMenuItem.Name = "imagenBinariaToolStripMenuItem";
            this.imagenBinariaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imagenBinariaToolStripMenuItem.Text = "Imagen binaria";
            this.imagenBinariaToolStripMenuItem.Click += new System.EventHandler(this.imagenBinariaToolStripMenuItem_Click);
            // 
            // ofdArchivo
            // 
            this.ofdArchivo.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.pbBinario);
            this.Controls.Add(this.pbGris);
            this.Controls.Add(this.pbColor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBinario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.PictureBox pbGris;
        private System.Windows.Forms.PictureBox pbBinario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramietnasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenBNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagenBinariaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdArchivo;
    }
}

