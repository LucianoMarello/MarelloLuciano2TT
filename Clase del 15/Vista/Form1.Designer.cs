namespace Vista
{
    partial class Form1
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
            dgvJugadores = new DataGridView();
            txtNombre = new TextBox();
            dtpFechaPartida = new DateTimePicker();
            dtpNacimiento = new DateTimePicker();
            lblNombre = new Label();
            lblFechaNacimiento = new Label();
            lblFechaPartida = new Label();
            btnAgregarJugador = new Button();
            btnAgregarPartida = new Button();
            gbJugadores = new GroupBox();
            gbRegistroPartidas = new GroupBox();
            dgvPartidas = new DataGridView();
            gbDatos = new GroupBox();
            dgvDatosPartida = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).BeginInit();
            gbJugadores.SuspendLayout();
            gbRegistroPartidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).BeginInit();
            gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatosPartida).BeginInit();
            SuspendLayout();
            // 
            // dgvJugadores
            // 
            dgvJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvJugadores.Location = new Point(6, 33);
            dgvJugadores.Name = "dgvJugadores";
            dgvJugadores.RowHeadersWidth = 51;
            dgvJugadores.Size = new Size(366, 352);
            dgvJugadores.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 404);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 27);
            txtNombre.TabIndex = 1;
            // 
            // dtpFechaPartida
            // 
            dtpFechaPartida.Location = new Point(18, 449);
            dtpFechaPartida.Name = "dtpFechaPartida";
            dtpFechaPartida.Size = new Size(279, 27);
            dtpFechaPartida.TabIndex = 2;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Location = new Point(116, 447);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(232, 27);
            dtpNacimiento.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 407);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(21, 451);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(89, 20);
            lblFechaNacimiento.TabIndex = 5;
            lblFechaNacimiento.Text = "Nacimiento:";
            // 
            // lblFechaPartida
            // 
            lblFechaPartida.AutoSize = true;
            lblFechaPartida.Location = new Point(18, 423);
            lblFechaPartida.Name = "lblFechaPartida";
            lblFechaPartida.Size = new Size(100, 20);
            lblFechaPartida.TabIndex = 6;
            lblFechaPartida.Text = "Fecha Partida:";
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.Location = new Point(116, 495);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(157, 53);
            btnAgregarJugador.TabIndex = 7;
            btnAgregarJugador.Text = "Asignar Jugador";
            btnAgregarJugador.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPartida
            // 
            btnAgregarPartida.Location = new Point(81, 495);
            btnAgregarPartida.Name = "btnAgregarPartida";
            btnAgregarPartida.Size = new Size(157, 53);
            btnAgregarPartida.TabIndex = 8;
            btnAgregarPartida.Text = "Registrar Partida";
            btnAgregarPartida.UseVisualStyleBackColor = true;
            btnAgregarPartida.Click += btnAgregarPartida_Click;
            // 
            // gbJugadores
            // 
            gbJugadores.Controls.Add(txtNombre);
            gbJugadores.Controls.Add(dgvJugadores);
            gbJugadores.Controls.Add(btnAgregarJugador);
            gbJugadores.Controls.Add(lblNombre);
            gbJugadores.Controls.Add(lblFechaNacimiento);
            gbJugadores.Controls.Add(dtpNacimiento);
            gbJugadores.Location = new Point(345, 12);
            gbJugadores.Name = "gbJugadores";
            gbJugadores.Size = new Size(378, 569);
            gbJugadores.TabIndex = 9;
            gbJugadores.TabStop = false;
            gbJugadores.Text = "Registro Jugadores";
            // 
            // gbRegistroPartidas
            // 
            gbRegistroPartidas.Controls.Add(dgvPartidas);
            gbRegistroPartidas.Controls.Add(btnAgregarPartida);
            gbRegistroPartidas.Controls.Add(dtpFechaPartida);
            gbRegistroPartidas.Controls.Add(lblFechaPartida);
            gbRegistroPartidas.Location = new Point(12, 12);
            gbRegistroPartidas.Name = "gbRegistroPartidas";
            gbRegistroPartidas.Size = new Size(327, 569);
            gbRegistroPartidas.TabIndex = 10;
            gbRegistroPartidas.TabStop = false;
            gbRegistroPartidas.Text = "Registro Partidas";
            // 
            // dgvPartidas
            // 
            dgvPartidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPartidas.Location = new Point(6, 33);
            dgvPartidas.Name = "dgvPartidas";
            dgvPartidas.RowHeadersWidth = 51;
            dgvPartidas.Size = new Size(315, 381);
            dgvPartidas.TabIndex = 9;
            // 
            // gbDatos
            // 
            gbDatos.Controls.Add(dgvDatosPartida);
            gbDatos.Location = new Point(729, 12);
            gbDatos.Name = "gbDatos";
            gbDatos.Size = new Size(448, 569);
            gbDatos.TabIndex = 11;
            gbDatos.TabStop = false;
            gbDatos.Text = "Datos Partidas";
            // 
            // dgvDatosPartida
            // 
            dgvDatosPartida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatosPartida.Location = new Point(6, 33);
            dgvDatosPartida.Name = "dgvDatosPartida";
            dgvDatosPartida.RowHeadersWidth = 51;
            dgvDatosPartida.Size = new Size(436, 443);
            dgvDatosPartida.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1189, 593);
            Controls.Add(gbDatos);
            Controls.Add(gbRegistroPartidas);
            Controls.Add(gbJugadores);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvJugadores).EndInit();
            gbJugadores.ResumeLayout(false);
            gbJugadores.PerformLayout();
            gbRegistroPartidas.ResumeLayout(false);
            gbRegistroPartidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPartidas).EndInit();
            gbDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDatosPartida).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvJugadores;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaPartida;
        private DateTimePicker dtpNacimiento;
        private Label lblNombre;
        private Label lblFechaNacimiento;
        private Label lblFechaPartida;
        private Button btnAgregarJugador;
        private Button btnAgregarPartida;
        private GroupBox gbJugadores;
        private GroupBox gbRegistroPartidas;
        private DataGridView dgvPartidas;
        private GroupBox gbDatos;
        private DataGridView dgvDatosPartida;
    }
}
