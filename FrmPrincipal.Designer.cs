namespace WFExploraSP
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            tsBarraOpciones = new ToolStrip();
            btnConexionBD = new ToolStripButton();
            btnAnalizaSp = new ToolStripButton();
            btnGeneraScript = new ToolStripButton();
            fswVigilante = new FileSystemWatcher();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            pnlContenedor = new Panel();
            tsBarraOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fswVigilante).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tsBarraOpciones
            // 
            tsBarraOpciones.Items.AddRange(new ToolStripItem[] { btnConexionBD, btnAnalizaSp, btnGeneraScript });
            tsBarraOpciones.Location = new Point(0, 0);
            tsBarraOpciones.Name = "tsBarraOpciones";
            tsBarraOpciones.Size = new Size(800, 25);
            tsBarraOpciones.TabIndex = 0;
            tsBarraOpciones.Text = "toolStrip1";
            // 
            // btnConexionBD
            // 
            btnConexionBD.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnConexionBD.Image = (Image)resources.GetObject("btnConexionBD.Image");
            btnConexionBD.ImageTransparentColor = Color.Magenta;
            btnConexionBD.Name = "btnConexionBD";
            btnConexionBD.Size = new Size(100, 22);
            btnConexionBD.Text = "Conexiones a BD";
            btnConexionBD.Click += btnConexionBD_Click;
            // 
            // btnAnalizaSp
            // 
            btnAnalizaSp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnAnalizaSp.Image = (Image)resources.GetObject("btnAnalizaSp.Image");
            btnAnalizaSp.ImageTransparentColor = Color.Magenta;
            btnAnalizaSp.Name = "btnAnalizaSp";
            btnAnalizaSp.Size = new Size(69, 22);
            btnAnalizaSp.Text = "Analizar SP";
            btnAnalizaSp.Click += btnAnalizaSp_Click;
            // 
            // btnGeneraScript
            // 
            btnGeneraScript.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnGeneraScript.Image = (Image)resources.GetObject("btnGeneraScript.Image");
            btnGeneraScript.ImageTransparentColor = Color.Magenta;
            btnGeneraScript.Name = "btnGeneraScript";
            btnGeneraScript.Size = new Size(90, 22);
            btnGeneraScript.Text = "Generar Scripts";
            btnGeneraScript.Click += btnGeneraScript_Click;
            // 
            // fswVigilante
            // 
            fswVigilante.EnableRaisingEvents = true;
            fswVigilante.SynchronizingObject = this;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(0, 25);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(800, 403);
            pnlContenedor.TabIndex = 2;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContenedor);
            Controls.Add(statusStrip1);
            Controls.Add(tsBarraOpciones);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            tsBarraOpciones.ResumeLayout(false);
            tsBarraOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fswVigilante).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsBarraOpciones;
        private ToolStripButton btnConexionBD;
        private ToolStripButton btnAnalizaSp;
        private FileSystemWatcher fswVigilante;
        private ToolStripButton btnGeneraScript;
        private Panel pnlContenedor;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}