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
    public class ProdutosController : ControllerBase
    {
        private object? result;

        [HttpPost]
        [ProducesResponseType(typeof(ProdutosGetModel), 201)]
        public IActionResult Post(ProdutosPostModel model, [FromServices] IMapper mapper)
  
        {
            try
            {
                var produto = mapper.Map<Produto>(model);
                var produtoRepository = new ProdutoRepository();
                produtoRepository.Add(produto);

                return StatusCode(201, result);
            }

            catch (Exception e)
            {
                return StatusCode(500, new { error = e.Message }); 
            }

        }

        [HttpPut]
        [ProducesResponseType(typeof(ProdutosGetModel), 200)]
        public IActionResult Put(ProdutosPutModel model, [FromServices] IMapper mapper)
        {
            try
            {
                var produtoRepository = new ProdutoRepository();
                var produto = produtoRepository.GetById(model.Idproduto);

                if (produto != null)
                {
                    produto.Nome = model.Nome;
                    produto.Descricao = model.Descricao;
                    produto.Preco = model.Preco;
                    produto.Quantidade = model.Quantidade;
                    produto.IdCategoria = model.IdCategoria;
                    produto.DataHoraUltimaAlteracao = DateTime.Now;

                    produtoRepository.Update(produto);

                    var result = mapper.Map<ProdutosGetModel>(produto);
                    return StatusCode(200, result);

                }

                else
                {
                    return StatusCode(400, new { error = "produto nao encontrado" });
                }
            }

            catch (Exception e)
            {
                return StatusCode(500, new { error = e.Message });
            }
        }

        [HttpDelete("id")]
        [ProducesResponseType(typeof(ProdutosGetModel), 200)]
        public IActionResult Delete(Guid? id, [FromServices] IMapper mapper) 
        {
            try
            {
                var produtoRepository = new ProdutoRepository();
                var produto = produtoRepository.GetById(id.Value);  

                if (produto != null)
                {
                   
                    produtoRepository.Delete(produto);

                    var result = mapper.Map<ProdutosGetModel>(produto);
                    return StatusCode(200, result);

                }

                else
                {
                    return StatusCode(400, new { error = "produto nao encontrado" });
                }
            }

            catch (Exception e)
            {
                return StatusCode(500, new { error = e.Message });
            }
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutosGetModel>), 200)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("id")]
        [ProducesResponseType(typeof(ProdutosGetModel), 200)]
        public IActionResult GetbyId(Guid? id)
        {
            return Ok();
        }

    }
}

