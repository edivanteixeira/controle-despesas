using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeDespesas.DTOs;
using ControleDeDespesas.Models;
using ControleDespesas.DTOs;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ControleDespesas.Helpers;
using AutoMapper;

namespace ControleDeDespesas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IValidator<PersonCreate> _validator;
        private readonly IMapper _mapper;
        public PersonsController(IValidator<PersonCreate> validator, IMapper mapper)
        {
            _validator = validator;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("")]
        public Task<List<Person>> GetAll()
        {

            var allPersons = new List<Person>();

            return Task.FromResult(allPersons);
        }

        [HttpDelete]
        [Route("/{id}")]
        public Task Delete(Guid id)
        {
            //remove 
            return Task.CompletedTask;
        }


        [HttpPost]
        public IActionResult Create(PersonCreate personCreate)
        {

            var result = _validator.Validate(personCreate);

            var errorResponse = result.ToErrorResponse();

            if (errorResponse != null)
            {
                return BadRequest(errorResponse);
            }


            var newPerson = _mapper.Map<Person>(personCreate);

            return Ok(newPerson);

        }

        [HttpGet]
        [Route("/{id}")]
        public Task<Person> Get(Guid id)
        {

            var allPersons = new List<Person>();

            return Task.FromResult(new Person());
        }



    }
}