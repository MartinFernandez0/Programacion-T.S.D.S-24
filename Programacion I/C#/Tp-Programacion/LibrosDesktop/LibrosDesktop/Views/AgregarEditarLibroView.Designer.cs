namespace LibrosDesktop.Views
{
    partial class AgregarEditarLibroView
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
            label1 = new Label();
            txtNombre = new TextBox();
            txtAutor = new TextBox();
            label2 = new Label();
            txtEditorial = new TextBox();
            label3 = new Label();
            txtPortadaUrl = new TextBox();
            label4 = new Label();
            txtSinopsis = new TextBox();
            label5 = new Label();
            numericUpDownPaginas = new NumericUpDown();
            label6 = new Label();
            txtGenero = new TextBox();
            label7 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            pictureBoxPortada = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortada).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 41);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(526, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(150, 79);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(526, 23);
            txtAutor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 82);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Autor:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(150, 117);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(526, 23);
            txtEditorial.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 120);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 4;
            label3.Text = "Editorial:";
            // 
            // txtPortadaUrl
            // 
            txtPortadaUrl.Location = new Point(150, 153);
            txtPortadaUrl.Name = "txtPortadaUrl";
            txtPortadaUrl.Size = new Size(526, 23);
            txtPortadaUrl.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 156);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "Portada URL:";
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(150, 380);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(526, 77);
            txtSinopsis.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 383);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "Sinopsis:";
            // 
            // numericUpDownPaginas
            // 
            numericUpDownPaginas.Location = new Point(150, 476);
            numericUpDownPaginas.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPaginas.Name = "numericUpDownPaginas";
            numericUpDownPaginas.Size = new Size(120, 23);
            numericUpDownPaginas.TabIndex = 10;
            numericUpDownPaginas.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 478);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Paginas:";
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(150, 524);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(526, 23);
            txtGenero.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 527);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 12;
            label7.Text = "Genero:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(372, 570);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(276, 570);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 30);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pictureBoxPortada
            // 
            pictureBoxPortada.Location = new Point(276, 182);
            pictureBoxPortada.Name = "pictureBoxPortada";
            pictureBoxPortada.Size = new Size(236, 192);
            pictureBoxPortada.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPortada.TabIndex = 16;
            pictureBoxPortada.TabStop = false;
            // 
            // AgregarEditarLibroView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 699);
            Controls.Add(pictureBoxPortada);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtGenero);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numericUpDownPaginas);
            Controls.Add(txtSinopsis);
            Controls.Add(label5);
            Controls.Add(txtPortadaUrl);
            Controls.Add(label4);
            Controls.Add(txtEditorial);
            Controls.Add(label3);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "AgregarEditarLibroView";
            Text = "AgregarEditarLibroView";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPaginas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtAutor;
        private Label label2;
        private TextBox txtEditorial;
        private Label label3;
        private TextBox txtPortadaUrl;
        private Label label4;
        private TextBox txtSinopsis;
        private Label label5;
        private NumericUpDown numericUpDownPaginas;
        private Label label6;
        private TextBox txtGenero;
        private Label label7;
        private Button btnCancelar;
        private Button btnGuardar;
        private PictureBox pictureBoxPortada;
    }
}