using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.FacadeInterfaces;

namespace ProjectWeb.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemFacade _facade;

        public ItemController(IItemFacade facade)
        {
            this._facade = facade;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            var result = _facade.GetAllItems();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            _facade.CreateItem(item);

            return Ok();
        }

        [HttpPost]
        public IActionResult ConfirmItem(int id)
        {
            _facade.ConfirmItem(id);

            return Ok();
        }
    }
}