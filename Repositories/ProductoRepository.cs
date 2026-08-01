using CrudGitFlow.Models;

namespace CrudGitFlow.Repositories
{
    // Guarda los productos en memoria (una lista).
    // En un proyecto real esto se conectaría a una base de datos,
    // pero para el CRUD de este ejercicio esto es suficiente y más fácil de entender.
    public class ProductoRepository
    {
        private readonly List<Producto> _productos = new();
        private int _siguienteId = 1;

        public List<Producto> ObtenerTodos() => _productos;

        public Producto? ObtenerPorId(int id) =>
            _productos.FirstOrDefault(p => p.Id == id);

        public Producto Crear(Producto producto)
        {
            producto.Id = _siguienteId++;
            producto.FechaCreacion = DateTime.UtcNow;
            _productos.Add(producto);
            return producto;
        }

        public bool Actualizar(int id, Producto datosNuevos)
        {
            var producto = ObtenerPorId(id);
            if (producto is null) return false;

            producto.Nombre = datosNuevos.Nombre;
            producto.Precio = datosNuevos.Precio;
            producto.Stock = datosNuevos.Stock;
            return true;
        }

        public bool Eliminar(int id)
        {
            var producto = ObtenerPorId(id);
            if (producto is null) return false;

            _productos.Remove(producto);
            return true;
        }
    }
}
