namespace _2do_Parcial
{
    partial class FormClientes
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
            dgvClientes = new DataGridView();
            gbCliente = new GroupBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            txtTelefono = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblClientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            gbCliente.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(387, 35);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(658, 409);
            dgvClientes.TabIndex = 0;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // gbCliente
            // 
            gbCliente.Controls.Add(btnLimpiar);
            gbCliente.Controls.Add(btnEliminar);
            gbCliente.Controls.Add(btnModificar);
            gbCliente.Controls.Add(btnAgregar);
            gbCliente.Controls.Add(txtTelefono);
            gbCliente.Controls.Add(txtDni);
            gbCliente.Controls.Add(txtApellido);
            gbCliente.Controls.Add(txtNombre);
            gbCliente.Controls.Add(lblTelefono);
            gbCliente.Controls.Add(lblDni);
            gbCliente.Controls.Add(lblApellido);
            gbCliente.Controls.Add(lblNombre);
            gbCliente.Location = new Point(12, 12);
            gbCliente.Name = "gbCliente";
            gbCliente.Size = new Size(356, 432);
            gbCliente.TabIndex = 1;
            gbCliente.TabStop = false;
            gbCliente.Text = "Datos Cliente";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(32, 352);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 50);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(195, 352);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 50);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(195, 272);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 50);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(32, 272);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 50);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(124, 199);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(201, 27);
            txtTelefono.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(124, 148);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(201, 27);
            txtDni.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(124, 97);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(201, 27);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(32, 202);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(32, 151);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(38, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(32, 100);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Location = new Point(387, 12);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(116, 20);
            lblClientes.TabIndex = 12;
            lblClientes.Text = "Lista de Clientes";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 456);
            Controls.Add(lblClientes);
            Controls.Add(gbCliente);
            Controls.Add(dgvClientes);
            Name = "FormClientes";
            Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            gbCliente.ResumeLayout(false);
            gbCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private GroupBox gbCliente;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private TextBox txtTelefono;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblClientes;
    }
}