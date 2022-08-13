using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();
        // Now we will create a list of characters
        private static List<Character> characters = new List<Character>
        {
            new Character (),
            new Character { Id = 1, Name = "Hulk" }
        };
        // for one character return
        [HttpGet("{id}")]
        public ActionResult<Character> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
        // for multiple charaacters
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }
        [HttpPost]
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(characters);
        }
        
    }
}