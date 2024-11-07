using FlowCoach.DataAccess.Interfaces;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowCoach.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodyFlowArticleController(IGenericRepository<BodyFlowArticle> Context) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> AddBy(BodyFlowArticle bodyFlowArticle)
        {
            try
            {
                await Context.Add(bodyFlowArticle);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(BodyFlowArticle entity)
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
        public async Task<ActionResult> Delete(BodyFlowArticle entity)
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
        public async Task<ActionResult<IEnumerable<BodyFlowArticle>>> GetAll()
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
        public async Task<ActionResult<List<BodyFlowArticle>>> GetBy(int id)
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
