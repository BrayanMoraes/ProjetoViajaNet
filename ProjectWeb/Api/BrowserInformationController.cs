using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.FacadeInterfaces;
using Wangkanai.Detection;

namespace ProjectWeb.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrowserInformationController : ControllerBase
    {
        private readonly IBrowserInformationFacade _facade;
        private readonly IDetection _detection;

        public BrowserInformationController(IBrowserInformationFacade facade, IDetection detection)
        {
            this._facade = facade;
            this._detection = detection;
        }

        [HttpGet]
        [Route("SaveInformations/{pageName}")]
        public IActionResult SaveInformations(string pageName)
        {
            BrowserInformation information = new BrowserInformation()
            {
                IPAdress = Request.HttpContext.Connection.RemoteIpAddress.ToString(),
                BrowserName = _detection.Browser.Type.ToString(),
                PageName = pageName
            };

            _facade.SaveInformations(information);

            return Ok();
        }
    }
}