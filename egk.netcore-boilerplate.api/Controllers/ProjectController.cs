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

    public class ProjectController : BaseController<Data.Models.Project, TaskSystemContext>
    {
        private readonly IBaseService<Data.Models.Project, TaskSystemContext> baseService;

        public ProjectController(IBaseService<Data.Models.Project, TaskSystemContext> _baseService) : base(_baseService)
        {
            baseService = _baseService;
        }
    }
}