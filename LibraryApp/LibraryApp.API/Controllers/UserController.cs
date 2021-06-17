﻿using LibraryApp.API.Models;
using LibraryApp.API.Repositories.UserRepo;
using LibraryApp.API.Repositories.UserRepo.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPut]
        public IActionResult UpdateUser(UserDto user)
        {
            var result = _userRepository.Update(user);
            if (result.Result == true)
            {
                return Ok();
            }
            else
                return BadRequest();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Reservation>> GetReservation(long id)
        {
            var result = _userRepository.GetMyReservation(id).ToList();
            return result;
        }
    }
}
