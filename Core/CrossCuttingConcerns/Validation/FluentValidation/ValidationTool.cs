﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidationTool
    {
        public static void FluentValidate(IValidator validator,object entity)
        {
            //var result = validator.Validate(entity);
            var result = validator.Validate(new ValidationContext<object>(entity));

            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
