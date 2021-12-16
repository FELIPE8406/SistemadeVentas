namespace CapaModelo
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public int ValorCodigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public Categoria oCategoria { get; set; }
        public bool Activo { get; set; }

    }
}
