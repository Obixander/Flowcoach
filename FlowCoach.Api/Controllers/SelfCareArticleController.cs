using FlowCoach.DataAccess.Interfaces;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowCoach.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelfCareArticleController(IGenericRepository<SelfCareArticle> Context) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> AddBy(SelfCareArticle selfCareArticle)
        {
            try
            {
                await Context.Add(selfCareArticle);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(SelfCareArticle entity)
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
        public async Task<ActionResult> Delete(SelfCareArticle entity)
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
        public async Task<ActionResult<List<SelfCareArticle>>> GetBy(int id)
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
