using egk.netcore_boilerplate.api.Data;
using egk.netcore_boilerplate.api.Data.Models;
using egk.netcore_boilerplate.api.Data.Repositories;
using egk.netcore_boilerplate.api.Data.Services.Contracts;
using Microsoft.AspNetCore.JsonPatch;
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
        public virtual async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await baseService.GetAsync());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await baseService.GetByIDAsync(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost()]
        public virtual async Task<IActionResult> Create([FromBody] TEntity entity)
        {
            try
            {
                TEntity newEntity = await baseService.InsertAsync(entity);
                return Ok(newEntity);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update([FromRoute] int id, [FromBody] TEntity entity)
        {
            try
            {
                var entityToUpdate = await baseService.GetByIDAsync(id);

                if (entityToUpdate == null)
                {
                    return NotFound();
                }

                bool updated = await baseService.UpdateAsync(entity);
                return Ok(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPatch("{id}")]
        public virtual async Task<IActionResult> Patch([FromRoute] int id, [FromBody] JsonPatchDocument<TEntity> patchEntity)
        {
            try
            {
                var entityToUpdate = await baseService.GetByIDAsync(id);

                if (entityToUpdate == null)
                {
                    return NotFound();
                }

                patchEntity.ApplyTo(entityToUpdate, ModelState);

                bool updated = await baseService.UpdateAsync(entityToUpdate);

                return Ok(entityToUpdate);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool deleted = await baseService.DeleteAsync(id);
                return Ok(deleted);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
