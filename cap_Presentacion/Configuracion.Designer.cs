namespace cap_Presentacion
{
    partial class Configuracion
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
            btnAddConfig = new Button();
            txtBoxClave = new TextBox();
            txtBoxValor = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBoxIdConfig = new TextBox();
            txtBoxUpdateClave = new TextBox();
            txtBoxUpdateValor = new TextBox();
            btnUpdateConfig = new Button();
            groupBox3 = new GroupBox();
            label6 = new Label();
            txtBoxDeleteCongbyId = new TextBox();
            btnConfiguracion = new Button();
            btnListConfig = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBoxValor);
            groupBox1.Controls.Add(txtBoxClave);
            groupBox1.Controls.Add(btnAddConfig);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(62, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar nueva configuración";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 39);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Clave";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 115);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Valor";
            // 
            // btnAddConfig
            // 
            btnAddConfig.Location = new Point(201, 206);
            btnAddConfig.Name = "btnAddConfig";
            btnAddConfig.Size = new Size(94, 29);
            btnAddConfig.TabIndex = 2;
            btnAddConfig.Text = "Agregar";
            btnAddConfig.UseVisualStyleBackColor = true;
            // 
            // txtBoxClave
            // 
            txtBoxClave.Location = new Point(16, 73);
            txtBoxClave.Name = "txtBoxClave";
            txtBoxClave.Size = new Size(279, 27);
            txtBoxClave.TabIndex = 3;
            // 
            // txtBoxValor
            // 
            txtBoxValor.Location = new Point(22, 148);
            txtBoxValor.Name = "txtBoxValor";
            txtBoxValor.Size = new Size(273, 27);
            txtBoxValor.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUpdateConfig);
            groupBox2.Controls.Add(txtBoxUpdateValor);
            groupBox2.Controls.Add(txtBoxUpdateClave);
            groupBox2.Controls.Add(txtBoxIdConfig);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(491, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(371, 250);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Editar configuración";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 39);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 0;
            label3.Text = "Codigo/Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 94);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 1;
            label4.Text = "Nueva Clave";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 151);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 2;
            label5.Text = "Nuevo Valor";
            // 
            // txtBoxIdConfig
            // 
            txtBoxIdConfig.Location = new Point(116, 38);
            txtBoxIdConfig.Name = "txtBoxIdConfig";
            txtBoxIdConfig.Size = new Size(215, 27);
            txtBoxIdConfig.TabIndex = 3;
            // 
            // txtBoxUpdateClave
            // 
            txtBoxUpdateClave.Location = new Point(126, 98);
            txtBoxUpdateClave.Name = "txtBoxUpdateClave";
            txtBoxUpdateClave.Size = new Size(205, 27);
            txtBoxUpdateClave.TabIndex = 4;
            // 
            // txtBoxUpdateValor
            // 
            txtBoxUpdateValor.Location = new Point(132, 155);
            txtBoxUpdateValor.Name = "txtBoxUpdateValor";
            txtBoxUpdateValor.Size = new Size(199, 27);
            txtBoxUpdateValor.TabIndex = 5;
            // 
            // btnUpdateConfig
            // 
            btnUpdateConfig.Location = new Point(237, 206);
            btnUpdateConfig.Name = "btnUpdateConfig";
            btnUpdateConfig.Size = new Size(94, 29);
            btnUpdateConfig.TabIndex = 6;
            btnUpdateConfig.Text = "Modificar";
            btnUpdateConfig.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnConfiguracion);
            groupBox3.Controls.Add(txtBoxDeleteCongbyId);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(263, 334);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(320, 192);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar Configuración";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 43);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 0;
            label6.Text = "Codigo/Id";
            // 
            // txtBoxDeleteCongbyId
            // 
            txtBoxDeleteCongbyId.Location = new Point(26, 71);
            txtBoxDeleteCongbyId.Name = "txtBoxDeleteCongbyId";
            txtBoxDeleteCongbyId.Size = new Size(258, 27);
            txtBoxDeleteCongbyId.TabIndex = 1;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Location = new Point(201, 131);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(94, 29);
            btnConfiguracion.TabIndex = 2;
            btnConfiguracion.Text = "Eliminar";
            btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnListConfig
            // 
            btnListConfig.Location = new Point(644, 405);
            btnListConfig.Name = "btnListConfig";
            btnListConfig.Size = new Size(218, 29);
            btnListConfig.TabIndex = 3;
            btnListConfig.Text = "Listar Configuraciones";
            btnListConfig.UseVisualStyleBackColor = true;
            btnListConfig.Click += btnListConfig_Click;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 551);
            Controls.Add(btnListConfig);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Configuracion";
            Text = "Configuracion";
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
        private TextBox txtBoxClave;
        private Button btnAddConfig;
        private Label label2;
        private Label label1;
        private TextBox txtBoxValor;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Button btnUpdateConfig;
        private TextBox txtBoxUpdateValor;
        private TextBox txtBoxUpdateClave;
        private TextBox txtBoxIdConfig;
        private Label label5;
        private GroupBox groupBox3;
        private Label label6;
        private Button btnConfiguracion;
        private TextBox txtBoxDeleteCongbyId;
        private Button btnListConfig;
    }
}