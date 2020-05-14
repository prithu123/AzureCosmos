using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AzureCosmos.Models;
using AzureCosmos.services;

namespace AzureCosmos.Controllers
{
    public class LegendController : Controller
    {
        private readonly ICosmosDbService _cosmosDbService;
        public LegendController(ICosmosDbService cosmosDbService)
        {
            _cosmosDbService = cosmosDbService;
        }
        [ActionName("Index")]
        public async Task<IActionResult> Index()
        {
            return View(await _cosmosDbService.GetItemsAsync("SELECT * FROM c"));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
