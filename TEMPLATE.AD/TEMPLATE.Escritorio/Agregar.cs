using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEMPLATE.Domain;

namespace TEMPLATE.Escritorio
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            Clase clase = new Clase();
            clase.Nombre = txtInquilino.Text;
            clase.Monto = (int)numMontoAlquiler.Value;
            clase.FechaInicio = tpFechaIni.Value.Date;
            clase.FechaFin = tpFechaFin.Value.Date;
            try 
            {
                if (ClaseValidation.isValid(clase))
                {
                    await ClaseApiClient.PostAsync(clase);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Datos inválidos. Por favor, verifique los campos.");
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error al agregar el alquiler: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            tpFechaIni.Value = DateTime.Now;
            tpFechaFin.Value = DateTime.Now.AddMonths(1);
        }
    }
}
