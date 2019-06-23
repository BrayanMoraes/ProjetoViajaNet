using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.FacadeInterfaces;

namespace ProjetoViajaNet.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrowserInformationController : ControllerBase
    {
        private readonly IBrowserInformationFacade _facade;

        public BrowserInformationController(IBrowserInformationFacade facade)
        {
            this._facade = facade;
        }

        [HttpPost]
        public IActionResult SaveInformations(BrowserInformation information)
        {
            _facade.SaveInformations(information);

            return Ok();
        }
    }
}