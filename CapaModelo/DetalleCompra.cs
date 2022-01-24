using System;

namespace CapaModelo
{
    public class DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public int IdCompra { get; set; }
        public Producto OProducto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitarioCompra { get; set; }
        public float PrecioUnitarioVenta { get; set; }
        public float TotalCosto { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
