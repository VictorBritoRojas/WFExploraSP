namespace WFExploraSP.Vistas
{
    partial class FrmGeneraScripts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeneraScripts));
            toolStrip1 = new ToolStrip();
            btnCargarExcel = new ToolStripButton();
            cbxHojas = new ToolStripComboBox();
            toolStripButton1 = new ToolStripButton();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            txtConsulta = new RichTextBox();
            dgvHojaSelect = new DataGridView();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHojaSelect).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCargarExcel, cbxHojas, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(714, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCargarExcel
            // 
            btnCargarExcel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCargarExcel.Image = (Image)resources.GetObject("btnCargarExcel.Image");
            btnCargarExcel.ImageTransparentColor = Color.Magenta;
            btnCargarExcel.Name = "btnCargarExcel";
            btnCargarExcel.Size = new Size(120, 22);
            btnCargarExcel.Text = "Cargar Archivo Excel";
            // 
            // cbxHojas
            // 
            cbxHojas.Name = "cbxHojas";
            cbxHojas.Size = new Size(121, 25);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(85, 22);
            toolStripButton1.Text = "Generar Script";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(splitContainer1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 425);
            panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtConsulta);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvHojaSelect);
            splitContainer1.Size = new Size(714, 425);
            splitContainer1.SplitterDistance = 219;
            splitContainer1.TabIndex = 0;
            // 
            // txtConsulta
            // 
            txtConsulta.Dock = DockStyle.Fill;
            txtConsulta.Location = new Point(0, 0);
            txtConsulta.Name = "txtConsulta";
            txtConsulta.Size = new Size(714, 219);
            txtConsulta.TabIndex = 0;
            txtConsulta.Text = "";
            txtConsulta.KeyPress += txtConsulta_KeyPress;
            txtConsulta.KeyUp += txtConsulta_KeyUp;
            // 
            // dgvHojaSelect
            // 
            dgvHojaSelect.AllowUserToAddRows = false;
            dgvHojaSelect.AllowUserToDeleteRows = false;
            dgvHojaSelect.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHojaSelect.Dock = DockStyle.Fill;
            dgvHojaSelect.Location = new Point(0, 0);
            dgvHojaSelect.Name = "dgvHojaSelect";
            dgvHojaSelect.ReadOnly = true;
            dgvHojaSelect.RowTemplate.Height = 25;
            dgvHojaSelect.Size = new Size(714, 202);
            dgvHojaSelect.TabIndex = 0;
            // 
            // FrmGeneraScripts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 450);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGeneraScripts";
            Text = "Generar Scripts";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHojaSelect).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCargarExcel;
        private ToolStripComboBox cbxHojas;
        private ToolStripButton toolStripButton1;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private RichTextBox txtConsulta;
        private DataGridView dgvHojaSelect;
    }
}