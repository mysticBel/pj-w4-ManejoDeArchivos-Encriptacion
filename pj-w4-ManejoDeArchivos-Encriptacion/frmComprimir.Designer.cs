namespace pj_w4_ManejoDeArchivos_Encriptacion
{
    partial class frmComprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprimir));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAbrir = new System.Windows.Forms.ToolStripButton();
            this.tsGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsComprimir = new System.Windows.Forms.ToolStripButton();
            this.tsDescomprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSalir = new System.Windows.Forms.ToolStripButton();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAbrir,
            this.tsGuardar,
            this.tsComprimir,
            this.tsDescomprimir,
            this.toolStripSeparator1,
            this.tsSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAbrir
            // 
            this.tsAbrir.Image = ((System.Drawing.Image)(resources.GetObject("tsAbrir.Image")));
            this.tsAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAbrir.Name = "tsAbrir";
            this.tsAbrir.Size = new System.Drawing.Size(59, 22);
            this.tsAbrir.Text = "ABRIR";
            this.tsAbrir.Click += new System.EventHandler(this.tsAbrir_Click);
            // 
            // tsGuardar
            // 
            this.tsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsGuardar.Image")));
            this.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGuardar.Name = "tsGuardar";
            this.tsGuardar.Size = new System.Drawing.Size(81, 22);
            this.tsGuardar.Text = "GUARDAR";
            // 
            // tsComprimir
            // 
            this.tsComprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsComprimir.Image")));
            this.tsComprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsComprimir.Name = "tsComprimir";
            this.tsComprimir.Size = new System.Drawing.Size(93, 22);
            this.tsComprimir.Text = "COMPRIMIR";
            this.tsComprimir.Click += new System.EventHandler(this.tsComprimir_Click);
            // 
            // tsDescomprimir
            // 
            this.tsDescomprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsDescomprimir.Image")));
            this.tsDescomprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDescomprimir.Name = "tsDescomprimir";
            this.tsDescomprimir.Size = new System.Drawing.Size(113, 22);
            this.tsDescomprimir.Text = "DESCOMPRIMIR";
            this.tsDescomprimir.Click += new System.EventHandler(this.tsDescomprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsSalir
            // 
            this.tsSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsSalir.Image")));
            this.tsSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(57, 22);
            this.tsSalir.Text = "SALIR";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.Location = new System.Drawing.Point(16, 39);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(752, 357);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "";
            // 
            // frmComprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmComprimir";
            this.Text = "Proyecto1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAbrir;
        private System.Windows.Forms.ToolStripButton tsGuardar;
        private System.Windows.Forms.ToolStripButton tsComprimir;
        private System.Windows.Forms.ToolStripButton tsDescomprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsSalir;
        private System.Windows.Forms.RichTextBox txtEditor;
    }
}