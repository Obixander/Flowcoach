using FlowCoach.DataAccess.Interfaces;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowCoach.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoachingController(ICoachingRepository Context) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> AddBy(Coaching coaching)
        {
            try
            {
                await Context.Add(coaching);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(Coaching entity)
        {
            try
            {
                await Context.Update(entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete]
        public async Task<ActionResult> Delete(Coaching entity)
        {
            try
            {
                await Context.Delete(entity);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete]
        [Route(nameof(DeleteAt))]
        public async Task<ActionResult> DeleteAt(int id)
        {
            try
            {
                await Context.DeleteAt(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        [Route(nameof(GetAll))]
        public async Task<ActionResult<IEnumerable<Coaching>>> GetAll()
        {
            try
            {
                return Ok(await Context.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        [Route(nameof(GetBy))]
        public async Task<ActionResult<Coaching>> GetBy(int id)
        {
            try
            {
                return await Context.GetByAsync(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
