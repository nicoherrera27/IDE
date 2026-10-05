using Herrera.APIClients;
using Herrera.Dominio;
using Herrera.DTO;
using System.Threading.Tasks;
namespace Herrera.Presentacion
{
    public partial class AlquilerLista : Form
    {
        public AlquilerLista()
        {
            InitializeComponent();
        }

        private async Task ListarAsync()
        {
            try
            {
                var listaAlquileres = await AlquilerApiClient.GetAllAsync();

                dgvAlquileres.DataSource = null;
                dgvAlquileres.DataSource = listaAlquileres;
                dgvAlquileres.ReadOnly = true;

                estadoComboBox.DataSource = Enum.GetValues(typeof(EstadoAlquiler));

                dgvAlquileres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los alquileres: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ListarPorEstadoAsync(EstadoAlquiler estado)
        {
            try
            {
                var listaAlquileres = await AlquilerApiClient.GetByEstadoAsync(estado);
                dgvAlquileres.DataSource = null;
                dgvAlquileres.DataSource = listaAlquileres;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar los alquileres por estado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AlquilerLista_Load(object sender, EventArgs e)
        {
            await ListarAsync();
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (estadoComboBox.SelectedItem is EstadoAlquiler estado)
            {
                await ListarPorEstadoAsync(estado);
            }
        }

        private async void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (dgvAlquileres.SelectedRows.Count == 0 || dgvAlquileres.SelectedRows[0].DataBoundItem is not AlquilerDTO selected)
            {
                MessageBox.Show("Seleccione un alquiler de la lista para finalizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var response = await AlquilerApiClient.DeleteAsync(selected.Id);

                if (!response)
                {
                    MessageBox.Show("No se pudo finalizar el alquiler.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await ListarAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al finalizar el alquiler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tsNuevo_Click(object sender, EventArgs e)
        {
            AlquilerAlta formAlta = new AlquilerAlta();
            formAlta.ShowDialog();

            await ListarAsync();
        }

        private async void btnResetFiltro_Click(object sender, EventArgs e)
        {
            await ListarAsync();
        }
    }
}
