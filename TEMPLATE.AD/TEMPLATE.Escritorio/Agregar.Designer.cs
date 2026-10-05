namespace TEMPLATE.Escritorio
{
    partial class Agregar
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
            btnAgregar = new Button();
            btnCancelar = new Button();
            lblInquilino = new Label();
            numMontoAlquiler = new NumericUpDown();
            txtInquilino = new TextBox();
            tpFechaIni = new DateTimePicker();
            tpFechaFin = new DateTimePicker();
            lblMontoAlquiler = new Label();
            lblFechaInicio = new Label();
            lblFechaFin = new Label();
            ((System.ComponentModel.ISupportInitialize)numMontoAlquiler).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(544, 380);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 47);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(671, 380);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 47);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblInquilino
            // 
            lblInquilino.AutoSize = true;
            lblInquilino.Location = new Point(166, 75);
            lblInquilino.Name = "lblInquilino";
            lblInquilino.Size = new Size(54, 15);
            lblInquilino.TabIndex = 2;
            lblInquilino.Text = "Clase";
            // 
            // numMontoAlquiler
            // 
            numMontoAlquiler.Location = new Point(249, 122);
            numMontoAlquiler.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMontoAlquiler.Name = "numMontoAlquiler";
            numMontoAlquiler.Size = new Size(185, 23);
            numMontoAlquiler.TabIndex = 3;
            // 
            // txtInquilino
            // 
            txtInquilino.Location = new Point(249, 72);
            txtInquilino.Name = "txtInquilino";
            txtInquilino.Size = new Size(185, 23);
            txtInquilino.TabIndex = 4;
            // 
            // tpFechaIni
            // 
            tpFechaIni.Format = DateTimePickerFormat.Short;
            tpFechaIni.Location = new Point(249, 177);
            tpFechaIni.Name = "tpFechaIni";
            tpFechaIni.Size = new Size(185, 23);
            tpFechaIni.TabIndex = 5;
            // 
            // tpFechaFin
            // 
            tpFechaFin.Format = DateTimePickerFormat.Short;
            tpFechaFin.Location = new Point(249, 230);
            tpFechaFin.Name = "tpFechaFin";
            tpFechaFin.Size = new Size(185, 23);
            tpFechaFin.TabIndex = 6;
            // 
            // lblMontoAlquiler
            // 
            lblMontoAlquiler.AutoSize = true;
            lblMontoAlquiler.Location = new Point(133, 124);
            lblMontoAlquiler.Name = "lblMontoAlquiler";
            lblMontoAlquiler.Size = new Size(87, 15);
            lblMontoAlquiler.TabIndex = 7;
            lblMontoAlquiler.Text = "Monto Alquiler";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Location = new Point(150, 183);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(70, 15);
            lblFechaInicio.TabIndex = 8;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Location = new Point(163, 236);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(57, 15);
            lblFechaFin.TabIndex = 9;
            lblFechaFin.Text = "Fecha Fin";
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFechaFin);
            Controls.Add(lblFechaInicio);
            Controls.Add(lblMontoAlquiler);
            Controls.Add(tpFechaFin);
            Controls.Add(tpFechaIni);
            Controls.Add(txtInquilino);
            Controls.Add(numMontoAlquiler);
            Controls.Add(lblInquilino);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "Agregar";
            Text = "Agregar";
            Load += Agregar_Load;
            ((System.ComponentModel.ISupportInitialize)numMontoAlquiler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnCancelar;
        private Label lblInquilino;
        private NumericUpDown numMontoAlquiler;
        private TextBox txtInquilino;
        private DateTimePicker tpFechaIni;
        private DateTimePicker tpFechaFin;
        private Label lblMontoAlquiler;
        private Label lblFechaInicio;
        private Label lblFechaFin;
    }
}