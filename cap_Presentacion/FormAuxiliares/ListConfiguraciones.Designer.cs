namespace cap_Presentacion.FormAuxiliares
{
    partial class ListConfiguraciones
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
            listConfiguraccion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listConfiguraccion).BeginInit();
            SuspendLayout();
            // 
            // listConfiguraccion
            // 
            listConfiguraccion.AllowUserToAddRows = false;
            listConfiguraccion.AllowUserToDeleteRows = false;
            listConfiguraccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listConfiguraccion.Dock = DockStyle.Fill;
            listConfiguraccion.Location = new Point(0, 0);
            listConfiguraccion.Name = "listConfiguraccion";
            listConfiguraccion.ReadOnly = true;
            listConfiguraccion.RowHeadersWidth = 51;
            listConfiguraccion.Size = new Size(800, 450);
            listConfiguraccion.TabIndex = 0;
            listConfiguraccion.CellContentClick += listConfiguraccion_CellContentClick;
            // 
            // ListConfiguraciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listConfiguraccion);
            Name = "ListConfiguraciones";
            Text = "ListConfiguraciones";
            Load += ListConfiguraciones_Load;
            ((System.ComponentModel.ISupportInitialize)listConfiguraccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listConfiguraccion;
    }
}