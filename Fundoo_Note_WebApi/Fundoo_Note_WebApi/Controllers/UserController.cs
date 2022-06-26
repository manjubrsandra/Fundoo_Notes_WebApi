using BusinessLayer.Interface;
using DatabaseLayer.User;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Services;
using System;
using System.Linq;

namespace Fundoo_Note_WebApi.Controllers
{
    /*[ApiController]
    [Route("[Controller]")]*/
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {
        IUserBL userBL;
        FundooContext fundooContext;
        public UserController(IUserBL userBL, FundooContext fundooContext)
        {
            this.userBL=userBL;
            this.fundooContext=fundooContext;
        }

        [HttpPost("Register")]
        public IActionResult AddUser(UserPostModel userPostModel)
        {
            try
            {
                this.userBL.AddUser(userPostModel);
                var user = fundooContext.Users.FirstOrDefault(u => u.Email == userPostModel.Email);
                if(user != null)
                {
                    return this.BadRequest(new { succes = false,message = "Email Already Exist"});
                }

                return this.Ok(new {success = true,message = "Registration successfull"});
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
