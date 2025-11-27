namespace Vista
{
    partial class FormPrestamos
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
            gbPrestamos = new GroupBox();
            dgvPrestamos = new DataGridView();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            gbPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // gbPrestamos
            // 
            gbPrestamos.Controls.Add(dgvPrestamos);
            gbPrestamos.Controls.Add(button6);
            gbPrestamos.Controls.Add(button7);
            gbPrestamos.Controls.Add(button8);
            gbPrestamos.Controls.Add(checkBox1);
            gbPrestamos.Controls.Add(label1);
            gbPrestamos.Controls.Add(label2);
            gbPrestamos.Controls.Add(label3);
            gbPrestamos.Controls.Add(label4);
            gbPrestamos.Controls.Add(textBox1);
            gbPrestamos.Controls.Add(textBox2);
            gbPrestamos.Controls.Add(textBox3);
            gbPrestamos.Location = new Point(12, 12);
            gbPrestamos.Name = "gbPrestamos";
            gbPrestamos.Size = new Size(907, 451);
            gbPrestamos.TabIndex = 12;
            gbPrestamos.TabStop = false;
            gbPrestamos.Text = "Datos Prestamos";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(433, 60);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.Size = new Size(322, 262);
            dgvPrestamos.TabIndex = 6;
            // 
            // button6
            // 
            button6.Location = new Point(252, 245);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 10;
            button6.Text = "button1";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(138, 245);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 9;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(19, 245);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 8;
            button8.Text = "button1";
            button8.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(138, 187);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Disponible";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 188);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 6;
            label1.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 137);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 88);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Título:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 40);
            label4.Name = "label4";
            label4.Size = new Size(44, 20);
            label4.TabIndex = 3;
            label4.Text = "ISBN:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(192, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(137, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(192, 27);
            textBox3.TabIndex = 0;
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 577);
            Controls.Add(gbPrestamos);
            Name = "FormPrestamos";
            Text = "FormPrestamos";
            gbPrestamos.ResumeLayout(false);
            gbPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbPrestamos;
        private DataGridView dgvPrestamos;
        private Button button6;
        private Button button7;
        private Button button8;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}