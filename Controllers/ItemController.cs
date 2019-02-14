using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sp_bmexportal.Services;
using sp_bmexportal.Models;

namespace sp_bmexportal.Controllers
{
	[Route("v1/Item")]
	[ApiController]
	public class ItemController : ControllerBase
	{
		private readonly IItemService itemService;

		public ItemController(IItemService _itemService)
		{
			itemService = _itemService;
		}

		/// <summary>
		/// Get contract information from bitmex
		/// </summary>
		/// <param name="positionRequest"></param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult GetItems([FromBody]PositionRequest positionRequest)
		{
			var result = itemService.GetPosition(positionRequest);
			return Ok(result);
		}

		/// <summary>
		/// Execute order on given contract 
		/// </summary>
		/// <param name="positionRequest"></param>
		/// <returns></returns>
		[HttpPost]
		public IActionResult ExecuteOrder([FromBody]PositionRequest positionRequest)
		{
			var result = itemService.SendOrderRequest(positionRequest);
			return Ok(result);
		}
    }
}