using CareProWeb.Core.Interfaces;
using CareProWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CareProWeb.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public ILoginRepository loginService { get; set; }
        public LoginController(ILoginRepository loginRepository)
        {
            loginService = loginRepository;
        }
        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        [HttpPost]
        public async Task<JsonResult> Login([FromBody] LoginModel loginModel)
        {
            var firebaseAuth = await loginService.Login(loginModel);
            if (firebaseAuth != null)
            {
                HttpContext.Session.SetString("_UserToken", firebaseAuth.FirebaseToken);
            }
            return new JsonResult(firebaseAuth);
        }
        [HttpPost]
        public async Task<JsonResult> Registration([FromBody] LoginModel loginModel)
        {
            var firebaseAuth =await loginService.Registration(loginModel);
            if (firebaseAuth != null)
            {
                HttpContext.Session.SetString("_UserToken", firebaseAuth.FirebaseToken);
            }
            return new JsonResult(firebaseAuth);
        }
    }
}
