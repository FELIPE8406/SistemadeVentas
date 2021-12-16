using System;
using System.Collections.Generic;

namespace CapaModelo
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public string Codigo { get; set; }
        public string FechaCompra { get; set; }
        public string NumeroCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor oProveedor { get; set; }
        public Tienda oTienda { get; set; }
        public List<DetalleCompra> oListaDetalleCompra { get; set; }
        public float TotalCosto { get; set; }
        public string TipoComprobante { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
