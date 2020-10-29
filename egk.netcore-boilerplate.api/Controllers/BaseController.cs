using egk.netcore_boilerplate.api.Data;
using egk.netcore_boilerplate.api.Data.Models;
using egk.netcore_boilerplate.api.Data.Repositories;
using egk.netcore_boilerplate.api.Data.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace egk.netcore_boilerplate.api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class BaseController<TEntity, TContext> : ControllerBase where TEntity : class where TContext : IDBContext, new()
    {
        private readonly IBaseService<TEntity, TContext> baseService;

        public BaseController(IBaseService<TEntity, TContext> _baseService)
        {
            baseService = _baseService;
        }

        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            return Ok(await baseService.GetAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await baseService.GetByIDAsync(id));
        }
        [HttpPost()]
        public async Task<IActionResult> Create([FromBody] TEntity entity)
        {
            TEntity newEntity= await baseService.InsertAsync(entity);
            return Ok(newEntity);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] TEntity entity)
        {
            bool updated = await baseService.UpdateAsync(entity);
            return Ok(updated);
        }
        [HttpDelete()]
        public async Task<IActionResult> Delete(int id)
        {
            bool deleted = await baseService.DeleteAsync(id);
            return Ok(deleted);
        }

    }
}
