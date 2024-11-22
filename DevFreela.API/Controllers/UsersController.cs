﻿using DevFreela.API.Models;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);

            return Ok(user);
        }

        [HttpPost]
        public IActionResult Post([FromBody] NewUserInputModel createUserModel)
        {
            _userService.Create(createUserModel);

            return CreatedAtAction(nameof(GetById), new { id = 1 }, createUserModel);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            return NoContent();
        }
    }
}
