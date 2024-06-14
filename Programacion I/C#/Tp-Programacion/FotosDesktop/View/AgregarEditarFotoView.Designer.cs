namespace FotosDesktop.View
{
    partial class AgregarEditarFotoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarEditarFotoView));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtNombreFoto = new TextBox();
            txtFechaFoto = new TextBox();
            label2 = new Label();
            txtImagenFoto = new TextBox();
            label3 = new Label();
            txtAnecdotaFoto = new TextBox();
            label4 = new Label();
            btnGuardarFoto = new Button();
            btnCancelarFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(345, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txtNombreFoto
            // 
            txtNombreFoto.Location = new Point(23, 76);
            txtNombreFoto.Name = "txtNombreFoto";
            txtNombreFoto.Size = new Size(275, 23);
            txtNombreFoto.TabIndex = 2;
            // 
            // txtFechaFoto
            // 
            txtFechaFoto.Location = new Point(23, 149);
            txtFechaFoto.Name = "txtFechaFoto";
            txtFechaFoto.Size = new Size(275, 23);
            txtFechaFoto.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(23, 117);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha:";
            // 
            // txtImagenFoto
            // 
            txtImagenFoto.Location = new Point(23, 224);
            txtImagenFoto.Name = "txtImagenFoto";
            txtImagenFoto.Size = new Size(275, 23);
            txtImagenFoto.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 192);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 5;
            label3.Text = "Imagen URL:";
            // 
            // txtAnecdotaFoto
            // 
            txtAnecdotaFoto.Location = new Point(23, 297);
            txtAnecdotaFoto.Multiline = true;
            txtAnecdotaFoto.Name = "txtAnecdotaFoto";
            txtAnecdotaFoto.Size = new Size(431, 105);
            txtAnecdotaFoto.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(23, 265);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "Anecdota:";
            // 
            // btnGuardarFoto
            // 
            btnGuardarFoto.Location = new Point(609, 397);
            btnGuardarFoto.Name = "btnGuardarFoto";
            btnGuardarFoto.Size = new Size(91, 41);
            btnGuardarFoto.TabIndex = 9;
            btnGuardarFoto.Text = "Guardar Foto";
            btnGuardarFoto.UseVisualStyleBackColor = true;
            btnGuardarFoto.Click += btnGuardarFoto_Click;
            // 
            // btnCancelarFoto
            // 
            btnCancelarFoto.Location = new Point(753, 397);
            btnCancelarFoto.Name = "btnCancelarFoto";
            btnCancelarFoto.Size = new Size(91, 41);
            btnCancelarFoto.TabIndex = 10;
            btnCancelarFoto.Text = "Cancelar";
            btnCancelarFoto.UseVisualStyleBackColor = true;
            btnCancelarFoto.Click += btnCancelarFoto_Click;
            // 
            // AgregarEditarFotoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 461);
            ControlBox = false;
            Controls.Add(btnCancelarFoto);
            Controls.Add(btnGuardarFoto);
            Controls.Add(txtAnecdotaFoto);
            Controls.Add(label4);
            Controls.Add(txtImagenFoto);
            Controls.Add(label3);
            Controls.Add(txtFechaFoto);
            Controls.Add(label2);
            Controls.Add(txtNombreFoto);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MinimizeBox = false;
            Name = "AgregarEditarFotoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarEditarFotoView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtNombreFoto;
        private TextBox txtFechaFoto;
        private Label label2;
        private TextBox txtImagenFoto;
        private Label label3;
        private TextBox txtAnecdotaFoto;
        private Label label4;
        private Button btnGuardarFoto;
        private Button btnCancelarFoto;
    }
}