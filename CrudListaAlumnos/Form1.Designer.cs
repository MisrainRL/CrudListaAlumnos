namespace CrudListaAlumnos
{
    partial class FrmAlumnos
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textNombre = new TextBox();
            textCorreo = new TextBox();
            textEdad = new TextBox();
            btnGuardar = new Button();
            dgvDatos = new DataGridView();
            erpError = new ErrorProvider(components);
            btnBorrar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)erpError).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 35);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 74);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 125);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(97, 28);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(434, 27);
            textNombre.TabIndex = 3;
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(97, 67);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(434, 27);
            textCorreo.TabIndex = 4;
            // 
            // textEdad
            // 
            textEdad.Location = new Point(97, 118);
            textEdad.Name = "textEdad";
            textEdad.Size = new Size(143, 27);
            textEdad.TabIndex = 5;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(271, 118);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.GridColor = SystemColors.ActiveCaption;
            dgvDatos.Location = new Point(27, 199);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.RowTemplate.Height = 29;
            dgvDatos.Size = new Size(504, 188);
            dgvDatos.TabIndex = 7;
            dgvDatos.CellDoubleClick += dgvDatos_CellDoubleClick;
            // 
            // erpError
            // 
            erpError.ContainerControl = this;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(20, 393);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(220, 29);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Eliminar Registro";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(437, 118);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FrmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnBorrar);
            Controls.Add(dgvDatos);
            Controls.Add(btnGuardar);
            Controls.Add(textEdad);
            Controls.Add(textCorreo);
            Controls.Add(textNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAlumnos";
            Text = "ListaAlumnos";
            Load += FrmAlumnos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)erpError).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textNombre;
        private TextBox textCorreo;
        private TextBox textEdad;
        private Button btnGuardar;
        private DataGridView dgvDatos;
        private ErrorProvider erpError;
        private Button btnBorrar;
        private Button btnActualizar;
    }
}