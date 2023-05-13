using Azure;
using Data.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sincro.Context;

namespace Sincro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IDataBaseService _IDataBaseUpdater;
        public HomeController(IDataBaseService IDataBaseUpdater)
        {
            _IDataBaseUpdater = IDataBaseUpdater;
        }

        // POST: HomeController/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateDataBase(string confirmation)
        {
            var response = _IDataBaseUpdater.Update();
            return Ok(new ObjectResult(response));
        }
    }
}
