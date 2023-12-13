using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicio_actas_farmaceuticas
{
    public partial class Menu_opciones : Form
    {
        public Menu_opciones()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnIngresoActas_Click(object sender, EventArgs e)
        {
            var frm = new Ingreso_actas();
            frm.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistroLaboratorio_Click(object sender, EventArgs e)
        {
            var frm = new Registro_laboratorio();
            frm.Show();
            this.Hide();
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {
            var frm = new Registro_producto();
            frm.Show();
            this.Hide();
        }

        private void btnIngresarDatosProveedor_Click(object sender, EventArgs e)
        {
            var frm = new Registro_proveedor();
            frm.Show();
            this.Hide();
        }
    }
}
