using AngularServer.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace AngularServer.Controllers
{
    [Authorize]
    public class UsersController : ApiController
    {
        UserManager<ApplicationUser> userManager;
        public UsersController()
        {
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }
        // GET: api/Users
        public IQueryable<object> Get()
        {
            var user = userManager.Users.Select(u => new { Id = u.Id, Email = u.Email, UserName = u.UserName });
            return user;
        }

        // GET: api/Users/5
        [ResponseType(typeof(ApplicationUser))]
        public IHttpActionResult Get(string id)
        {
            ApplicationUser applicationUser = userManager.Users.FirstOrDefault(s => s.Id == id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            return Ok(applicationUser);
        }

        // POST: api/Users
        [ResponseType(typeof(ApplicationUser))]
        public async Task<IHttpActionResult> Post(RegisterBindingModel applicationUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser { UserName = applicationUser.Email, Email = applicationUser.Email };
            await userManager.CreateAsync(user, applicationUser.Password);
            await userManager.AddToRoleAsync(user.Id, "User");

            return Ok();
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(string id, ApplicationUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.Id)
            {
                return BadRequest();
            }

            ApplicationUser EditedUser = userManager.FindById(user.Id);
            EditedUser.UserName = user.UserName;
            EditedUser.Email = user.Email;
            EditedUser.PhoneNumber = user.PhoneNumber;
            userManager.Update(EditedUser);
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(ApplicationUser))]
        public IHttpActionResult Delete(string id)
        {
            ApplicationUser applicationUser = userManager.Users.FirstOrDefault(s => s.Id == id);

            if (applicationUser == null)
            {
                return NotFound();
            }

            userManager.Delete(applicationUser);

            return Ok(applicationUser);
        }
    }
}
