using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ControleDeDespesas.Models;
using FluentValidation;

namespace ControleDeDespesas.DTOs
{
    public class PersonCreate
    {
        public string Name { get; set; }
    }

    public class PersonCreateValidator : AbstractValidator<PersonCreate>
    {
        public PersonCreateValidator(){
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x=>x.Name).Length(3, 255);
        }
    }

    public class PersonCreateMapping : Profile{

        public PersonCreateMapping(){
            CreateMap<PersonCreate, Person>();
            CreateMap<Person, PersonCreate>();
        }
    }

}