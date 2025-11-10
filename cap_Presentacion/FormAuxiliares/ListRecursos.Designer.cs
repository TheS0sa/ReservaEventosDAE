namespace cap_Presentacion.FormAuxiliares
{
    partial class ListRecursos
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
            dgvListRecurso = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListRecurso).BeginInit();
            SuspendLayout();
            // 
            // dgvListRecurso
            // 
            dgvListRecurso.AllowUserToAddRows = false;
            dgvListRecurso.AllowUserToDeleteRows = false;
            dgvListRecurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListRecurso.Dock = DockStyle.Fill;
            dgvListRecurso.Location = new Point(0, 0);
            dgvListRecurso.Name = "dgvListRecurso";
            dgvListRecurso.ReadOnly = true;
            dgvListRecurso.RowHeadersWidth = 51;
            dgvListRecurso.Size = new Size(800, 450);
            dgvListRecurso.TabIndex = 0;
            dgvListRecurso.CellContentClick += dgvListRecurso_CellContentClick;
            // 
            // ListRecursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvListRecurso);
            Name = "ListRecursos";
            Text = "ListRecursos";
            Load += ListRecursos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListRecurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListRecurso;
    }
}