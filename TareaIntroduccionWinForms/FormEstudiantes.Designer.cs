namespace TareaIntroduccionWinForms
{
    partial class FormEstudiantes
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
            labelNombre = new Label();
            txtBoxNombre = new TextBox();
            txtBoxCarnet = new TextBox();
            labelCanet = new Label();
            labelCarrera = new Label();
            cmbBoxCarrera = new ComboBox();
            btnAgregar = new Button();
            btnLimpiar = new Button();
            labelListado = new Label();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(12, 9);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre:";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(85, 12);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.PlaceholderText = "Ingresa el nombre";
            txtBoxNombre.Size = new Size(288, 27);
            txtBoxNombre.TabIndex = 1;
            // 
            // txtBoxCarnet
            // 
            txtBoxCarnet.Location = new Point(85, 55);
            txtBoxCarnet.Name = "txtBoxCarnet";
            txtBoxCarnet.PlaceholderText = "Ingresa el carnet";
            txtBoxCarnet.Size = new Size(288, 27);
            txtBoxCarnet.TabIndex = 3;
            // 
            // labelCanet
            // 
            labelCanet.AutoSize = true;
            labelCanet.Location = new Point(12, 52);
            labelCanet.Name = "labelCanet";
            labelCanet.Size = new Size(55, 20);
            labelCanet.TabIndex = 2;
            labelCanet.Text = "Carnet:";
            // 
            // labelCarrera
            // 
            labelCarrera.AutoSize = true;
            labelCarrera.Location = new Point(12, 96);
            labelCarrera.Name = "labelCarrera";
            labelCarrera.Size = new Size(60, 20);
            labelCarrera.TabIndex = 4;
            labelCarrera.Text = "Carrera:";
            // 
            // cmbBoxCarrera
            // 
            cmbBoxCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCarrera.FormattingEnabled = true;
            cmbBoxCarrera.Items.AddRange(new object[] { "Ingeniería", "Derecho", "Medicina" });
            cmbBoxCarrera.Location = new Point(85, 96);
            cmbBoxCarrera.Name = "cmbBoxCarrera";
            cmbBoxCarrera.Size = new Size(288, 28);
            cmbBoxCarrera.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(85, 155);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 29);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += this.btnAgregar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(235, 155);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 29);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += this.btnLimpiar_Click;
            // 
            // labelListado
            // 
            labelListado.Location = new Point(3, 187);
            labelListado.Name = "labelListado";
            labelListado.Size = new Size(378, 259);
            labelListado.TabIndex = 8;
            // 
            // FormEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 450);
            Controls.Add(labelListado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbBoxCarrera);
            Controls.Add(labelCarrera);
            Controls.Add(txtBoxCarnet);
            Controls.Add(labelCanet);
            Controls.Add(txtBoxNombre);
            Controls.Add(labelNombre);
            Name = "FormEstudiantes";
            Text = "Registro Estudiantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private TextBox txtBoxNombre;
        private TextBox txtBoxCarnet;
        private Label labelCanet;
        private Label labelCarrera;
        private ComboBox cmbBoxCarrera;
        private Button btnAgregar;
        private Button btnLimpiar;
        private Label labelListado;
    }
}
