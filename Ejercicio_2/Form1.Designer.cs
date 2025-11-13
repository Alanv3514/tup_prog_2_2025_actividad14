namespace Ejercicio_2
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
            label4 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            tbNumeroTarjeta = new TextBox();
            tbTelefono = new TextBox();
            tbNombre = new TextBox();
            tbCUIT = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbDestino = new ComboBox();
            label1 = new Label();
            button4 = new Button();
            btnImportarEjemplo = new Button();
            btnResumen = new Button();
            btnGenerarTicket = new Button();
            cbTransporte = new ComboBox();
            tbPrecio = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 99);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 30;
            label4.Text = "Transporte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 28;
            label2.Text = "Precio";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbNumeroTarjeta);
            groupBox1.Controls.Add(tbTelefono);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(tbCUIT);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(9, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(357, 213);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos pasajero";
            // 
            // tbNumeroTarjeta
            // 
            tbNumeroTarjeta.Location = new Point(103, 167);
            tbNumeroTarjeta.Margin = new Padding(4);
            tbNumeroTarjeta.Name = "tbNumeroTarjeta";
            tbNumeroTarjeta.Size = new Size(242, 23);
            tbNumeroTarjeta.TabIndex = 20;
            // 
            // tbTelefono
            // 
            tbTelefono.Location = new Point(103, 124);
            tbTelefono.Margin = new Padding(4);
            tbTelefono.Name = "tbTelefono";
            tbTelefono.Size = new Size(242, 23);
            tbTelefono.TabIndex = 19;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(102, 81);
            tbNombre.Margin = new Padding(4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(243, 23);
            tbNombre.TabIndex = 18;
            // 
            // tbCUIT
            // 
            tbCUIT.Location = new Point(103, 39);
            tbCUIT.Margin = new Padding(4);
            tbCUIT.Name = "tbCUIT";
            tbCUIT.Size = new Size(242, 23);
            tbCUIT.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 39);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 8;
            label5.Text = "CUIT/CUIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 81);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 124);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 10;
            label7.Text = "Teléfono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 167);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 11;
            label8.Text = "Número Tarjeta";
            // 
            // cbDestino
            // 
            cbDestino.FormattingEnabled = true;
            cbDestino.Location = new Point(111, 11);
            cbDestino.Margin = new Padding(4);
            cbDestino.Name = "cbDestino";
            cbDestino.Size = new Size(166, 23);
            cbDestino.TabIndex = 26;
            cbDestino.SelectedIndexChanged += cbDestino_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 25;
            label1.Text = "Destino";
            // 
            // button4
            // 
            button4.Location = new Point(228, 352);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(96, 32);
            button4.TabIndex = 24;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnImportarEjemplo
            // 
            btnImportarEjemplo.Location = new Point(63, 352);
            btnImportarEjemplo.Margin = new Padding(4);
            btnImportarEjemplo.Name = "btnImportarEjemplo";
            btnImportarEjemplo.Size = new Size(96, 32);
            btnImportarEjemplo.TabIndex = 23;
            btnImportarEjemplo.Text = "Ejemplo";
            btnImportarEjemplo.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(292, 103);
            btnResumen.Margin = new Padding(4);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(74, 25);
            btnResumen.TabIndex = 22;
            btnResumen.Text = "Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // btnGenerarTicket
            // 
            btnGenerarTicket.Location = new Point(292, 11);
            btnGenerarTicket.Margin = new Padding(4);
            btnGenerarTicket.Name = "btnGenerarTicket";
            btnGenerarTicket.Size = new Size(74, 23);
            btnGenerarTicket.TabIndex = 21;
            btnGenerarTicket.Text = "Generar";
            btnGenerarTicket.UseVisualStyleBackColor = true;
            btnGenerarTicket.Click += btnGenerarTicket_Click;
            // 
            // cbTransporte
            // 
            cbTransporte.FormattingEnabled = true;
            cbTransporte.Location = new Point(111, 103);
            cbTransporte.Name = "cbTransporte";
            cbTransporte.Size = new Size(166, 23);
            cbTransporte.TabIndex = 31;
            // 
            // tbPrecio
            // 
            tbPrecio.Location = new Point(111, 56);
            tbPrecio.Name = "tbPrecio";
            tbPrecio.Size = new Size(109, 23);
            tbPrecio.TabIndex = 32;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 411);
            Controls.Add(tbPrecio);
            Controls.Add(cbTransporte);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(cbDestino);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(btnImportarEjemplo);
            Controls.Add(btnResumen);
            Controls.Add(btnGenerarTicket);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox tbNumeroTarjeta;
        private TextBox tbTelefono;
        private TextBox tbNombre;
        private TextBox tbCUIT;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbDestino;
        private Label label1;
        private Button button4;
        private Button btnImportarEjemplo;
        private Button btnResumen;
        private Button btnGenerarTicket;
        private ComboBox cbTransporte;
        private TextBox tbPrecio;
    }
}
