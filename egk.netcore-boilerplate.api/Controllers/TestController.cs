using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using egk.netcore_boilerplate.api.Data;
using egk.netcore_boilerplate.api.Data.Models;
using egk.netcore_boilerplate.api.Data.Repositories;
using egk.netcore_boilerplate.api.Data.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace egk.netcore_boilerplate.api.Controllers
{

    public class TestController : BaseController<Product,NorthwindContext>
    {
        private readonly IBaseService<Product, NorthwindContext> baseService;

        //public TestController(GenericRepository<Product,NorthwindContext> _repository) : base(_repository)
        //{
        //}

        public TestController(IBaseService<Product, NorthwindContext> _baseService) : base(_baseService)
        {
            baseService = _baseService;
        }

        [HttpGet("GetFiltered")]
        public IActionResult GetFiltered()
        {
            return Ok(baseService.Count(q=>q.CategoryID ==2));
        }
    }
}