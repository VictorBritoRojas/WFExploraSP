namespace WFExploraSP.Vistas
{
    partial class FrmConexionBD
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
            button1 = new Button();
            label1 = new Label();
            txtServidor = new TextBox();
            txtDB = new TextBox();
            label2 = new Label();
            txtUser = new TextBox();
            label3 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label5 = new Label();
            ckbxSeguridadIntegrada = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(17, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 53);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Servidor";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(129, 53);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(142, 23);
            txtServidor.TabIndex = 2;
            // 
            // txtDB
            // 
            txtDB.Location = new Point(129, 97);
            txtDB.Name = "txtDB";
            txtDB.Size = new Size(142, 23);
            txtDB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 97);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Base Datos";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(129, 139);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(142, 23);
            txtUser.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 139);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(129, 188);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(142, 23);
            txtPass.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 188);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Contraseña";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(142, 23);
            txtNombre.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 15);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 9;
            label5.Text = "Nombre Conexion";
            // 
            // ckbxSeguridadIntegrada
            // 
            ckbxSeguridadIntegrada.AutoSize = true;
            ckbxSeguridadIntegrada.Location = new Point(18, 231);
            ckbxSeguridadIntegrada.Name = "ckbxSeguridadIntegrada";
            ckbxSeguridadIntegrada.Size = new Size(132, 19);
            ckbxSeguridadIntegrada.TabIndex = 11;
            ckbxSeguridadIntegrada.Text = "Seguridad Integrada";
            ckbxSeguridadIntegrada.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(129, 293);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmConexionBD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(ckbxSeguridadIntegrada);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(txtDB);
            Controls.Add(label2);
            Controls.Add(txtServidor);
            Controls.Add(label1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmConexionBD";
            Text = "Conexiones a BD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox txtServidor;
        private TextBox txtDB;
        private Label label2;
        private TextBox txtUser;
        private Label label3;
        private TextBox txtPass;
        private Label label4;
        private TextBox txtNombre;
        private Label label5;
        private CheckBox ckbxSeguridadIntegrada;
        private Button button2;
    }
}