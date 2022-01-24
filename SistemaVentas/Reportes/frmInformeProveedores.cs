using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Reportes
{
    public partial class frmInformeProveedores : Form
    {
        public frmInformeProveedores()
        {
            InitializeComponent();
        }

        private void frmInformeProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsSistema.usp_ObtenerProveedores' Puede moverla o quitarla según sea necesario.
            this.usp_ObtenerProveedoresTableAdapter.Fill(this.DsSistema.usp_ObtenerProveedores);

            this.reportViewer1.RefreshReport();
        }
    }
}
