using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BGGPlusPlus.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BGGPlusPlus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoardGameController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetArtists()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetDesigners()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetPublishers()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> SearchBoardGames()
        {
            var test = new BGGApiService();

            throw new NotImplementedException();

        }
    }
}