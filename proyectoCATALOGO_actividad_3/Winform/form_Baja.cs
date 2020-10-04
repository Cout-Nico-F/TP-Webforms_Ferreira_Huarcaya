using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Winform
{
    public partial class form_Baja : Form
    {
        private Articulo _articuloSeleccionado;
        public form_Baja()
        {
            InitializeComponent();
        }

        public form_Baja(Articulo articuloSeleccionado)
        {
            _articuloSeleccionado = articuloSeleccionado;
            InitializeComponent();
        }

        private void form_Baja_Load(object sender, EventArgs e)
        {
            List<Articulo> lista = new List<Articulo>();
            lista.Add(_articuloSeleccionado);
            dgv_Baja.DataSource = lista;

            try
            {
                pb_Baja.Load(_articuloSeleccionado.ImagenUrl);
            }
            catch (Exception)
            {
            }
        }

        private void btn_AceptarBaja_Click(object sender, EventArgs e)
        {
            ArticulosNegocio articuloNegocio = new ArticulosNegocio();
            articuloNegocio.bajaArticulo(_articuloSeleccionado.Id);

            MessageBox.Show("Articulo eliminado exitosamente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void btn_CancelarBaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
