using ApiPrueba.Controllers.Data;
using ApiPrueba.Controllers.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly ApiContext context;

        public ProductosController(ApiContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Producto>> Get()
        {
            return context.Productos.ToList();
        }

        [HttpPost]
        public ActionResult<Producto> Post([FromBody] Producto producto)
        {
            context.Productos.Add(producto);
            context.SaveChanges();
            return new CreatedAtRouteResult("ObtenerProductoPorId", new { id = producto.Id }, producto);
        }

        [HttpPut("{id}")]
        public ActionResult<Producto> Put(int id, [FromBody] Producto producto)
        {
            if (id != producto.Id)
            {
                return BadRequest();
            }

            context.Entry(producto).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]

        public ActionResult<Producto> Delete(int id)
        { 
            var producto = context.Productos.FirstOrDefault(p => p.Id == id);
            if (producto == null)
            {
                return NotFound();
            }

            context.Productos.Remove(producto);
            context.SaveChanges();
            return Ok();
        }

    }
}
