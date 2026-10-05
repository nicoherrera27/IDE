namespace Herrera.PresentacionWinForm
{
    partial class PromocionLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromocionLista));
            tscPromociones = new ToolStripContainer();
            tlPromociones = new TableLayoutPanel();
            btnFiltrar = new Button();
            btnResetFiltro = new Button();
            btnExpirar = new Button();
            comboBoxEstado = new ComboBox();
            dgvPromociones = new DataGridView();
            tsPromos = new ToolStrip();
            tsNuevo = new ToolStripButton();
            tscPromociones.ContentPanel.SuspendLayout();
            tscPromociones.TopToolStripPanel.SuspendLayout();
            tscPromociones.SuspendLayout();
            tlPromociones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).BeginInit();
            tsPromos.SuspendLayout();
            SuspendLayout();
            // 
            // tscPromociones
            // 
            // 
            // tscPromociones.ContentPanel
            // 
            tscPromociones.ContentPanel.Controls.Add(tlPromociones);
            tscPromociones.ContentPanel.Size = new Size(800, 425);
            tscPromociones.Dock = DockStyle.Fill;
            tscPromociones.Location = new Point(0, 0);
            tscPromociones.Name = "tscPromociones";
            tscPromociones.Size = new Size(800, 450);
            tscPromociones.TabIndex = 0;
            tscPromociones.Text = "toolStripContainer1";
            // 
            // tscPromociones.TopToolStripPanel
            // 
            tscPromociones.TopToolStripPanel.Controls.Add(tsPromos);
            // 
            // tlPromociones
            // 
            tlPromociones.ColumnCount = 3;
            tlPromociones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlPromociones.ColumnStyles.Add(new ColumnStyle());
            tlPromociones.ColumnStyles.Add(new ColumnStyle());
            tlPromociones.Controls.Add(btnFiltrar, 2, 0);
            tlPromociones.Controls.Add(btnResetFiltro, 0, 0);
            tlPromociones.Controls.Add(btnExpirar, 2, 2);
            tlPromociones.Controls.Add(comboBoxEstado, 1, 0);
            tlPromociones.Controls.Add(dgvPromociones, 0, 1);
            tlPromociones.Dock = DockStyle.Fill;
            tlPromociones.Location = new Point(0, 0);
            tlPromociones.Name = "tlPromociones";
            tlPromociones.RowCount = 3;
            tlPromociones.RowStyles.Add(new RowStyle());
            tlPromociones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlPromociones.RowStyles.Add(new RowStyle());
            tlPromociones.Size = new Size(800, 425);
            tlPromociones.TabIndex = 0;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(722, 3);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 23);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnResetFiltro
            // 
            btnResetFiltro.Dock = DockStyle.Right;
            btnResetFiltro.Location = new Point(514, 3);
            btnResetFiltro.Name = "btnResetFiltro";
            btnResetFiltro.Size = new Size(75, 23);
            btnResetFiltro.TabIndex = 1;
            btnResetFiltro.Text = "Reset Filtro";
            btnResetFiltro.UseVisualStyleBackColor = true;
            btnResetFiltro.Click += btnResetFiltro_Click;
            // 
            // btnExpirar
            // 
            btnExpirar.Location = new Point(722, 399);
            btnExpirar.Name = "btnExpirar";
            btnExpirar.Size = new Size(75, 23);
            btnExpirar.TabIndex = 2;
            btnExpirar.Text = "Expirar";
            btnExpirar.UseVisualStyleBackColor = true;
            btnExpirar.Click += btnExpirar_Click;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(595, 3);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 23);
            comboBoxEstado.TabIndex = 3;
            // 
            // dgvPromociones
            // 
            dgvPromociones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromociones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlPromociones.SetColumnSpan(dgvPromociones, 3);
            dgvPromociones.Dock = DockStyle.Fill;
            dgvPromociones.Location = new Point(3, 32);
            dgvPromociones.Name = "dgvPromociones";
            dgvPromociones.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvPromociones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromociones.Size = new Size(794, 361);
            dgvPromociones.TabIndex = 4;
            // 
            // tsPromos
            // 
            tsPromos.Dock = DockStyle.None;
            tsPromos.Items.AddRange(new ToolStripItem[] { tsNuevo });
            tsPromos.Location = new Point(3, 0);
            tsPromos.Name = "tsPromos";
            tsPromos.Size = new Size(58, 25);
            tsPromos.TabIndex = 0;
            // 
            // tsNuevo
            // 
            tsNuevo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsNuevo.Image = (Image)resources.GetObject("tsNuevo.Image");
            tsNuevo.ImageTransparentColor = Color.Magenta;
            tsNuevo.Name = "tsNuevo";
            tsNuevo.Size = new Size(46, 22);
            tsNuevo.Text = "Nuevo";
            tsNuevo.Click += tsNuevo_Click;
            // 
            // PromocionLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tscPromociones);
            Name = "PromocionLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Promociones";
            Load += PromocionLista_Load;
            tscPromociones.ContentPanel.ResumeLayout(false);
            tscPromociones.TopToolStripPanel.ResumeLayout(false);
            tscPromociones.TopToolStripPanel.PerformLayout();
            tscPromociones.ResumeLayout(false);
            tscPromociones.PerformLayout();
            tlPromociones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPromociones).EndInit();
            tsPromos.ResumeLayout(false);
            tsPromos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tscPromociones;
        private TableLayoutPanel tlPromociones;
        private Button btnFiltrar;
        private Button btnResetFiltro;
        private Button btnExpirar;
        private ComboBox comboBoxEstado;
        private DataGridView dgvPromociones;
        private ToolStrip tsPromos;
        private ToolStripButton tsNuevo;
    }
}
