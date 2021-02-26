using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorThemes.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class Style : ControllerBase
    {
        public async Task<ActionResult> ChangeStyle([FromQuery] string style)
        {
            Response.Cookies.Append("style", style);
            return Redirect("/");
        }
    }
}
