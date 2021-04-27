using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            return Ok();

        }

        [HttpGet("getbyemail")]
        public IActionResult GetByMail(string email)
        {
            return Ok();


        }

        [HttpGet("getclaims")]
        public IActionResult GetClaims(User user)
        {
            return Ok(); 
        }


    }
}
