using macros.Models;
using Microsoft.AspNetCore.Mvc;

namespace macros.Controllers
{
    [ApiController]
    [Route("/targets")]
    public class TargetsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<TargetDto>> GetTargets()
        {
            return Ok((TargetsDataStore.Current.Targets));


        }

        [HttpGet("{day}")]
        public ActionResult<TargetDto> GetTarget(DayOfWeek day)
        {
            var target = TargetsDataStore.Current.Targets.FirstOrDefault(c => c.Day == day);

            if (target == null)
            {
                return NotFound();
            }

            return Ok(target);
        }
    }
}
