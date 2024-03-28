using DemoVineForce.States;
using DemoVineForce.States.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoVineForce.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateService _stateService;
        public StateController(IStateService stateServive)
        {
            _stateService = stateServive;
        }

        [HttpGet]
        public IActionResult GetState()
        {
            var stateList = _stateService.GetAllStates();

            if (stateList == null || stateList.Count == 0)
            {
                return NotFound("No State Exists");
            }

            return Ok(stateList);
        }

        [HttpGet("{id}")]
        public IActionResult GetStateById(int id)
        {
            var state = _stateService.GetStateById(id);

            if (state == null)
            {
                return NotFound("State Not Found");
            }

            return Ok(state);
        }

        [HttpPost]

        public IActionResult AddState(StateDto stateDto)
        {
            if (stateDto == null)
            {
                return NotFound("State is Empty");
            }
            var newState = _stateService.AddNewState(stateDto);

            return Ok(newState);
        }

        [HttpPut]

        public IActionResult UpdateState(StateDto stateDto, int id)
        {
            if(stateDto == null)
            {
                return NotFound();
            }
            var updatedState = _stateService.UpdateState(stateDto, id);

            if(updatedState != null)
            {
                var updateStateDto = new StateDto()
                {
                    StateName = updatedState.StateName
                };
                return Ok(updateStateDto);
            }
            return NotFound("State Not Found");
        }

        [HttpDelete]

        public IActionResult DeleteState(int id)
        {
            var state = _stateService.DeleteState(id);
            if (state == null)
            {
                return NotFound("State Not Found");
            }

            return Ok(state);
        }
    }
}
