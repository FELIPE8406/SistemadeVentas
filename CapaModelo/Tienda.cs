using System;

namespace CapaModelo
{

    public class Tienda
    {
        public int IdTienda { get; set; }
        public string Nombre { get; set; }
        public string NIT { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
