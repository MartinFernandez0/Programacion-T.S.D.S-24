namespace FotosDesktop
{
    partial class MenuInicioFotosView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicioFotosView));
            btnFotosInicio = new Button();
            SuspendLayout();
            // 
            // btnFotosInicio
            // 
            resources.ApplyResources(btnFotosInicio, "btnFotosInicio");
            btnFotosInicio.BackColor = SystemColors.Desktop;
            btnFotosInicio.Cursor = Cursors.Hand;
            btnFotosInicio.ForeColor = SystemColors.HighlightText;
            btnFotosInicio.Name = "btnFotosInicio";
            btnFotosInicio.UseVisualStyleBackColor = false;
            btnFotosInicio.Click += btnFotosInicio_Click;
            // 
            // MenuInicioFotosView
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnFotosInicio);
            Name = "MenuInicioFotosView";
            ResumeLayout(false);
        }

        #endregion

        private Button btnFotosInicio;
    }
}
