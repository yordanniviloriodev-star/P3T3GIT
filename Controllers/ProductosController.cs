using Microsoft.AspNetCore.Mvc;
using CrudGitFlow.Models;
using CrudGitFlow.Repositories;
using CrudGitFlow.DTOs;

namespace CrudGitFlow.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoRepository _repositorio;

        public ProductosController(ProductoRepository repositorio)
        {
            _repositorio = repositorio;
        }

        // GET api/productos
        [HttpGet]
        public ActionResult<List<Producto>> ObtenerTodos()
        {
            return Ok(_repositorio.ObtenerTodos());
        }

        // GET api/productos/5
        [HttpGet("{id}")]
        public ActionResult<Producto> ObtenerPorId(int id)
        {
            var producto = _repositorio.ObtenerPorId(id);
            if (producto is null) return NotFound($"No existe un producto con id {id}");
            return Ok(producto);
        }

        // POST api/productos
        [HttpPost]
        public ActionResult<Producto> Crear([FromBody] ProductoDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var producto = new Producto
            {
                Nombre = dto.Nombre,
                Precio = dto.Precio,
                Stock = dto.Stock
            };

            var creado = _repositorio.Crear(producto);
            return CreatedAtAction(nameof(ObtenerPorId), new { id = creado.Id }, creado);
        }

        // PUT api/productos/5
        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] ProductoDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var producto = new Producto
            {
                Nombre = dto.Nombre,
                Precio = dto.Precio,
                Stock = dto.Stock
            };

            var actualizado = _repositorio.Actualizar(id, producto);
            if (!actualizado) return NotFound($"No existe un producto con id {id}");
            return NoContent();
        }

        // DELETE api/productos/5
        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var eliminado = _repositorio.Eliminar(id);
            if (!eliminado) return NotFound($"No existe un producto con id {id}");
            return NoContent();
        }
    }
}
