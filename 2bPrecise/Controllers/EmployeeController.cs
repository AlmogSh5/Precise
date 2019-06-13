using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using _2bPrecise.Data;
using _2bPrecise.Data.Models;

namespace _2bPrecise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeController(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<EmployeeModel[]>> GetAllEmployees()
        {
            try
            {
                var results = await _repository.GetAllEmployeesAsync();
                if (results == null) { return BadRequest("No Employees Found"); }

                return _mapper.Map<EmployeeModel[]>(results);

            }
            catch (Exception)
            {
                return BadRequest("Couldn't get employees");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<EmployeeModel>> GetAllEmployees(int id)
        {
            try
            {
                var result = await _repository.GetEmployeeAsync(id);
                if (result == null) { return NotFound($"No Employees Found with id of {id}"); }

                return _mapper.Map<EmployeeModel>(result);

            }
            catch (Exception)
            {
                return BadRequest("Couldn't get employees");
            }
        }
    }
}