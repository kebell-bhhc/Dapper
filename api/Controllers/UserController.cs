using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DataManagement.Business;
using DataManagement.Entities;
using DataManagement.Business;
// For more information on enabling Web API for empty projects, visit https//go.microsoft.com/fwlink/?LinkID=397860  
namespace DataManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }
        // GET <td style="border<td style="border: 1px dashed #ababab;"> 1px dashed #ababab;"> api/user  
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userManager.GetAllUser();
        }
        // GET api/user/5  
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userManager.GetUserById(id);
        }
        // POST api/user  
        [HttpPost]
        //public void Post(User user)               //works with postman form-data
        //public void Post([FromForm] User user)    //works with postman form-data
        /*public void Post([FromBody] User user)    // works with postman raw, content-type="application/json" body=
{
	"UserId": 0,
    "UserName": "Jerry Clark",
    "UserMobile": "+1916112345678",
    "UserEmail": "jclark@bhhctest.com",
    "FaceBookUrl": "www.facebook.com/jerry.clark123",
    "LinkedInUrl": null,
    "TwitterUrl": null,
    "PersonalWebUrl": null,
    "IsDeleted": false
}

Note: JSon needs to be formatted correctly or object doesn't get populated.  Add UserId:null and object was always null because 
UserId was int property.  No error was thrown just a null object.  
Misspelling a property doesn't stop the object from populating, but the property doesn't get set with a value.
*/
        // POST api/user
        [HttpPost("{user}")]
        public void Post([FromBody] User user)
        {
            _userManager.AddUser(user);

        }

        // PUT api/user/5  
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            _userManager.UpdateUser(user);
        }

        // DELETE api/user/5  
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userManager.DeleteUser(id);
        }
    }
}