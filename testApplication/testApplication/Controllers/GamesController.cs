using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace testApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GamesController : Controller
    {
        public static List<Models.Games> GetGames()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games() { Id = 1, Name = "Game 1", Price = 10 });
            games.Add(new Games() { Id = 2, Name = "Game 1", Price = 15 });
            games.Add(new Games() { Id = 3, Name = "Game 1", Price = 20 });
            games.Add(new Games() { Id = 4, Name = "Game 1", Price = 25 });
            games.Add(new Games() { Id = 5, Name = "Game 1", Price = 30 });

            return games;
        }

        [HttpGet]

        public ActionResult<IEnumerable<Games>> GetGames_List()
        {
            return GetGames();
        }

        [HttpGet("{id}")]

        public ActionResult<Games> GetGames_ById(int id)
        {
            var games = GetGames().Find(x => x.Id == id);
            if (games != null)
                return games;
            return NotFound();
        }

    }
}
