using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirsoftBase.Model;
using Microsoft.AspNetCore.Mvc;

namespace AirsoftBase.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly Context ctxt;
        public ClientsController(Context ctxt)
        {
            this.ctxt = ctxt;
        }

        [HttpGet]
        [Route("Index")]
        public ActionResult<Clients[]> Index()
        {
            if (this.ctxt.Clients == null)
            {
                return NotFound("no data found");
            }

            return this.ctxt.Clients.ToArray();
        }
    }
}