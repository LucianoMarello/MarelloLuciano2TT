namespace Vista
{
    partial class FormSocios
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
            dgvSocios = new DataGridView();
            gbSocios = new GroupBox();
            btnEliminarSocio = new Button();
            btnModificarSocio = new Button();
            btnAgregarSocio = new Button();
            txtTelefonoSocio = new TextBox();
            lblTelefonoSocio = new Label();
            lblEmailSocio = new Label();
            txtEmailSocio = new TextBox();
            lblNombreSocio = new Label();
            txtNombreSocio = new TextBox();
            lblDniSocio = new Label();
            txtDniSocio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            gbSocios.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(420, 91);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.RowHeadersWidth = 51;
            dgvSocios.Size = new Size(416, 273);
            dgvSocios.TabIndex = 7;
            // 
            // gbSocios
            // 
            gbSocios.Controls.Add(btnEliminarSocio);
            gbSocios.Controls.Add(btnModificarSocio);
            gbSocios.Controls.Add(btnAgregarSocio);
            gbSocios.Controls.Add(txtTelefonoSocio);
            gbSocios.Controls.Add(lblTelefonoSocio);
            gbSocios.Controls.Add(lblEmailSocio);
            gbSocios.Controls.Add(txtEmailSocio);
            gbSocios.Controls.Add(lblNombreSocio);
            gbSocios.Controls.Add(txtNombreSocio);
            gbSocios.Controls.Add(lblDniSocio);
            gbSocios.Controls.Add(txtDniSocio);
            gbSocios.Location = new Point(30, 55);
            gbSocios.Name = "gbSocios";
            gbSocios.Size = new Size(812, 315);
            gbSocios.TabIndex = 6;
            gbSocios.TabStop = false;
            gbSocios.Text = "Datos Socios";
            // 
            // btnEliminarSocio
            // 
            btnEliminarSocio.Location = new Point(252, 239);
            btnEliminarSocio.Name = "btnEliminarSocio";
            btnEliminarSocio.Size = new Size(98, 43);
            btnEliminarSocio.TabIndex = 13;
            btnEliminarSocio.Text = "Eliminar";
            btnEliminarSocio.UseVisualStyleBackColor = true;
            // 
            // btnModificarSocio
            // 
            btnModificarSocio.Location = new Point(138, 239);
            btnModificarSocio.Name = "btnModificarSocio";
            btnModificarSocio.Size = new Size(98, 43);
            btnModificarSocio.TabIndex = 12;
            btnModificarSocio.Text = "Modificar";
            btnModificarSocio.UseVisualStyleBackColor = true;
            // 
            // btnAgregarSocio
            // 
            btnAgregarSocio.Location = new Point(18, 239);
            btnAgregarSocio.Name = "btnAgregarSocio";
            btnAgregarSocio.Size = new Size(98, 43);
            btnAgregarSocio.TabIndex = 11;
            btnAgregarSocio.Text = "Agregar";
            btnAgregarSocio.UseVisualStyleBackColor = true;
            // 
            // txtTelefonoSocio
            // 
            txtTelefonoSocio.Location = new Point(136, 185);
            txtTelefonoSocio.Name = "txtTelefonoSocio";
            txtTelefonoSocio.Size = new Size(192, 27);
            txtTelefonoSocio.TabIndex = 10;
            // 
            // lblTelefonoSocio
            // 
            lblTelefonoSocio.AutoSize = true;
            lblTelefonoSocio.Location = new Point(18, 188);
            lblTelefonoSocio.Name = "lblTelefonoSocio";
            lblTelefonoSocio.Size = new Size(70, 20);
            lblTelefonoSocio.TabIndex = 9;
            lblTelefonoSocio.Text = "Teléfono:";
            // 
            // lblEmailSocio
            // 
            lblEmailSocio.AutoSize = true;
            lblEmailSocio.Location = new Point(18, 136);
            lblEmailSocio.Name = "lblEmailSocio";
            lblEmailSocio.Size = new Size(49, 20);
            lblEmailSocio.TabIndex = 8;
            lblEmailSocio.Text = "Email:";
            // 
            // txtEmailSocio
            // 
            txtEmailSocio.Location = new Point(137, 133);
            txtEmailSocio.Name = "txtEmailSocio";
            txtEmailSocio.Size = new Size(192, 27);
            txtEmailSocio.TabIndex = 2;
            // 
            // lblNombreSocio
            // 
            lblNombreSocio.AutoSize = true;
            lblNombreSocio.Location = new Point(18, 87);
            lblNombreSocio.Name = "lblNombreSocio";
            lblNombreSocio.Size = new Size(67, 20);
            lblNombreSocio.TabIndex = 7;
            lblNombreSocio.Text = "Nombre:";
            // 
            // txtNombreSocio
            // 
            txtNombreSocio.Location = new Point(137, 84);
            txtNombreSocio.Name = "txtNombreSocio";
            txtNombreSocio.Size = new Size(192, 27);
            txtNombreSocio.TabIndex = 1;
            // 
            // lblDniSocio
            // 
            lblDniSocio.AutoSize = true;
            lblDniSocio.Location = new Point(18, 39);
            lblDniSocio.Name = "lblDniSocio";
            lblDniSocio.Size = new Size(38, 20);
            lblDniSocio.TabIndex = 6;
            lblDniSocio.Text = "DNI:";
            // 
            // txtDniSocio
            // 
            txtDniSocio.Location = new Point(137, 36);
            txtDniSocio.Name = "txtDniSocio";
            txtDniSocio.Size = new Size(192, 27);
            txtDniSocio.TabIndex = 0;
            // 
            // FormSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 559);
            Controls.Add(dgvSocios);
            Controls.Add(gbSocios);
            Name = "FormSocios";
            Text = "FormSocios";
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            gbSocios.ResumeLayout(false);
            gbSocios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSocios;
        private GroupBox gbSocios;
        private Button btnEliminarSocio;
        private Button btnModificarSocio;
        private Button btnAgregarSocio;
        private TextBox txtTelefonoSocio;
        private Label lblTelefonoSocio;
        private Label lblEmailSocio;
        private TextBox txtEmailSocio;
        private Label lblNombreSocio;
        private TextBox txtNombreSocio;
        private Label lblDniSocio;
        private TextBox txtDniSocio;
    }
}