﻿using FlowCoach.DataAccess.Interfaces;
using FlowCoach.DataAccess.Repositories;
using FlowCoach.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlowCoach.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController(IQuestionRepository questionRepository) : ControllerBase
    {
        [HttpPost]
        public async Task AddBy(Question entity)
        {
            try
            {
                await questionRepository.Add(entity);
            }
            catch
            {
                throw;
            }
        }
        [HttpPut]
        public async Task Update(Question entity)
        {
            try
            {
                await questionRepository.Update(entity);
            }
            catch
            {
                throw;
            }
        }
        [HttpDelete]
        public async Task Delete(Question entity)
        {
            try
            {
                await questionRepository.Delete(entity);
            }
            catch
            {
                throw;
            }
        }
        [HttpDelete]
        [Route(nameof(DeleteAt))]
        public async Task DeleteAt(int id)
        {
            try
            {
                await questionRepository.DeleteAt(id);
            }
            catch
            {
                throw;
            }
        }
        [HttpGet]
        [Route(nameof(GetAll))]
        public async Task<ActionResult<IEnumerable<Question>>> GetAll()
        {
            try
            {
                return Ok(await questionRepository.GetAll());
            }
            catch
            {
                throw;
            }
        }
        [HttpGet]
        [Route(nameof(GetBy))]
        public async Task<ActionResult<List<Question>>> GetBy(int id)
        {
            try
            {
                return Ok(await questionRepository.GetBy(id));
            }
            catch
            {
                throw;
            }
        }
    }
}
