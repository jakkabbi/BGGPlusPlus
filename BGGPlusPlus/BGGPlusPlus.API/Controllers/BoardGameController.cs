using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BGGPlusPlus.Domain;
using BGGPlusPlus.Model.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BGGPlusPlus.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BoardGameController : ControllerBase
    {
        BGGPlusPlusContext _dbContext;
        public BoardGameController(BGGPlusPlusContext bggPlusPlusContext)
        {
            _dbContext = bggPlusPlusContext;
        }

        [HttpGet]
        [Route("getartists")]
        public IActionResult GetArtists()
        {
            var artists = _dbContext.Set<Artist>().Select(p => p);
            return Ok(artists.ToList());
        }

        [HttpGet]
        [Route("getcategories")]
        public IActionResult GetCategories()
        {
            //BGGApiService bggApiService = new BGGApiService(_dbContext);
            //bggApiService.FillDatabase(bggApiService.GetCsvValues());
            var categories = _dbContext.Set<Category>().Select(p => p);
            return Ok(categories.ToList());
        }

        [HttpGet]
        [Route("getdesigner")]
        public IActionResult GetDesigners()
        {
            var designers = _dbContext.Set<Designer>().Select(p => p);
            return Ok(designers.ToList());
        }

        [HttpGet]
        [Route("getpublishers")]
        public IActionResult GetPublishers()
        {
            var publishers = _dbContext.Set<Publisher>().Select(p => p);
            return Ok(publishers.ToList());
        }

        [HttpPost]
        [Route("searchboardgames")]
        public IActionResult SearchBoardGames()
        {
            var test = new BGGApiService(_dbContext);

            throw new NotImplementedException();

        }
    }
}