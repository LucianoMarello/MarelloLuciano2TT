namespace EjIntegrador
{
    partial class FormLibros
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
            gbLibros = new GroupBox();
            btnLimpiar = new Button();
            btnEliminarLibro = new Button();
            btnModificarLibro = new Button();
            btnAgregarLibro = new Button();
            chkDisponible = new CheckBox();
            lblEstadoLibro = new Label();
            lblAutorLibro = new Label();
            lblTituloLibro = new Label();
            lblIsbn = new Label();
            txtAutorLibro = new TextBox();
            txtTituloLibro = new TextBox();
            txtIsbnLibro = new TextBox();
            dgvLibros = new DataGridView();
            lblLibrosRegistrados = new Label();
            lblFormatoISBN = new Label();
            gbLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // gbLibros
            // 
            gbLibros.Controls.Add(lblFormatoISBN);
            gbLibros.Controls.Add(btnLimpiar);
            gbLibros.Controls.Add(btnEliminarLibro);
            gbLibros.Controls.Add(btnModificarLibro);
            gbLibros.Controls.Add(btnAgregarLibro);
            gbLibros.Controls.Add(chkDisponible);
            gbLibros.Controls.Add(lblEstadoLibro);
            gbLibros.Controls.Add(lblAutorLibro);
            gbLibros.Controls.Add(lblTituloLibro);
            gbLibros.Controls.Add(lblIsbn);
            gbLibros.Controls.Add(txtAutorLibro);
            gbLibros.Controls.Add(txtTituloLibro);
            gbLibros.Controls.Add(txtIsbnLibro);
            gbLibros.Location = new Point(12, 12);
            gbLibros.Name = "gbLibros";
            gbLibros.Size = new Size(358, 452);
            gbLibros.TabIndex = 0;
            gbLibros.TabStop = false;
            gbLibros.Text = "Datos Libros";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(187, 278);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(144, 43);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(187, 346);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(144, 43);
            btnEliminarLibro.TabIndex = 10;
            btnEliminarLibro.Text = "Eliminar";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            btnEliminarLibro.Click += btnEliminarLibro_Click;
            // 
            // btnModificarLibro
            // 
            btnModificarLibro.Location = new Point(19, 346);
            btnModificarLibro.Name = "btnModificarLibro";
            btnModificarLibro.Size = new Size(144, 43);
            btnModificarLibro.TabIndex = 9;
            btnModificarLibro.Text = "Modificar";
            btnModificarLibro.UseVisualStyleBackColor = true;
            btnModificarLibro.Click += btnModificarLibro_Click;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(19, 278);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(144, 43);
            btnAgregarLibro.TabIndex = 8;
            btnAgregarLibro.Text = "Agregar";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(93, 220);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(103, 24);
            chkDisponible.TabIndex = 7;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // lblEstadoLibro
            // 
            lblEstadoLibro.AutoSize = true;
            lblEstadoLibro.Location = new Point(19, 221);
            lblEstadoLibro.Name = "lblEstadoLibro";
            lblEstadoLibro.Size = new Size(57, 20);
            lblEstadoLibro.TabIndex = 6;
            lblEstadoLibro.Text = "Estado:";
            // 
            // lblAutorLibro
            // 
            lblAutorLibro.AutoSize = true;
            lblAutorLibro.Location = new Point(18, 167);
            lblAutorLibro.Name = "lblAutorLibro";
            lblAutorLibro.Size = new Size(49, 20);
            lblAutorLibro.TabIndex = 5;
            lblAutorLibro.Text = "Autor:";
            // 
            // lblTituloLibro
            // 
            lblTituloLibro.AutoSize = true;
            lblTituloLibro.Location = new Point(18, 111);
            lblTituloLibro.Name = "lblTituloLibro";
            lblTituloLibro.Size = new Size(50, 20);
            lblTituloLibro.TabIndex = 4;
            lblTituloLibro.Text = "Título:";
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(18, 40);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(44, 20);
            lblIsbn.TabIndex = 3;
            lblIsbn.Text = "ISBN:";
            // 
            // txtAutorLibro
            // 
            txtAutorLibro.Location = new Point(93, 164);
            txtAutorLibro.Name = "txtAutorLibro";
            txtAutorLibro.Size = new Size(238, 27);
            txtAutorLibro.TabIndex = 2;
            // 
            // txtTituloLibro
            // 
            txtTituloLibro.Location = new Point(93, 108);
            txtTituloLibro.Name = "txtTituloLibro";
            txtTituloLibro.Size = new Size(238, 27);
            txtTituloLibro.TabIndex = 1;
            // 
            // txtIsbnLibro
            // 
            txtIsbnLibro.Location = new Point(93, 37);
            txtIsbnLibro.Name = "txtIsbnLibro";
            txtIsbnLibro.Size = new Size(238, 27);
            txtIsbnLibro.TabIndex = 0;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(387, 35);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(784, 429);
            dgvLibros.TabIndex = 4;
            dgvLibros.SelectionChanged += dgvLibros_SelectionChanged;
            // 
            // lblLibrosRegistrados
            // 
            lblLibrosRegistrados.AutoSize = true;
            lblLibrosRegistrados.Location = new Point(390, 12);
            lblLibrosRegistrados.Name = "lblLibrosRegistrados";
            lblLibrosRegistrados.Size = new Size(134, 20);
            lblLibrosRegistrados.TabIndex = 11;
            lblLibrosRegistrados.Text = "Libros Registrados:";
            // 
            // lblFormatoISBN
            // 
            lblFormatoISBN.AutoSize = true;
            lblFormatoISBN.Location = new Point(93, 67);
            lblFormatoISBN.Name = "lblFormatoISBN";
            lblFormatoISBN.Size = new Size(213, 20);
            lblFormatoISBN.TabIndex = 12;
            lblFormatoISBN.Text = "Formato: XXX-X-XXXX-XXXX-X";
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1183, 476);
            Controls.Add(lblLibrosRegistrados);
            Controls.Add(dgvLibros);
            Controls.Add(gbLibros);
            Name = "FormLibros";
            Text = "Formulario Biblioteca";
            gbLibros.ResumeLayout(false);
            gbLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbLibros;
        private TextBox txtAutorLibro;
        private TextBox txtTituloLibro;
        private TextBox txtIsbnLibro;
        private Label lblAutorLibro;
        private Label lblTituloLibro;
        private Label lblIsbn;
        private DataGridView dgvLibros;
        private Label lblEstadoLibro;
        private CheckBox chkDisponible;
        private Button btnEliminarLibro;
        private Button btnModificarLibro;
        private Button btnAgregarLibro;
        private Label lblLibrosRegistrados;
        private Button btnLimpiar;
        private Label lblFormatoISBN;
    }
}
