using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Dto;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register")]
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            if (await _authRepository.UserExists(userForRegisterDto.UserName))
            {
                return BadRequest("User Already Exists");
            }

            var userToCreate = new User { Name = userForRegisterDto.UserName };
            var createdUser = await _authRepository.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);


        }
    }
}