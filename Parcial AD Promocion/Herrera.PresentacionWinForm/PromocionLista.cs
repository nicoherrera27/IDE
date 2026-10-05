using Herrera.API.Clients;
using Herrera.Domain;
using Herrera.DTO;
using System.Threading.Tasks;

namespace Herrera.PresentacionWinForm
{
    public partial class PromocionLista : Form
    {
        public PromocionLista()
        {
            InitializeComponent();
        }
        private void SetComponentes()
        {
            dgvPromociones.Columns["Descuento"].DefaultCellStyle.Format = "0'%'";
            comboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoProm));
        }
        private async Task Listar()
        {
            try
            {
                var listaPromos = await PromocionApiClient.GetAllAsync();

                dgvPromociones.DataSource = null;
                dgvPromociones.DataSource = listaPromos;

                SetComponentes();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar promociones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ListarPorEstado(EstadoProm estado)
        {
            try
            {
                var listaPromos = await PromocionApiClient.GetByEstadoAsync(estado);

                dgvPromociones.DataSource = null;
                dgvPromociones.DataSource = listaPromos;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar promociones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void PromocionLista_Load(object sender, EventArgs e)
        {
            await Listar();
        }

        private async void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (comboBoxEstado.SelectedItem is EstadoProm estado)
            {
                await ListarPorEstado(estado);
            }
        }

        private async void btnResetFiltro_Click(object sender, EventArgs e)
        {
            await Listar();
        }

        private async void tsNuevo_Click(object sender, EventArgs e)
        {
            PromocionAlta formAlta = new PromocionAlta();
            formAlta.ShowDialog();

            await Listar();
        }
        private PromocionDTO? SelectedItem()
        {
            if (dgvPromociones.SelectedRows.Count == 0)
                return null;

            return dgvPromociones.SelectedRows[0].DataBoundItem as PromocionDTO;
        }
        private async void btnExpirar_Click(object sender, EventArgs e)
        {
            try
            {
                var promo = SelectedItem();
                if (promo == null)
                {
                    MessageBox.Show("Seleccione un alquiler de la lista para finalizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var response = await PromocionApiClient.DeleteAsync(promo.Id);
                if (!response)
                {
                    MessageBox.Show("No se pudo expirar la promoción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                await Listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al expirar promociones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
