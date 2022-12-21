using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDeDespesas.Models.Base;
using FluentValidation;

namespace ControleDespesas.Models
{
    public class BankAccount : ModelBase
    {
        public string Name { get; set; }

    }

    public class BankAccountValidator : AbstractValidator<BankAccount>{
        public BankAccountValidator(){
            RuleFor(x=>x.Name).NotEmpty();
        }   
    }
}