namespace CrudGitFlow.Models
{
    // Representa un producto dentro del sistema.
    // Esta clase es el "molde" de los datos que vamos a guardar.
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string? Categoria { get; set; } // Categoría opcional del producto

        
    }
}
