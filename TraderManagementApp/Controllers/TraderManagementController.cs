using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TraderManagementApp.BusinessLayer.Interfaces;
using TraderManagementApp.BusinessLayer.ViewModels;
using TraderManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementApp.Entities;

namespace TraderManagementApp.Controllers
{
    [ApiController]
    public class TraderManagementController : ControllerBase
    {
        private readonly ITraderManagementService _traderService;
        public TraderManagementController(ITraderManagementService traderservice)
        {
            _traderService = traderservice;
        }

        [HttpPost]
        [Route("create-trader")]
        [AllowAnonymous]
        public async Task<IActionResult> CreateTrader([FromBody] Trader model)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }


        [HttpPut]
        [Route("update-trader")]
        public async Task<IActionResult> UpdateTrader([FromBody] TraderViewModel model)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }



        [HttpDelete]
        [Route("delete-trader")]
        public async Task<IActionResult> DeleteTrader(long id)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }



        [HttpGet]
        [Route("get-trader-by-id")]
        public async Task<IActionResult> GetTraderById(long id)
        {
            //write your code here
            throw new NotFiniteNumberException();
        }

        [HttpGet]
        [Route("get-all-traders")]
        public async Task<IEnumerable<Trader>> GetAllTraders()
        {
            //write your code here
            throw new NotFiniteNumberException();
        }
    }
}
