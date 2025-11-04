namespace cap_Presentacion
{
    partial class Usuario
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAddUsuario = new Button();
            txbAddNombre = new TextBox();
            txbAddCorreo = new TextBox();
            txbAddTelefono = new TextBox();
            txbAddContraseña = new TextBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnUpdateUsuario = new Button();
            txbUpdateById = new TextBox();
            txbUpdateNombre = new TextBox();
            txbUpdateCorreo = new TextBox();
            txbUpdateTelefono = new TextBox();
            txbUpdateContraseña = new TextBox();
            groupBox3 = new GroupBox();
            label10 = new Label();
            txbDeleteById = new TextBox();
            btnDeleteUsuario = new Button();
            btnListarUsuarios = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbAddContraseña);
            groupBox1.Controls.Add(txbAddTelefono);
            groupBox1.Controls.Add(txbAddCorreo);
            groupBox1.Controls.Add(txbAddNombre);
            groupBox1.Controls.Add(btnAddUsuario);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 254);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 37);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 83);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 125);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 166);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // btnAddUsuario
            // 
            btnAddUsuario.Location = new Point(165, 216);
            btnAddUsuario.Name = "btnAddUsuario";
            btnAddUsuario.Size = new Size(94, 29);
            btnAddUsuario.TabIndex = 4;
            btnAddUsuario.Text = "Agregar";
            btnAddUsuario.UseVisualStyleBackColor = true;
            // 
            // txbAddNombre
            // 
            txbAddNombre.Location = new Point(81, 34);
            txbAddNombre.Name = "txbAddNombre";
            txbAddNombre.Size = new Size(178, 27);
            txbAddNombre.TabIndex = 5;
            // 
            // txbAddCorreo
            // 
            txbAddCorreo.Location = new Point(86, 80);
            txbAddCorreo.Name = "txbAddCorreo";
            txbAddCorreo.Size = new Size(173, 27);
            txbAddCorreo.TabIndex = 6;
            // 
            // txbAddTelefono
            // 
            txbAddTelefono.Location = new Point(90, 126);
            txbAddTelefono.Name = "txbAddTelefono";
            txbAddTelefono.Size = new Size(169, 27);
            txbAddTelefono.TabIndex = 7;
            // 
            // txbAddContraseña
            // 
            txbAddContraseña.Location = new Point(100, 166);
            txbAddContraseña.Name = "txbAddContraseña";
            txbAddContraseña.Size = new Size(159, 27);
            txbAddContraseña.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbUpdateContraseña);
            groupBox2.Controls.Add(txbUpdateTelefono);
            groupBox2.Controls.Add(txbUpdateCorreo);
            groupBox2.Controls.Add(txbUpdateNombre);
            groupBox2.Controls.Add(txbUpdateById);
            groupBox2.Controls.Add(btnUpdateUsuario);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(353, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 254);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actualizar Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 34);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 0;
            label5.Text = "Codigo/Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 71);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 1;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 108);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 2;
            label7.Text = "Correo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 145);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 3;
            label8.Text = "Telefono";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 183);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 4;
            label9.Text = "Contraseña";
            // 
            // btnUpdateUsuario
            // 
            btnUpdateUsuario.Location = new Point(212, 216);
            btnUpdateUsuario.Name = "btnUpdateUsuario";
            btnUpdateUsuario.Size = new Size(94, 29);
            btnUpdateUsuario.TabIndex = 5;
            btnUpdateUsuario.Text = "Modificar";
            btnUpdateUsuario.UseVisualStyleBackColor = true;
            // 
            // txbUpdateById
            // 
            txbUpdateById.Location = new Point(116, 30);
            txbUpdateById.Name = "txbUpdateById";
            txbUpdateById.Size = new Size(190, 27);
            txbUpdateById.TabIndex = 6;
            // 
            // txbUpdateNombre
            // 
            txbUpdateNombre.Location = new Point(116, 71);
            txbUpdateNombre.Name = "txbUpdateNombre";
            txbUpdateNombre.Size = new Size(190, 27);
            txbUpdateNombre.TabIndex = 7;
            // 
            // txbUpdateCorreo
            // 
            txbUpdateCorreo.Location = new Point(116, 108);
            txbUpdateCorreo.Name = "txbUpdateCorreo";
            txbUpdateCorreo.Size = new Size(190, 27);
            txbUpdateCorreo.TabIndex = 8;
            // 
            // txbUpdateTelefono
            // 
            txbUpdateTelefono.Location = new Point(116, 145);
            txbUpdateTelefono.Name = "txbUpdateTelefono";
            txbUpdateTelefono.Size = new Size(190, 27);
            txbUpdateTelefono.TabIndex = 9;
            // 
            // txbUpdateContraseña
            // 
            txbUpdateContraseña.Location = new Point(116, 183);
            txbUpdateContraseña.Name = "txbUpdateContraseña";
            txbUpdateContraseña.Size = new Size(190, 27);
            txbUpdateContraseña.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDeleteUsuario);
            groupBox3.Controls.Add(txbDeleteById);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(188, 288);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(237, 140);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Usuario";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 28);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 0;
            label10.Text = "Codigo/Id";
            // 
            // txbDeleteById
            // 
            txbDeleteById.Location = new Point(24, 59);
            txbDeleteById.Name = "txbDeleteById";
            txbDeleteById.Size = new Size(191, 27);
            txbDeleteById.TabIndex = 1;
            // 
            // btnDeleteUsuario
            // 
            btnDeleteUsuario.Location = new Point(121, 103);
            btnDeleteUsuario.Name = "btnDeleteUsuario";
            btnDeleteUsuario.Size = new Size(94, 29);
            btnDeleteUsuario.TabIndex = 2;
            btnDeleteUsuario.Text = "Eliminar";
            btnDeleteUsuario.UseVisualStyleBackColor = true;
            // 
            // btnListarUsuarios
            // 
            btnListarUsuarios.Location = new Point(501, 345);
            btnListarUsuarios.Name = "btnListarUsuarios";
            btnListarUsuarios.Size = new Size(158, 29);
            btnListarUsuarios.TabIndex = 3;
            btnListarUsuarios.Text = "Listar Usuarios";
            btnListarUsuarios.UseVisualStyleBackColor = true;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarUsuarios);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Usuario";
            Text = "Usuario";
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
        private TextBox txbAddCorreo;
        private TextBox txbAddNombre;
        private Button btnAddUsuario;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txbAddContraseña;
        private TextBox txbAddTelefono;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txbUpdateContraseña;
        private TextBox txbUpdateTelefono;
        private TextBox txbUpdateCorreo;
        private TextBox txbUpdateNombre;
        private TextBox txbUpdateById;
        private Button btnUpdateUsuario;
        private GroupBox groupBox3;
        private Button btnDeleteUsuario;
        private TextBox txbDeleteById;
        private Label label10;
        private Button btnListarUsuarios;
    }
}