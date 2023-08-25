namespace Practico2
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
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            LNombre = new Label();
            LApellido = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(58, 53);
            LNya.Name = "LNya";
            LNya.Size = new Size(113, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido: ";
            LNya.Click += label1_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.ButtonFace;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(177, 53);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(58, 111);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(58, 155);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(58, 195);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 4;
            LApellido.Text = "Apellido";
            // 
            // TDni
            // 
            TDni.Location = new Point(115, 103);
            TDni.Name = "TDni";
            TDni.Size = new Size(137, 23);
            TDni.TabIndex = 5;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(115, 147);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(137, 23);
            TApellido.TabIndex = 6;
            TApellido.TextChanged += TApellido_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(115, 187);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(137, 23);
            TNombre.TabIndex = 7;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TGuardar
            // 
            TGuardar.Location = new Point(85, 249);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(75, 23);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Location = new Point(177, 249);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(75, 23);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(324, 352);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TDni);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(LDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Name = "Form1";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label LNombre;
        private Label LApellido;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button TGuardar;
        private Button TEliminar;
    }
}