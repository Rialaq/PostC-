using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Dory_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pruebaController : Controller
    {
        [HttpPost]
        public JsonResult Test(string username, string password)
        {
            var value = false;
            if(username == "dory")
            {
                value = true;
            }
            else
            {
                value = false;
            }
            return Json(value);
        }

        [HttpGet]
        public JsonResult OpenAPI()
        {
            return Json("RestFul API funcionando BASEUrl: " + base.Url + " Online, abra npm run serve para el View de Vue");
        }
    }
}