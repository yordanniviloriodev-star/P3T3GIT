using System.ComponentModel.DataAnnotations;

namespace CrudGitFlow.DTOs
{
    // DTO = "Data Transfer Object". Es la forma de los datos que el cliente
    // nos envía. Aquí validamos que la información llegue correcta
    // ANTES de tocar la lógica de negocio.
    public class ProductoDTO
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que 0")]
        public decimal Precio { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "El stock no puede ser negativo")]
        public int Stock { get; set; }
    }
}
