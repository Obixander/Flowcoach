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
        public async void AddBy(User entity)
        {
            try
            {
               await userRepository.Add(entity);
            }
            catch
            {
                throw;
            }
        }
        [HttpPut]
        public async void Update(User entity)
        {
            try
            {
                await userRepository.Update(entity);
            }
            catch
            {
                throw;
            }
        }
        [HttpDelete]
        public async void Delete(User entity)
        {
            try
            {
                await userRepository.Delete(entity);
            }
            catch
            {
                throw;
            }
        }
        [HttpDelete]
        [Route(nameof(DeleteAt))]
        public async void DeleteAt(int id)
        {
            try
            {
                await userRepository.DeleteAt(id);
            }
            catch
            {
                throw;
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
            catch
            {
                throw;
            }
        }
        [HttpGet]
        [Route(nameof(GetBy))]
        public async Task<ActionResult<List<User>>> GetBy(int id)
        {
            try
            {
               return Ok(await userRepository.GetBy(id));
            }
            catch
            {
                throw;
            }
        }
        public async Task<ActionResult<bool>> Login(User user)
        {
            try 
            {
                return Ok(userRepository.Login(user));
            }
            catch 
            {
                throw;
            }
        }
    }
}
