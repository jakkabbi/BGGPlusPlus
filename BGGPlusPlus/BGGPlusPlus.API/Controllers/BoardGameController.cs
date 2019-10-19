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
    [Route("api/[controller]")]
    [ApiController]
    public class BoardGameController : ControllerBase
    {
        BGGPlusPlusContext _dbContext;
        public BoardGameController(BGGPlusPlusContext bggPlusPlusContext)
        {
            _dbContext = bggPlusPlusContext;
        }

        [HttpGet]
        public IActionResult GetArtists()
        {
            var artists = _dbContext.Set<Artist>().Select(p => p);
            return Ok(artists.ToList());
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _dbContext.Set<Category>().Select(p => p);
            return Ok(categories.ToList()); 
        }

        [HttpGet]
        public IActionResult GetDesigners()
        {
            var designers = _dbContext.Set<Designer>().Select(p => p);
            return Ok(designers.ToList());
        }

        [HttpGet]
        public IActionResult GetPublishers()
        {
            var publishers = _dbContext.Set<Publisher>().Select(p => p);
            return Ok(publishers.ToList());
        }

        [HttpPost]
        public IActionResult SearchBoardGames()
        {
            var test = new BGGApiService();

            throw new NotImplementedException();

        }
    }
}