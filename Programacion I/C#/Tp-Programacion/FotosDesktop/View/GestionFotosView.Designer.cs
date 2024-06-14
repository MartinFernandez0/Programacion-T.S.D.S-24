namespace FotosDesktop
{
    partial class GestionFotosView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionFotosView));
            dataGridFotosMonsterView = new DataGridView();
            fotosMonsterRepositoryBindingSource = new BindingSource(components);
            fotosMonsterRepositoryBindingSource1 = new BindingSource(components);
            btnAgregarFoto = new Button();
            btnEditarFoto = new Button();
            btnEliminarFoto = new Button();
            btnSalirFotos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridFotosMonsterView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotosMonsterRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fotosMonsterRepositoryBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridFotosMonsterView
            // 
            dataGridFotosMonsterView.BackgroundColor = SystemColors.ScrollBar;
            dataGridFotosMonsterView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFotosMonsterView.Location = new Point(24, 21);
            dataGridFotosMonsterView.Name = "dataGridFotosMonsterView";
            dataGridFotosMonsterView.Size = new Size(522, 304);
            dataGridFotosMonsterView.TabIndex = 0;
            // 
            // fotosMonsterRepositoryBindingSource
            // 
            fotosMonsterRepositoryBindingSource.DataSource = typeof(TP_PDF.Repositories.FotosMonsterRepository);
            // 
            // fotosMonsterRepositoryBindingSource1
            // 
            fotosMonsterRepositoryBindingSource1.DataSource = typeof(TP_PDF.Repositories.FotosMonsterRepository);
            // 
            // btnAgregarFoto
            // 
            btnAgregarFoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarFoto.Location = new Point(50, 384);
            btnAgregarFoto.Name = "btnAgregarFoto";
            btnAgregarFoto.Size = new Size(98, 41);
            btnAgregarFoto.TabIndex = 1;
            btnAgregarFoto.Text = "&Agregar";
            btnAgregarFoto.UseVisualStyleBackColor = true;
            btnAgregarFoto.Click += btnAgregarFoto_Click;
            // 
            // btnEditarFoto
            // 
            btnEditarFoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditarFoto.Location = new Point(230, 384);
            btnEditarFoto.Name = "btnEditarFoto";
            btnEditarFoto.Size = new Size(98, 41);
            btnEditarFoto.TabIndex = 2;
            btnEditarFoto.Text = "&Editar";
            btnEditarFoto.UseVisualStyleBackColor = true;
            btnEditarFoto.Click += btnEditarFoto_Click;
            // 
            // btnEliminarFoto
            // 
            btnEliminarFoto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminarFoto.Location = new Point(412, 384);
            btnEliminarFoto.Name = "btnEliminarFoto";
            btnEliminarFoto.Size = new Size(91, 41);
            btnEliminarFoto.TabIndex = 3;
            btnEliminarFoto.Text = "El&iminar";
            btnEliminarFoto.UseVisualStyleBackColor = true;
            btnEliminarFoto.Click += btnEliminarFoto_Click;
            // 
            // btnSalirFotos
            // 
            btnSalirFotos.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalirFotos.Location = new Point(836, 426);
            btnSalirFotos.Name = "btnSalirFotos";
            btnSalirFotos.Size = new Size(75, 23);
            btnSalirFotos.TabIndex = 4;
            btnSalirFotos.Text = "Salir";
            btnSalirFotos.UseVisualStyleBackColor = true;
            btnSalirFotos.Click += btnSalirFotos_Click;
            // 
            // GestionFotosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 461);
            Controls.Add(btnSalirFotos);
            Controls.Add(btnEliminarFoto);
            Controls.Add(btnEditarFoto);
            Controls.Add(btnAgregarFoto);
            Controls.Add(dataGridFotosMonsterView);
            Name = "GestionFotosView";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionFotosView";
            ((System.ComponentModel.ISupportInitialize)dataGridFotosMonsterView).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotosMonsterRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)fotosMonsterRepositoryBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridFotosMonsterView;
        private BindingSource fotosMonsterRepositoryBindingSource;
        private BindingSource fotosMonsterRepositoryBindingSource1;
        private Button btnAgregarFoto;
        private Button btnEditarFoto;
        private Button btnEliminarFoto;
        private Button btnSalirFotos;
    }
}