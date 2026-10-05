namespace Herrera.Presentacion
{
    partial class AlquilerLista
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
            tscAlquiler = new ToolStripContainer();
            tlAlquileres = new TableLayoutPanel();
            dgvAlquileres = new DataGridView();
            btnFinalizar = new Button();
            btnFiltrar = new Button();
            estadoComboBox = new ComboBox();
            btnResetFiltro = new Button();
            tsAlquiler = new ToolStrip();
            tsNuevo = new ToolStripButton();
            tscAlquiler.ContentPanel.SuspendLayout();
            tscAlquiler.TopToolStripPanel.SuspendLayout();
            tscAlquiler.SuspendLayout();
            tlAlquileres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).BeginInit();
            tsAlquiler.SuspendLayout();
            SuspendLayout();
            // 
            // tscAlquiler
            // 
            // 
            // tscAlquiler.ContentPanel
            // 
            tscAlquiler.ContentPanel.Controls.Add(tlAlquileres);
            tscAlquiler.ContentPanel.Size = new Size(800, 425);
            tscAlquiler.Dock = DockStyle.Fill;
            tscAlquiler.Location = new Point(0, 0);
            tscAlquiler.Name = "tscAlquiler";
            tscAlquiler.Size = new Size(800, 450);
            tscAlquiler.TabIndex = 0;
            tscAlquiler.Text = "toolStripContainer1";
            // 
            // tscAlquiler.TopToolStripPanel
            // 
            tscAlquiler.TopToolStripPanel.Controls.Add(tsAlquiler);
            // 
            // tlAlquileres
            // 
            tlAlquileres.ColumnCount = 3;
            tlAlquileres.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlAlquileres.ColumnStyles.Add(new ColumnStyle());
            tlAlquileres.ColumnStyles.Add(new ColumnStyle());
            tlAlquileres.Controls.Add(dgvAlquileres, 0, 1);
            tlAlquileres.Controls.Add(btnFinalizar, 2, 2);
            tlAlquileres.Controls.Add(btnFiltrar, 2, 0);
            tlAlquileres.Controls.Add(estadoComboBox, 1, 0);
            tlAlquileres.Controls.Add(btnResetFiltro, 0, 0);
            tlAlquileres.Dock = DockStyle.Fill;
            tlAlquileres.Location = new Point(0, 0);
            tlAlquileres.Name = "tlAlquileres";
            tlAlquileres.RowCount = 3;
            tlAlquileres.RowStyles.Add(new RowStyle());
            tlAlquileres.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlAlquileres.RowStyles.Add(new RowStyle());
            tlAlquileres.Size = new Size(800, 425);
            tlAlquileres.TabIndex = 0;
            // 
            // dgvAlquileres
            // 
            dgvAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlAlquileres.SetColumnSpan(dgvAlquileres, 3);
            dgvAlquileres.Dock = DockStyle.Fill;
            dgvAlquileres.Location = new Point(3, 32);
            dgvAlquileres.Name = "dgvAlquileres";
            dgvAlquileres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlquileres.Size = new Size(794, 361);
            dgvAlquileres.TabIndex = 0;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(722, 399);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(75, 23);
            btnFinalizar.TabIndex = 1;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(722, 3);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // estadoComboBox
            // 
            estadoComboBox.Dock = DockStyle.Right;
            estadoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            estadoComboBox.FormattingEnabled = true;
            estadoComboBox.Location = new Point(595, 3);
            estadoComboBox.Name = "estadoComboBox";
            estadoComboBox.Size = new Size(121, 23);
            estadoComboBox.TabIndex = 3;
            // 
            // btnResetFiltro
            // 
            btnResetFiltro.BackColor = SystemColors.Control;
            btnResetFiltro.Dock = DockStyle.Right;
            btnResetFiltro.Location = new Point(498, 3);
            btnResetFiltro.Name = "btnResetFiltro";
            btnResetFiltro.Size = new Size(91, 23);
            btnResetFiltro.TabIndex = 4;
            btnResetFiltro.Text = "Reset Filtro";
            btnResetFiltro.UseVisualStyleBackColor = false;
            btnResetFiltro.Click += btnResetFiltro_Click;
            // 
            // tsAlquiler
            // 
            tsAlquiler.Dock = DockStyle.None;
            tsAlquiler.Items.AddRange(new ToolStripItem[] { tsNuevo });
            tsAlquiler.Location = new Point(3, 0);
            tsAlquiler.Name = "tsAlquiler";
            tsAlquiler.Size = new Size(58, 25);
            tsAlquiler.TabIndex = 0;
            // 
            // tsNuevo
            // 
            tsNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsNuevo.ImageTransparentColor = Color.Magenta;
            tsNuevo.Name = "tsNuevo";
            tsNuevo.Size = new Size(46, 22);
            tsNuevo.Text = "Nuevo";
            tsNuevo.TextImageRelation = TextImageRelation.TextBeforeImage;
            tsNuevo.Click += tsNuevo_Click;
            // 
            // AlquilerLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tscAlquiler);
            Name = "AlquilerLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alquileres";
            Load += AlquilerLista_Load;
            tscAlquiler.ContentPanel.ResumeLayout(false);
            tscAlquiler.TopToolStripPanel.ResumeLayout(false);
            tscAlquiler.TopToolStripPanel.PerformLayout();
            tscAlquiler.ResumeLayout(false);
            tscAlquiler.PerformLayout();
            tlAlquileres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlquileres).EndInit();
            tsAlquiler.ResumeLayout(false);
            tsAlquiler.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tscAlquiler;
        private TableLayoutPanel tlAlquileres;
        private ToolStrip tsAlquiler;
        private Button btnFinalizar;
        private ComboBox estadoComboBox;
        private DataGridView dgvAlquileres;
        private Button btnFiltrar;
        private ToolStripButton tsNuevo;
        private Button btnResetFiltro;
    }
}
