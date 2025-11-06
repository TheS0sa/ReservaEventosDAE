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
            txbAddContrasenia = new TextBox();
            txbAddTelefono = new TextBox();
            txbAddCorreo = new TextBox();
            txbAddNombre = new TextBox();
            btnAddUsuario = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txbDeleteById = new TextBox();
            btnDeleteUsuario = new Button();
            btnListarUsuario = new Button();
            groupBox3 = new GroupBox();
            txbUpdateById = new TextBox();
            label10 = new Label();
            txbUpdateContrasenia = new TextBox();
            txbUpdateTelefono = new TextBox();
            txbUpdateCorreo = new TextBox();
            txbUpdateNombre = new TextBox();
            btnUpdateUsuario = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnGoHome = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbAddContrasenia);
            groupBox1.Controls.Add(txbAddTelefono);
            groupBox1.Controls.Add(txbAddCorreo);
            groupBox1.Controls.Add(txbAddNombre);
            groupBox1.Controls.Add(btnAddUsuario);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(39, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 258);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Usuario";
            // 
            // txbAddContrasenia
            // 
            txbAddContrasenia.Location = new Point(105, 162);
            txbAddContrasenia.Name = "txbAddContrasenia";
            txbAddContrasenia.Size = new Size(205, 27);
            txbAddContrasenia.TabIndex = 8;
            // 
            // txbAddTelefono
            // 
            txbAddTelefono.Location = new Point(105, 119);
            txbAddTelefono.Name = "txbAddTelefono";
            txbAddTelefono.Size = new Size(205, 27);
            txbAddTelefono.TabIndex = 7;
            // 
            // txbAddCorreo
            // 
            txbAddCorreo.Location = new Point(105, 74);
            txbAddCorreo.Name = "txbAddCorreo";
            txbAddCorreo.Size = new Size(205, 27);
            txbAddCorreo.TabIndex = 6;
            // 
            // txbAddNombre
            // 
            txbAddNombre.Location = new Point(105, 36);
            txbAddNombre.Name = "txbAddNombre";
            txbAddNombre.Size = new Size(205, 27);
            txbAddNombre.TabIndex = 5;
            // 
            // btnAddUsuario
            // 
            btnAddUsuario.Location = new Point(204, 211);
            btnAddUsuario.Name = "btnAddUsuario";
            btnAddUsuario.Size = new Size(94, 29);
            btnAddUsuario.TabIndex = 4;
            btnAddUsuario.Text = "Agregar";
            btnAddUsuario.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 162);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 3;
            label5.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 119);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 2;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 74);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 1;
            label3.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txbDeleteById);
            groupBox2.Controls.Add(btnDeleteUsuario);
            groupBox2.Location = new Point(39, 329);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(259, 125);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Codigo/Id";
            // 
            // txbDeleteById
            // 
            txbDeleteById.Location = new Point(105, 43);
            txbDeleteById.Name = "txbDeleteById";
            txbDeleteById.Size = new Size(145, 27);
            txbDeleteById.TabIndex = 1;
            // 
            // btnDeleteUsuario
            // 
            btnDeleteUsuario.Location = new Point(146, 76);
            btnDeleteUsuario.Name = "btnDeleteUsuario";
            btnDeleteUsuario.Size = new Size(94, 29);
            btnDeleteUsuario.TabIndex = 0;
            btnDeleteUsuario.Text = "Borrar";
            btnDeleteUsuario.UseVisualStyleBackColor = true;
            // 
            // btnListarUsuario
            // 
            btnListarUsuario.Location = new Point(528, 390);
            btnListarUsuario.Name = "btnListarUsuario";
            btnListarUsuario.Size = new Size(165, 29);
            btnListarUsuario.TabIndex = 2;
            btnListarUsuario.Text = "Listar Usuarios";
            btnListarUsuario.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txbUpdateById);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(txbUpdateContrasenia);
            groupBox3.Controls.Add(txbUpdateTelefono);
            groupBox3.Controls.Add(txbUpdateCorreo);
            groupBox3.Controls.Add(txbUpdateNombre);
            groupBox3.Controls.Add(btnUpdateUsuario);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(423, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(316, 297);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Agregar Usuario";
            // 
            // txbUpdateById
            // 
            txbUpdateById.Location = new Point(105, 33);
            txbUpdateById.Name = "txbUpdateById";
            txbUpdateById.Size = new Size(205, 27);
            txbUpdateById.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(61, 36);
            label10.Name = "label10";
            label10.Size = new Size(22, 20);
            label10.TabIndex = 9;
            label10.Text = "Id";
            // 
            // txbUpdateContrasenia
            // 
            txbUpdateContrasenia.Location = new Point(105, 197);
            txbUpdateContrasenia.Name = "txbUpdateContrasenia";
            txbUpdateContrasenia.Size = new Size(205, 27);
            txbUpdateContrasenia.TabIndex = 8;
            // 
            // txbUpdateTelefono
            // 
            txbUpdateTelefono.Location = new Point(105, 154);
            txbUpdateTelefono.Name = "txbUpdateTelefono";
            txbUpdateTelefono.Size = new Size(205, 27);
            txbUpdateTelefono.TabIndex = 7;
            // 
            // txbUpdateCorreo
            // 
            txbUpdateCorreo.Location = new Point(105, 109);
            txbUpdateCorreo.Name = "txbUpdateCorreo";
            txbUpdateCorreo.Size = new Size(205, 27);
            txbUpdateCorreo.TabIndex = 6;
            // 
            // txbUpdateNombre
            // 
            txbUpdateNombre.Location = new Point(105, 71);
            txbUpdateNombre.Name = "txbUpdateNombre";
            txbUpdateNombre.Size = new Size(205, 27);
            txbUpdateNombre.TabIndex = 5;
            // 
            // btnUpdateUsuario
            // 
            btnUpdateUsuario.Location = new Point(208, 242);
            btnUpdateUsuario.Name = "btnUpdateUsuario";
            btnUpdateUsuario.Size = new Size(94, 29);
            btnUpdateUsuario.TabIndex = 4;
            btnUpdateUsuario.Text = "Editar";
            btnUpdateUsuario.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 197);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 3;
            label6.Text = "Contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 154);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 2;
            label7.Text = "Telefono";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 109);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 1;
            label8.Text = "Correo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 74);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 0;
            label9.Text = "Nombre";
            // 
            // btnGoHome
            // 
            btnGoHome.Location = new Point(761, 36);
            btnGoHome.Name = "btnGoHome";
            btnGoHome.Size = new Size(94, 29);
            btnGoHome.TabIndex = 21;
            btnGoHome.Text = "Menu";
            btnGoHome.UseVisualStyleBackColor = true;
            btnGoHome.Click += btnGoHome_Click;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 488);
            Controls.Add(btnGoHome);
            Controls.Add(groupBox3);
            Controls.Add(btnListarUsuario);
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
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox txbDeleteById;
        private Button btnDeleteUsuario;
        private Button btnListarUsuario;
        private TextBox txbAddContrasenia;
        private TextBox txbAddTelefono;
        private TextBox txbAddCorreo;
        private TextBox txbAddNombre;
        private Button btnAddUsuario;
        private GroupBox groupBox3;
        private TextBox txbUpdateById;
        private Label label10;
        private TextBox txbUpdateContrasenia;
        private TextBox txbUpdateTelefono;
        private TextBox txbUpdateCorreo;
        private TextBox txbUpdateNombre;
        private Button btnUpdateUsuario;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnGoHome;
    }
}