
using Herrera.APIClients;
using Herrera.DTO;
using System.Text.Json.Nodes;
namespace Herrera.Presentacion
{
    public partial class AlquilerAlta : Form
    {
        public AlquilerAlta()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                AlquilerDTO alquiler = new AlquilerDTO
                {
                    Inquilino = txtInquilino.Text,
                    MontoAlquiler = (float)numMonto.Value,
                    FechaInicio = dtpFechaInicio.Value,
                    FechaFin = dtpFechaFin.Value
                };

                HttpResponseMessage response = await AlquilerApiClient.AddAsync(alquiler);
                if (!response.IsSuccessStatusCode)
                {
                    //gemini me tiro esta para mostrar tal cual el error de la validacion
                    string json = await response.Content.ReadAsStringAsync();
                    var node = JsonNode.Parse(json);
                    string mensaje = node?["error"]?.ToString() ?? "Error al guardar el alquiler.";
                    //gemini me tiro esta para mostrar tal cual el error de la validacion

                    MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el alquiler: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
