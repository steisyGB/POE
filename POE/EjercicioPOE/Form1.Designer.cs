namespace EjercicioPOE
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            btnAlmacenarRegistro = new Button();
            CalcularNotas = new Button();
            NotaF = new TextBox();
            Nuevo = new Button();
            label6 = new Label();
            txtNota4 = new TextBox();
            salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 46);
            label1.Name = "label1";
            label1.Size = new Size(211, 25);
            label1.TabIndex = 0;
            label1.Text = "CALCULAR NOTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(288, 116);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(288, 154);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 2;
            label3.Text = "MATERIA 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(288, 248);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "MATERIA 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(288, 200);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "MATERIA 2";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(438, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(438, 154);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 6;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(438, 200);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 7;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(438, 245);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 8;
            // 
            // btnAlmacenarRegistro
            // 
            btnAlmacenarRegistro.Location = new Point(324, 351);
            btnAlmacenarRegistro.Name = "btnAlmacenarRegistro";
            btnAlmacenarRegistro.Size = new Size(187, 47);
            btnAlmacenarRegistro.TabIndex = 9;
            btnAlmacenarRegistro.Text = "Guardar Notas";
            btnAlmacenarRegistro.UseVisualStyleBackColor = true;
            btnAlmacenarRegistro.Click += btnAlmacenarRegistro_Click;
            // 
            // CalcularNotas
            // 
            CalcularNotas.Location = new Point(324, 443);
            CalcularNotas.Name = "CalcularNotas";
            CalcularNotas.Size = new Size(187, 50);
            CalcularNotas.TabIndex = 10;
            CalcularNotas.Text = "Calcular nota final";
            CalcularNotas.UseVisualStyleBackColor = true;
            CalcularNotas.Click += CalcularNotas_Click;
            // 
            // NotaF
            // 
            NotaF.Location = new Point(362, 517);
            NotaF.Name = "NotaF";
            NotaF.Size = new Size(100, 23);
            NotaF.TabIndex = 11;
            // 
            // Nuevo
            // 
            Nuevo.Location = new Point(83, 351);
            Nuevo.Name = "Nuevo";
            Nuevo.Size = new Size(119, 142);
            Nuevo.TabIndex = 12;
            Nuevo.Text = "NUEVO";
            Nuevo.UseVisualStyleBackColor = true;
            Nuevo.Click += Nuevo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(288, 292);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 13;
            label6.Text = "MATERIA 4";
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(438, 284);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(100, 23);
            txtNota4.TabIndex = 14;
            // 
            // salir
            // 
            salir.Location = new Point(605, 351);
            salir.Name = "salir";
            salir.Size = new Size(106, 142);
            salir.TabIndex = 15;
            salir.Text = "SALIR";
            salir.UseVisualStyleBackColor = true;
            salir.Click += salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(salir);
            Controls.Add(txtNota4);
            Controls.Add(label6);
            Controls.Add(Nuevo);
            Controls.Add(NotaF);
            Controls.Add(CalcularNotas);
            Controls.Add(btnAlmacenarRegistro);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private Button btnAlmacenarRegistro;
        private Button CalcularNotas;
        private TextBox NotaF;
        private Button Nuevo;
        private Label label6;
        private TextBox txtNota4;
        private Button salir;
    }
}
