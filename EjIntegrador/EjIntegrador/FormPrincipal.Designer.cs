namespace Vista
{
    partial class FormPrincipal
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
            lblTituloPrincipal = new Label();
            btnLibros = new Button();
            btnSocios = new Button();
            btnPrestamos = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Location = new Point(91, 41);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(228, 20);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "Sistema de Gestión de Biblioteca";
            // 
            // btnLibros
            // 
            btnLibros.Location = new Point(136, 83);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(140, 59);
            btnLibros.TabIndex = 1;
            btnLibros.Text = "Gestionar Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // btnSocios
            // 
            btnSocios.Location = new Point(136, 164);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new Size(140, 59);
            btnSocios.TabIndex = 2;
            btnSocios.Text = "Gestionar Socios";
            btnSocios.UseVisualStyleBackColor = true;
            btnSocios.Click += btnSocios_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Location = new Point(136, 245);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(140, 59);
            btnPrestamos.TabIndex = 3;
            btnPrestamos.Text = "Gestionar Prestamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(136, 330);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 59);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 427);
            Controls.Add(btnSalir);
            Controls.Add(btnPrestamos);
            Controls.Add(btnSocios);
            Controls.Add(btnLibros);
            Controls.Add(lblTituloPrincipal);
            Name = "FormPrincipal";
            Text = "Formulario Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPrincipal;
        private Button btnLibros;
        private Button btnSocios;
        private Button btnPrestamos;
        private Button btnSalir;
    }
}