using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.FacadeInterfaces;

namespace ProjectWeb.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemTypeController : ControllerBase
    {
        private readonly IItemTypeFacade _facade;
        public ItemTypeController(IItemTypeFacade facade)
        {
            this._facade = facade;
        }

        [HttpGet]
        public IActionResult GetAllItemTypes()
        {
            var result = _facade.GetAllItemTypes();

            return new ObjectResult(result);
        }
    }
}