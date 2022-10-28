using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeDespesas.DTOs;
using ControleDeDespesas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeDespesas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {


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
        public Task<Person> Create(PersonCreate personCreate)
        {
            // Validar com fluentvalidator
            // https://docs.fluentvalidation.net/en/latest/ 

            var newPerson = new Person();
            
            // Automapper
            newPerson.Name = personCreate.Name;

        
            return Task.FromResult(newPerson);
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