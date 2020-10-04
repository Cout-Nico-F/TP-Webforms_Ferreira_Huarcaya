using Modelo;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form_Listado : Form
    {
        public Form_Listado()
        {
            InitializeComponent();
        }
        private void Form_Listado_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgv_Listado.DataSource = negocio.ListarArticulos();
        }

        private void dgvListar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Listado.CurrentRow != null)
                {
                    Articulo reg = (Articulo)dgv_Listado.CurrentRow.DataBoundItem;
                    pb_Imagen.Load(reg.ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                pb_Imagen.Image = null; //de esta manera se setea en nula la imagen para que no muestre la anterior.
            }
        }

        private void btn_VolverListado_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
