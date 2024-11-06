using FlowCoach.DataAccess.Interfaces;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowCoach.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserRepository userRepository) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> AddBy(User entity)
        {
            try
            {
               await userRepository.Add(entity);
               return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpPut]
        public async Task<ActionResult> Update(User entity)
        {
            try
            {
                await userRepository.Update(entity);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(User entity)
        {
            try
            {
                await userRepository.Delete(entity);
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
                await userRepository.DeleteAt(id);
                return Ok();
            }
            catch(Exception ex)
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
                return Ok(await userRepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        [Route(nameof(GetBy))]
        public async Task<ActionResult<List<User>>> GetBy(int id) //might have to change this to from query later
        {
            try
            {
               return Ok(await userRepository.GetBy(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        [Route(nameof(Login))]
        public async Task<ActionResult<bool>> Login(User user)
        {
            try 
            {
                return Ok(await userRepository.Login(user));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
