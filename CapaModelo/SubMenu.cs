using System;

namespace CapaModelo
{
    public class SubMenu
    {
        public int IdSubMenu { get; set; }
        public int IdMenu { get; set; }
        public string Nombre { get; set; }
        public string NombreFormulario { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
