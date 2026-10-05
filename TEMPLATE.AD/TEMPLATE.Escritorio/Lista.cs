using TEMPLATE.Domain;

namespace TEMPLATE.Escritorio
{
    public partial class Lista : Form
    {
        public Lista()
        {
            InitializeComponent();
        }

        private async void Listar()
        {
            try
            {
                string estado = cmbEstado.SelectedItem.ToString();

                dgvClase.DataSource = null;
                dgvClase.DataSource = await ClaseApiClient.GetByEstadoAsync(estado);
                if (dgvClase.Rows.Count > 0)
                {
                    btnFinalizar.Enabled = true;
                }
                else
                {
                    btnFinalizar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los Clasees: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Clase SelectedItem()
        {
            if (dgvClase.SelectedRows.Count > 0)
            {
                return dgvClase.SelectedRows[0].DataBoundItem as Clase;
            }
            return null;
        }
        private void Lista_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 0;
            Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            try 
            {
                Clase Clase = SelectedItem();
                if (Clase != null)
                {
                    DialogResult result = MessageBox.Show($"¿Está seguro de finalizar el Clase del cliente {Clase.Nombre}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (Clase.Estado == "Finalizado")
                        {
                            MessageBox.Show("El Clase ya está finalizado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else 
                        {
                            await ClaseApiClient.FinalizarAsync(Clase.Id);
                            Listar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un Clase para finalizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al finalizar el Clase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try 
            {
                Agregar ClaseDetalle = new Agregar();
                ClaseDetalle.ShowDialog();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario de agregar Clase: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
