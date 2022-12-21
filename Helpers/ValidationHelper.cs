using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleDespesas.DTOs;
using FluentValidation.Results;

namespace ControleDespesas.Helpers
{
    public static class ValidationHelper
    {

        public static ErrorResponse ToErrorResponse(this ValidationResult validationResult)
        {

            if (!validationResult.IsValid)
            {
                var response = new ErrorResponse
                {
                    Messages = validationResult.Errors.Select(x => x.ErrorMessage).ToList()
                };
                return response;
            }
            return null;
        }
    }
}