using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ShootingServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpGet("Login/{id}")]
        public string LogIn(int id)
        {
            return "true log in success";
        }
        [Route("GetAll")]
        [HttpGet]
        public string GetAll()
        {
            return "Get all user";
        }
        [Route("Register")]
        [HttpPost]
        public string Register()
        {
            return "Register success";
        }
        public string LogOut()
        {
            return "LogOut success";
        }
    }
}