﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Infrastructure.Extensions
{
    public class ValidationFilterExtensions : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                var errors=context.ModelState.Where(x=>x.Value.Errors.Any()).ToDictionary(x=>x.Key, x=>x.Value.Errors.Select(x=>x.ErrorMessage)).ToArray();
                context.Result = new BadRequestObjectResult(errors);
            }
            await next();
        }
    }
}