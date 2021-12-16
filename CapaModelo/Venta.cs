using System;
using System.Collections.Generic;

namespace CapaModelo
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string TipoDocumento { get; set; }
        public string Codigo { get; set; }
        public float TotalCosto { get; set; }
        public float ValorRecibido { get; set; }
        public float ValorCambio { get; set; }
        public string FechaRegistro { get; set; }
        public DateTime VFechaRegistro { get; set; }
        public Usuario oUsuario { get; set; }
        public Tienda oTienda { get; set; }
        public Cliente oCliente { get; set; }
        public List<DetalleVenta> oListaDetalleVenta { get; set; }

    }
}
