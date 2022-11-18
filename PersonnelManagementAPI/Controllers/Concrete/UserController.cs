using Microsoft.AspNetCore.Mvc;
using PersonnelManagementAPI.Business.Abstract;
using PersonnelManagementAPI.DataAccess.Abstract;

namespace PersonnelManagementAPI.Controllers.Concrete;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
     // private readonly IUserService _userService;
     private readonly IUserService _userService;
     
     public UserController(IUserService userService)
     {
         _userService = userService;
     }
     
     [HttpGet("{id}")]
     public IActionResult GetUser(Guid id)
     {
        var user = _userService.GetUser(id);
        return Ok(user);
    }
}