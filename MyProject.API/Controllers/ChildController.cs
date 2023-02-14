using Microsoft.AspNetCore.Mvc;
using MyProject.Common.DTOs;
using MyProject.Services.Interfaces;
using MyProject.WebAPI.Controllers.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController
    {
        private readonly IChildService _childService;

        public ChildController(IChildService childService)
        {
            _childService = childService;
        }
        [HttpGet]
        public async Task<IEnumerable<ChildDTO>> Get()
        {
            return await _childService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ChildDTO> Get(int id)
        {
            return await _childService.GetByIdAsync(id);
        }

        [HttpPost]//add
        public async Task<ChildDTO> Post([FromBody] ChildModel model)
        {
            ChildDTO childDTO = new ChildDTO()
            {
                IdNumber = model.IdNumber,
                Id = model.Id,
                Name = model.Name,
                DateBirth = model.DateBirth,
                Parent1Id = model.Parent1Id,
                Parent2Id = model.Parent2Id,
          
            };
            return await _childService.AddAsync(childDTO);
        }
        [HttpPut("{id}")]//update
        public async Task<ChildDTO> Put(int id, [FromBody] ChildModel model)
        {
            ChildDTO childDTO = new ChildDTO()
            {
                IdNumber = id,
                Id = model.Id,
                Name = model.Name,
                DateBirth = model.DateBirth,
                Parent1Id = model.Parent1Id,
                Parent2Id = model.Parent2Id,
             //   Parent1=model.Parent1,
              //  Parent2=model.Parent2
            };
            return await _childService.UpdateAsync(childDTO);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childService.DeleteAsync(id);
        }

    }
}

