using AutoMapper;
using DotnetPrincples.Interfaces;
using DotnetPrincples.Models;
using DotnetPrincples.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetPrincples.Controllers.Samples
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : BaseController //Inherits from a base controller
    {
        private readonly IGeneralService _generalService;
        private readonly IGeneric<Project> _projectAddition;
        private readonly IGeneric<Services.Task> _taskAddition;
        private readonly IMapper _mapper;
        private readonly IExampleServicecs _exampleService;
        public SampleController(IGeneralService generalService, IGeneric<Project> projectAddition, IGeneric<Services.Task> taskAddition, IMapper mapper, IExampleServicecs exampleService)
        { 
            _generalService= generalService;
            _projectAddition= projectAddition;
            _taskAddition= taskAddition;
            _mapper= mapper;
            _exampleService= exampleService;
        }
        [HttpPost]
        public async Task<IActionResult> Sample()
        {
            try
            {
                IReturnValue result = await _generalService.TestFuncFunctionality();
                int projectAddition = await _projectAddition.Add(5, 6);
                int taskAddition = await _taskAddition.Add(5, 6);
                if (result == null)
                {
                    return Ok(new { action = "none", people = "forgiving" });
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetDetail")]
        public async Task<IActionResult> GetDetails()
        {
            try
            {
                SampleClass sampleClass = new SampleClass();
                int res = (int)SampleClass.Levels.second;
                string user = authorizedUsers[res];
                return Ok(user + sampleClass.encapsulation);
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("AutoMapper")]
        public async Task<IActionResult> AutoMapping(SampleReturnA sampleA)
        {
            try
            {
                SampleReturnB query = _mapper.Map<SampleReturnB>(sampleA);                
                return Ok(await _exampleService.Convert(query));
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
