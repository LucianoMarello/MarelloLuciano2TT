namespace _2do_Parcial
{
    partial class FormCuentas
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
            gbClientes = new GroupBox();
            btnMostrar = new Button();
            btnAgregar = new Button();
            dgvClientes = new DataGridView();
            dgvCuentas = new DataGridView();
            lblCuentas = new Label();
            gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // gbClientes
            // 
            gbClientes.Controls.Add(btnMostrar);
            gbClientes.Controls.Add(btnAgregar);
            gbClientes.Controls.Add(dgvClientes);
            gbClientes.Location = new Point(12, 12);
            gbClientes.Name = "gbClientes";
            gbClientes.Size = new Size(433, 502);
            gbClientes.TabIndex = 0;
            gbClientes.TabStop = false;
            gbClientes.Text = "Lista Clientes";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(231, 397);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(139, 57);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar todas las Cuentas";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(66, 397);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 57);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Cuenta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(6, 26);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(421, 337);
            dgvClientes.TabIndex = 1;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(451, 38);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(523, 476);
            dgvCuentas.TabIndex = 2;
            // 
            // lblCuentas
            // 
            lblCuentas.AutoSize = true;
            lblCuentas.Location = new Point(451, 15);
            lblCuentas.Name = "lblCuentas";
            lblCuentas.Size = new Size(119, 20);
            lblCuentas.TabIndex = 3;
            lblCuentas.Text = "Lista de Cuentas:";
            // 
            // FormCuentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 526);
            Controls.Add(lblCuentas);
            Controls.Add(dgvCuentas);
            Controls.Add(gbClientes);
            Name = "FormCuentas";
            Text = "Formulario Cuentas";
            gbClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbClientes;
        private DataGridView dgvClientes;
        private DataGridView dgvCuentas;
        private Button btnMostrar;
        private Button btnAgregar;
        private Label lblCuentas;
    }
}