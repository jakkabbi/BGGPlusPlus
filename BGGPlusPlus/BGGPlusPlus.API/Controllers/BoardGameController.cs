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
            //var artists = _dbContext.Set<Artist>().Select(p => p);
            //return Ok(artists.ToList());
            return Ok(new List<string>());
        }

        [HttpGet]
        [Route("getcategories")]
        public IActionResult GetCategories()
        {
            //var categories = _dbContext.Set<Category>().Select(p => p);
            //return Ok(categories.ToList()); 
            return Ok(new List<string>());
        }

        [HttpGet]
        [Route("getdesigner")]
        public IActionResult GetDesigners()
        {
            //var designers = _dbContext.Set<Designer>().Select(p => p);
            //return Ok(designers.ToList());
            return Ok(new List<string>());
        }

        [HttpGet]
        [Route("getpublishers")]
        public IActionResult GetPublishers()
        {
            //var publishers = _dbContext.Set<Publisher>().Select(p => p);
            //return Ok(publishers.ToList());
            return Ok(new List<string>());
        }

        [HttpPost]
        [Route("searchboardgames")]
        public IActionResult SearchBoardGames()
        {
            var test = new BGGApiService();

            throw new NotImplementedException();

        }
    }
}