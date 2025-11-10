namespace cap_Presentacion.FormAuxiliares
{
    partial class ListUsuarios
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
            dgvListarUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListarUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvListarUsuarios
            // 
            dgvListarUsuarios.AllowUserToAddRows = false;
            dgvListarUsuarios.AllowUserToDeleteRows = false;
            dgvListarUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarUsuarios.Dock = DockStyle.Fill;
            dgvListarUsuarios.Location = new Point(0, 0);
            dgvListarUsuarios.Name = "dgvListarUsuarios";
            dgvListarUsuarios.ReadOnly = true;
            dgvListarUsuarios.RowHeadersWidth = 51;
            dgvListarUsuarios.Size = new Size(800, 450);
            dgvListarUsuarios.TabIndex = 0;
            // 
            // ListUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListarUsuarios);
            Name = "ListUsuarios";
            Text = "ListUsuarios";
            Load += ListUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListarUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListarUsuarios;
    }
}