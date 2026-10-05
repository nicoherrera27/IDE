using Herrera.API.Clients;
using Herrera.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herrera.PresentacionWinForm
{
    public partial class PromocionAlta : Form
    {
        public PromocionAlta()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                PromocionDTO promo = new PromocionDTO
                {
                    Nombre = txtNombre.Text,
                    FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dtpFechaFin.Value),
                    Descuento = (int)numDescuento.Value
                };
                HttpResponseMessage response = await PromocionApiClient.AddAsync(promo);
                if (!response.IsSuccessStatusCode)
                {
                    //gemini me tiro esta para mostrar tal cual el error de la validacion
                    string json = await response.Content.ReadAsStringAsync();
                    var node = JsonNode.Parse(json);
                    string mensaje = node?["error"]?.ToString() ?? "Error al guardar la promocion.";
                    //gemini me tiro esta para mostrar tal cual el error de la validacion

                    MessageBox.Show(mensaje, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error al guardar la promocion: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
