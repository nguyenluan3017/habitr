using Habitr.src.Data;
using Habitr.src.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Habitr.Controllers
{
    [ApiController]
    [Route("/activities")]
    public class ActivityController : ControllerBase
    {        
        private readonly ApplicationDbContext _context;

        public ActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetActivities(DateTime start, DateTime end)
        {
            if (start > end)
            {
                return BadRequest("Start date must be before end date.");
            }

            var activities = _context.Activities
                .Where(a => start <= a.Start && a.End <= end)
                .ToList();
                
            return Ok(activities);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity([FromBody] Activity activity)
        {
            try
            {
				if (activity == null)
				{
					return BadRequest("Activity should be available.");
				}

				if (activity.Start > activity.End)
				{
					return BadRequest("Start date must be before end date.");
				}

				_context.Activities.Add(activity);
				await _context.SaveChangesAsync();

				return Ok();
			}
			catch (JsonException e)
			{
				return BadRequest($"Invalid JSON: {e.Message}");
			}
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
