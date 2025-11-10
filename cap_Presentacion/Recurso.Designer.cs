namespace cap_Presentacion
{
    partial class Recurso
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
            groupBox1 = new GroupBox();
            txbAddCapacidad = new NumericUpDown();
            btnAddRecurso = new Button();
            txbAddEstado = new TextBox();
            txbAddNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnDeleteRecurso = new Button();
            label10 = new Label();
            txbDeleteById = new TextBox();
            groupBox4 = new GroupBox();
            txbUpdateCapacidad = new NumericUpDown();
            txbUpdateById = new TextBox();
            label9 = new Label();
            btnUpdateRecurso = new Button();
            txbUpdateEstado = new TextBox();
            txbUpdateNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            btnListarRecurso = new Button();
            btnGoHome = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbAddCapacidad).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txbUpdateCapacidad).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbAddCapacidad);
            groupBox1.Controls.Add(btnAddRecurso);
            groupBox1.Controls.Add(txbAddEstado);
            groupBox1.Controls.Add(txbAddNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 251);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Recurso";
            // 
            // txbAddCapacidad
            // 
            txbAddCapacidad.Location = new Point(100, 97);
            txbAddCapacidad.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            txbAddCapacidad.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            txbAddCapacidad.Name = "txbAddCapacidad";
            txbAddCapacidad.Size = new Size(163, 27);
            txbAddCapacidad.TabIndex = 9;
            txbAddCapacidad.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // btnAddRecurso
            // 
            btnAddRecurso.Location = new Point(169, 185);
            btnAddRecurso.Name = "btnAddRecurso";
            btnAddRecurso.Size = new Size(94, 29);
            btnAddRecurso.TabIndex = 8;
            btnAddRecurso.Text = "Agregar";
            btnAddRecurso.UseVisualStyleBackColor = true;
            btnAddRecurso.Click += btnAddRecurso_Click;
            // 
            // txbAddEstado
            // 
            txbAddEstado.Location = new Point(100, 142);
            txbAddEstado.Name = "txbAddEstado";
            txbAddEstado.Size = new Size(163, 27);
            txbAddEstado.TabIndex = 7;
            // 
            // txbAddNombre
            // 
            txbAddNombre.Location = new Point(100, 41);
            txbAddNombre.Name = "txbAddNombre";
            txbAddNombre.Size = new Size(163, 27);
            txbAddNombre.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 142);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 97);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Capacidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDeleteRecurso);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txbDeleteById);
            groupBox3.Location = new Point(18, 302);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(300, 126);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // btnDeleteRecurso
            // 
            btnDeleteRecurso.Location = new Point(176, 76);
            btnDeleteRecurso.Name = "btnDeleteRecurso";
            btnDeleteRecurso.Size = new Size(94, 29);
            btnDeleteRecurso.TabIndex = 2;
            btnDeleteRecurso.Text = "Borrar";
            btnDeleteRecurso.UseVisualStyleBackColor = true;
            btnDeleteRecurso.Click += btnDeleteRecurso_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(13, 37);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 1;
            label10.Text = "Codigo/Id";
            // 
            // txbDeleteById
            // 
            txbDeleteById.Location = new Point(111, 34);
            txbDeleteById.Name = "txbDeleteById";
            txbDeleteById.Size = new Size(159, 27);
            txbDeleteById.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txbUpdateCapacidad);
            groupBox4.Controls.Add(txbUpdateById);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(btnUpdateRecurso);
            groupBox4.Controls.Add(txbUpdateEstado);
            groupBox4.Controls.Add(txbUpdateNombre);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(383, 33);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(306, 266);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Editar Recurso";
            // 
            // txbUpdateCapacidad
            // 
            txbUpdateCapacidad.Location = new Point(104, 152);
            txbUpdateCapacidad.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            txbUpdateCapacidad.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            txbUpdateCapacidad.Name = "txbUpdateCapacidad";
            txbUpdateCapacidad.Size = new Size(163, 27);
            txbUpdateCapacidad.TabIndex = 10;
            txbUpdateCapacidad.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // txbUpdateById
            // 
            txbUpdateById.Location = new Point(102, 43);
            txbUpdateById.Name = "txbUpdateById";
            txbUpdateById.Size = new Size(165, 27);
            txbUpdateById.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 48);
            label9.Name = "label9";
            label9.Size = new Size(77, 20);
            label9.TabIndex = 9;
            label9.Text = "Codigo/Id";
            // 
            // btnUpdateRecurso
            // 
            btnUpdateRecurso.Location = new Point(169, 231);
            btnUpdateRecurso.Name = "btnUpdateRecurso";
            btnUpdateRecurso.Size = new Size(94, 29);
            btnUpdateRecurso.TabIndex = 8;
            btnUpdateRecurso.Text = "Editar";
            btnUpdateRecurso.UseVisualStyleBackColor = true;
            btnUpdateRecurso.Click += btnUpdateRecurso_Click;
            // 
            // txbUpdateEstado
            // 
            txbUpdateEstado.Location = new Point(104, 198);
            txbUpdateEstado.Name = "txbUpdateEstado";
            txbUpdateEstado.Size = new Size(163, 27);
            txbUpdateEstado.TabIndex = 7;
            // 
            // txbUpdateNombre
            // 
            txbUpdateNombre.Location = new Point(102, 101);
            txbUpdateNombre.Name = "txbUpdateNombre";
            txbUpdateNombre.Size = new Size(163, 27);
            txbUpdateNombre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 198);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 3;
            label5.Text = "Estado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 152);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 2;
            label6.Text = "Capacidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 104);
            label8.Name = "label8";
            label8.Size = new Size(64, 20);
            label8.TabIndex = 0;
            label8.Text = "Nombre";
            // 
            // btnListarRecurso
            // 
            btnListarRecurso.Location = new Point(448, 366);
            btnListarRecurso.Name = "btnListarRecurso";
            btnListarRecurso.Size = new Size(160, 29);
            btnListarRecurso.TabIndex = 10;
            btnListarRecurso.Text = "Listar Recurso";
            btnListarRecurso.UseVisualStyleBackColor = true;
            btnListarRecurso.Click += btnListarRecurso_Click;
            // 
            // btnGoHome
            // 
            btnGoHome.Location = new Point(695, 33);
            btnGoHome.Name = "btnGoHome";
            btnGoHome.Size = new Size(94, 29);
            btnGoHome.TabIndex = 21;
            btnGoHome.Text = "Menu";
            btnGoHome.UseVisualStyleBackColor = true;
            btnGoHome.Click += btnGoHome_Click;
            // 
            // Recurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoHome);
            Controls.Add(btnListarRecurso);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Recurso";
            Text = "Recurso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbAddCapacidad).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txbUpdateCapacidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txbAddNombre;
        private Button btnAddRecurso;
        private GroupBox groupBox4;
        private TextBox txbUpdateById;
        private Label label9;
        private Button btnUpdateRecurso;
        private TextBox txbUpdateEstado;
        private TextBox txbUpdateNombre;
        private Label label5;
        private Label label6;
        private Label label8;
        private Button btnDeleteRecurso;
        private Label label10;
        private TextBox txbDeleteById;
        private Button btnListarRecurso;
        private Button btnGoHome;
        // Agrega la definición del campo txbAddEstado en la clase Recurso
        private TextBox txbAddEstado;
        private NumericUpDown txbAddCapacidad;
        private NumericUpDown txbUpdateCapacidad;
    }
}