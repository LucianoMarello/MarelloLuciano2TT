namespace _2do_Parcial
{
    partial class FormPrincipal
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
            btnFormClientes = new Button();
            lblTitulo = new Label();
            btnFormCuentas = new Button();
            btnMovimientos = new Button();
            SuspendLayout();
            // 
            // btnFormClientes
            // 
            btnFormClientes.Location = new Point(146, 94);
            btnFormClientes.Name = "btnFormClientes";
            btnFormClientes.Size = new Size(145, 60);
            btnFormClientes.TabIndex = 0;
            btnFormClientes.Text = "Gestionar Clientes";
            btnFormClientes.UseVisualStyleBackColor = true;
            btnFormClientes.Click += btnFormClientes_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(125, 43);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(192, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema Gestión de Cuentas";
            // 
            // btnFormCuentas
            // 
            btnFormCuentas.Location = new Point(146, 182);
            btnFormCuentas.Name = "btnFormCuentas";
            btnFormCuentas.Size = new Size(145, 60);
            btnFormCuentas.TabIndex = 2;
            btnFormCuentas.Text = "Gestionar Cuentas Corrientes";
            btnFormCuentas.UseVisualStyleBackColor = true;
            btnFormCuentas.Click += btnFormCuentas_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.Location = new Point(146, 272);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(145, 60);
            btnMovimientos.TabIndex = 3;
            btnMovimientos.Text = "Registro de Movimientos";
            btnMovimientos.UseVisualStyleBackColor = true;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 403);
            Controls.Add(btnMovimientos);
            Controls.Add(btnFormCuentas);
            Controls.Add(lblTitulo);
            Controls.Add(btnFormClientes);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFormClientes;
        private Label lblTitulo;
        private Button btnFormCuentas;
        private Button btnMovimientos;
    }
}
