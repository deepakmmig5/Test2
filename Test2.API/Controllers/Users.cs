using Microsoft.AspNetCore.Mvc;
using Test2.Models;
using Test2.Repository;
namespace Test2.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
    {
        
        private readonly IUserRepository _user;
   public UserController(IUserRepository user)
    {
       _user=user;
    }
     [HttpPost(Name = "CreateUser")]
    public IActionResult Create(Users obj)
    {

        _user.Create(obj);
        return Ok(obj);
    }



    }
