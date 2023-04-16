using ApiProdutos.Data.Entities;
using ApiProdutos.Data.Repositories;
using ApiProdutos.Services.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProdutos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(CategoriasGetModel), 201)]
        public IActionResult Post(CategoriasPostModel model, [FromServices] IMapper mapper)
        {
            try
            {
                var categoria = mapper.Map <Categoria> (model);
             

                var categoriaRepository = new CategoriaRepository();
                categoriaRepository.Add(categoria);

                var result = mapper.Map<CategoriasGetModel> (model);

                return StatusCode(201, result);
            }
            catch (Exception e)
            {
                return StatusCode(500, new {error = e.Message});
            }
        }

        [HttpPut]
        [ProducesResponseType(typeof(CategoriasGetModel), 200)]

        public IActionResult Put(CategoriasPutModel model)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(CategoriasGetModel), 200)]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<CategoriasGetModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CategoriasGetModel), 200)]
        public IActionResult GetByID(Guid? id)
        {
            return Ok();
        }
    }
}

