namespace TEMPLATE.Escritorio
{
    partial class Lista
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
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            btnBuscar = new Button();
            dgvClase = new DataGridView();
            btnFinalizar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClase).BeginInit();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(31, 17);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activo", "Finalizado" });
            cmbEstado.Location = new Point(85, 14);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(157, 23);
            cmbEstado.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(259, 6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 36);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvAlquiler
            // 
            dgvClase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClase.Location = new Point(31, 48);
            dgvClase.Name = "dgvAlquiler";
            dgvClase.Size = new Size(740, 348);
            dgvClase.TabIndex = 3;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(566, 402);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(96, 36);
            btnFinalizar.TabIndex = 4;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(675, 402);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 36);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Lista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(btnFinalizar);
            Controls.Add(dgvClase);
            Controls.Add(btnBuscar);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Name = "Lista";
            Text = "Lista";
            Load += Lista_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private ComboBox cmbEstado;
        private Button btnBuscar;
        private DataGridView dgvClase;
        private Button btnFinalizar;
        private Button btnAgregar;
    }
}
