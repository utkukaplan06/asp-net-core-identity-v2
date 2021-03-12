using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityNetCore.Models;
using Microsoft.AspNetCore.Authorization;

namespace IdentityNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiSecurityController : ControllerBase
    {
        [AllowAnonymous]
        public async Task<IActionResult> TokenAuth(SigninViewModel model)
        {

        }
    }
}
