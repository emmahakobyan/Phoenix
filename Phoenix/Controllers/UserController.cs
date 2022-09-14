using Microsoft.AspNetCore.Mvc;
using Phoenix.Core.Models.Requests;
using Phoenix.Core.Services;

namespace Phoenix.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public ActionResult Create(CreateUserRequest createUser)
        {
            userService.CreateUser(createUser);
            return Ok();
        }

        [HttpGet]
        public ActionResult GetUser(long Id)
        {
            var user = userService.GetUser(Id);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpGet]
        public ActionResult GetUsers()
        {
            return Ok(userService.GetUsers());
        }

        [HttpDelete]
        public void DeleteUser(long Id)
        {
            userService.DeleteUser(Id);
        }

        /// <summary>
        /// Returns users created by given date
        /// </summary>
        /// <param name="date">eg. 2022-09-11 (ignore the time at the moment) </param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetUsersByCreatedDate(DateTime date)
        {
            return Ok(userService.GetUsersByCreatedDate(date));
        }

    }
}
