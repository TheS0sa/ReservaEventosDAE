namespace cap_Presentacion
{
    partial class Form1
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 50);
            label1.Name = "label1";
            label1.Size = new Size(166, 38);
            label1.TabIndex = 0;
            label1.Text = "Bienvenidos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(504, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 318);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // button4
            // 
            button4.Location = new Point(36, 238);
            button4.Name = "button4";
            button4.Size = new Size(186, 29);
            button4.TabIndex = 3;
            button4.Text = "Reserva";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(36, 173);
            button3.Name = "button3";
            button3.Size = new Size(186, 29);
            button3.TabIndex = 2;
            button3.Text = "Recurso";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(36, 110);
            button2.Name = "button2";
            button2.Size = new Size(186, 29);
            button2.TabIndex = 1;
            button2.Text = "Usuario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(36, 50);
            button1.Name = "button1";
            button1.Size = new Size(186, 29);
            button1.TabIndex = 0;
            button1.Text = "Configuración";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 161);
            label2.Name = "label2";
            label2.Size = new Size(352, 108);
            label2.TabIndex = 2;
            label2.Text = "Sistema de Reserva\r\nde Eventos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label2;
    }
}
