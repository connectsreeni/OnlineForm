using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineForm.Service.Interfaces;
using OnlineForm.Service.Models;
using System;
using System.Threading.Tasks;

namespace OnlineForm.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger, IUserService userService, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _userService = userService;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserDto user)
        {
            var destinationFolder = _hostingEnvironment.ContentRootPath;

            if (!ModelState.IsValid)
            {
                return BadRequest(user);
            }

            await _userService.InsertAsync(user, destinationFolder);

            return Ok();
        }
    }
}
