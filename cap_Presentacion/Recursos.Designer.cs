namespace cap_Presentacion
{
    partial class Recursos
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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddRecurso = new Button();
            txbAddNombre = new TextBox();
            txbAddTipo = new TextBox();
            txbAddCapacidad = new TextBox();
            txbAddEstado = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnUpdateRecurso = new Button();
            txbUpdateById = new TextBox();
            txbUpdateNombre = new TextBox();
            txbUpdateTipo = new TextBox();
            txbUpdateCapacidad = new TextBox();
            txbUpdateEstado = new TextBox();
            btnDeleteRecurso = new Button();
            label10 = new Label();
            txbDeleteById = new TextBox();
            label11 = new Label();
            btnListarRecursos = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbAddEstado);
            groupBox1.Controls.Add(txbAddCapacidad);
            groupBox1.Controls.Add(txbAddTipo);
            groupBox1.Controls.Add(txbAddNombre);
            groupBox1.Controls.Add(btnAddRecurso);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 270);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Recurso";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbUpdateEstado);
            groupBox2.Controls.Add(txbUpdateCapacidad);
            groupBox2.Controls.Add(txbUpdateTipo);
            groupBox2.Controls.Add(txbUpdateNombre);
            groupBox2.Controls.Add(txbUpdateById);
            groupBox2.Controls.Add(btnUpdateRecurso);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(345, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(303, 297);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editar Recurso";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txbDeleteById);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(btnDeleteRecurso);
            groupBox3.Location = new Point(21, 298);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(264, 127);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "EliminarRecurso";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 90);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 141);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Capacidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 190);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // btnAddRecurso
            // 
            btnAddRecurso.Location = new Point(159, 223);
            btnAddRecurso.Name = "btnAddRecurso";
            btnAddRecurso.Size = new Size(94, 29);
            btnAddRecurso.TabIndex = 4;
            btnAddRecurso.Text = "Agregar";
            btnAddRecurso.UseVisualStyleBackColor = true;
            // 
            // txbAddNombre
            // 
            txbAddNombre.Location = new Point(102, 37);
            txbAddNombre.Name = "txbAddNombre";
            txbAddNombre.Size = new Size(151, 27);
            txbAddNombre.TabIndex = 5;
            // 
            // txbAddTipo
            // 
            txbAddTipo.Location = new Point(102, 90);
            txbAddTipo.Name = "txbAddTipo";
            txbAddTipo.Size = new Size(151, 27);
            txbAddTipo.TabIndex = 6;
            // 
            // txbAddCapacidad
            // 
            txbAddCapacidad.Location = new Point(102, 141);
            txbAddCapacidad.Name = "txbAddCapacidad";
            txbAddCapacidad.Size = new Size(151, 27);
            txbAddCapacidad.TabIndex = 7;
            // 
            // txbAddEstado
            // 
            txbAddEstado.Location = new Point(102, 190);
            txbAddEstado.Name = "txbAddEstado";
            txbAddEstado.Size = new Size(151, 27);
            txbAddEstado.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 37);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "Codigo/Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 80);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 1;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 125);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 2;
            label7.Text = "Tipo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 170);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 3;
            label8.Text = "Capacidad";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 211);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 4;
            label9.Text = "Estado";
            // 
            // btnUpdateRecurso
            // 
            btnUpdateRecurso.Location = new Point(193, 244);
            btnUpdateRecurso.Name = "btnUpdateRecurso";
            btnUpdateRecurso.Size = new Size(94, 29);
            btnUpdateRecurso.TabIndex = 5;
            btnUpdateRecurso.Text = "Editar";
            btnUpdateRecurso.UseVisualStyleBackColor = true;
            // 
            // txbUpdateById
            // 
            txbUpdateById.Location = new Point(131, 34);
            txbUpdateById.Name = "txbUpdateById";
            txbUpdateById.Size = new Size(156, 27);
            txbUpdateById.TabIndex = 6;
            // 
            // txbUpdateNombre
            // 
            txbUpdateNombre.Location = new Point(131, 80);
            txbUpdateNombre.Name = "txbUpdateNombre";
            txbUpdateNombre.Size = new Size(156, 27);
            txbUpdateNombre.TabIndex = 7;
            txbUpdateNombre.TextChanged += textBox2_TextChanged;
            // 
            // txbUpdateTipo
            // 
            txbUpdateTipo.Location = new Point(131, 122);
            txbUpdateTipo.Name = "txbUpdateTipo";
            txbUpdateTipo.Size = new Size(156, 27);
            txbUpdateTipo.TabIndex = 8;
            // 
            // txbUpdateCapacidad
            // 
            txbUpdateCapacidad.Location = new Point(131, 167);
            txbUpdateCapacidad.Name = "txbUpdateCapacidad";
            txbUpdateCapacidad.Size = new Size(156, 27);
            txbUpdateCapacidad.TabIndex = 9;
            // 
            // txbUpdateEstado
            // 
            txbUpdateEstado.Location = new Point(131, 211);
            txbUpdateEstado.Name = "txbUpdateEstado";
            txbUpdateEstado.Size = new Size(156, 27);
            txbUpdateEstado.TabIndex = 10;
            // 
            // btnDeleteRecurso
            // 
            btnDeleteRecurso.Location = new Point(137, 92);
            btnDeleteRecurso.Name = "btnDeleteRecurso";
            btnDeleteRecurso.Size = new Size(94, 29);
            btnDeleteRecurso.TabIndex = 0;
            btnDeleteRecurso.Text = "Eliminar";
            btnDeleteRecurso.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 21);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 1;
            // 
            // txbDeleteById
            // 
            txbDeleteById.Location = new Point(89, 50);
            txbDeleteById.Name = "txbDeleteById";
            txbDeleteById.Size = new Size(142, 27);
            txbDeleteById.TabIndex = 2;
            txbDeleteById.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 50);
            label11.Name = "label11";
            label11.Size = new Size(77, 20);
            label11.TabIndex = 3;
            label11.Text = "Codigo/Id";
            // 
            // btnListarRecursos
            // 
            btnListarRecursos.Location = new Point(423, 360);
            btnListarRecursos.Name = "btnListarRecursos";
            btnListarRecursos.Size = new Size(182, 29);
            btnListarRecursos.TabIndex = 3;
            btnListarRecursos.Text = "Listar Recursos";
            btnListarRecursos.UseVisualStyleBackColor = true;
            // 
            // Recursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarRecursos);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Recursos";
            Text = "Recursos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txbAddEstado;
        private TextBox txbAddCapacidad;
        private TextBox txbAddTipo;
        private TextBox txbAddNombre;
        private Button btnAddRecurso;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txbUpdateCapacidad;
        private TextBox txbUpdateTipo;
        private TextBox txbUpdateNombre;
        private TextBox txbUpdateById;
        private Button btnUpdateRecurso;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txbUpdateEstado;
        private TextBox txbDeleteById;
        private Label label10;
        private Button btnDeleteRecurso;
        private Label label11;
        private Button btnListarRecursos;
    }
}