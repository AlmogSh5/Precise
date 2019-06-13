using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2bPrecise.Data;
using _2bPrecise.Data.Models;
using _2bPrecise.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace _2bPrecise.Controllers
{
    [Route("api/Employee/{managerId:int}/Report")]
    [ApiController]
    public class ReportItemController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public ReportItemController(IEmployeeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ReportItemModel[]>> GetManagerReportItems(int managerId)
        {
            try
            {
                var results = await _repository.GetReportItemsByManagerAsync(managerId);
                if (results == null) { NotFound($"Could not find reports for manager {managerId}"); }

                return _mapper.Map<ReportItemModel[]>(results);
            }
            catch (Exception)
            {
                return BadRequest("Couldn't get reports.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<ReportItemModel[]>> Post(ReportItemModel model)
        {
            try
            {
                // Create the Camp
                var report = _mapper.Map<ReportItem>(model);
                _repository.Add(report);
                if (await _repository.SaveChangesAsync())
                {
                    return Created("", _mapper.Map<ReportItemModel>(report));
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }
            }
            catch (Exception)
            {
                return BadRequest("Couldn't get reports.");
            }
        }
    }
}
