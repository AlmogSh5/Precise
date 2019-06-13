using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2bPrecise.Data;
using _2bPrecise.Data.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace _2bPrecise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskItemController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkGenerator;

        public TaskItemController(IEmployeeRepository repository, IMapper mapper, LinkGenerator linkGenerator)
        {
            _repository = repository;
            _mapper = mapper;
            _linkGenerator = linkGenerator;
        }

        [HttpGet]
        public async Task<ActionResult<TaskItemModel[]>> GetEmployeeTaskItems(int employeeId)
        {
            try
            {
                var results = await _repository.GetTaskItemsByEmployeeAsync(employeeId);
                if (results == null) { NotFound($"Could not find tasks for employee {employeeId}"); }

                return _mapper.Map<TaskItemModel[]>(results);
            }
            catch (Exception)
            {
                return BadRequest("Couldn't get tasks.");
            }
        }
    }
}
