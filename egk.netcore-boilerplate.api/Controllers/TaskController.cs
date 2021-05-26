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

    public class TaskController : BaseController<Data.Models.Task, TaskSystemContext>
    {
        private readonly IBaseService<Data.Models.Task, TaskSystemContext> baseService;

        public TaskController(IBaseService<Data.Models.Task, TaskSystemContext> _baseService) : base(_baseService)
        {
            baseService = _baseService;
        }

        [HttpGet()]
        public override async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await baseService.GetAsync(orderBy: q => q.OrderBy(a => a.IsDone)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet("/api/task/GetAllTasksByProjectId/{projectId}")]
        public async Task<IActionResult> GetAllTasksByProjectId(int projectId)
        {
            try
            {
                return Ok(await baseService.GetAsync(filter: q=>q.ProjectId == projectId ,orderBy: q => q.OrderBy(a => a.IsDone)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}