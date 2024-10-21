using FlowCoach.DataAccess.Interfaces;
using FlowCoach.DataAccess.Repositories;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowCoach.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfCareCardController(IGenericRepository<SelfCareCard> Context) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Add(SelfCareCard selfCareCard)
        {
            try
            {
                await Context.Add(selfCareCard);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(SelfCareCard entity)
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
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
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
        public async Task<ActionResult<List<SelfCareCard>>> GetBy(int id)
        {
            try
            {
                return Ok(await Context.GetBy(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
