/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoEstagioV5.Model;
using ProjetoEstagioV5.Repositorio;
using ProjetoEstagioV5.Dao;

namespace ProjetoEstagioV5.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ProductRepositorio _productRepositorio;

        public ValuesController()
        {
            _productRepositorio = new ProductRepositorio();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _productRepositorio.GetProducts;
        }

        // GET api/values/5
        [HttpGet("{Name}")]
        public ActionResult<IEnumerable<Product>> Get(string Name)
        {
            return _productRepositorio.GetProducts;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
*/