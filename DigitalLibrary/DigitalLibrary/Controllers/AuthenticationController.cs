﻿using DigitalLibrary.Filters;
using Domain.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace DigitalLibrary.Controllers
{
    [Route("authentication")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        [ValidateModel]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto userForRegistration)
        {
            var result = await _authenticationService.RegisterUser(userForRegistration);
            if (!result.Succeeded)
            { 
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

    }
}
