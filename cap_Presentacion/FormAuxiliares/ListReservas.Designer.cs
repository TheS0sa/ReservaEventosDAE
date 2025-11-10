namespace cap_Presentacion.FormAuxiliares
{
    partial class ListReservas
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
            dgvListarReservas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListarReservas).BeginInit();
            SuspendLayout();
            // 
            // dgvListarReservas
            // 
            dgvListarReservas.AllowUserToAddRows = false;
            dgvListarReservas.AllowUserToDeleteRows = false;
            dgvListarReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarReservas.Dock = DockStyle.Fill;
            dgvListarReservas.Location = new Point(0, 0);
            dgvListarReservas.Name = "dgvListarReservas";
            dgvListarReservas.ReadOnly = true;
            dgvListarReservas.RowHeadersWidth = 51;
            dgvListarReservas.Size = new Size(1143, 450);
            dgvListarReservas.TabIndex = 0;
            // 
            // ListReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 450);
            Controls.Add(dgvListarReservas);
            Name = "ListReservas";
            Text = "ListReservas";
            Load += ListReservas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListarReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvListarReservas;
    }
}