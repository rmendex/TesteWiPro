using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WiProApiFila.Dominio.Contratos;
using WiProApiFila.Dominio.Entidades;
using WiProApiFila.Repositorio.Repositorios;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WiProApiFila.Web.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {

        private readonly IITemRepositorio _itemRepositorio;

        public ItemController(IITemRepositorio itemRepositorio)
        {
            this._itemRepositorio = itemRepositorio;
        }


        // GET: api/Item
        [HttpGet("obteritem")]
        public IActionResult ObterItem()
        {
            try
            {
                return Json(_itemRepositorio.ObterProxItem()); ;
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost("adicionaritem")]
        public IActionResult AdicionarItem([FromBody]List<Item> itens)
        {
            try
            {
                foreach (var item in itens)
                {
                    _itemRepositorio.Adicionar(item);
                }

                return Created("api/item", itens);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}
