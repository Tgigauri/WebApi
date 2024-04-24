using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApi.Dtos.Character;
using WebApi.Models;
using WebApi.Services.CharacterService;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
  

        public ICharacterService _CharacterService { get; }

        public CharacterController(ICharacterService characterService)
        {
            _CharacterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
        {
            return Ok(await _CharacterService.getAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
        {
            return Ok(await _CharacterService.GetCharacterById(id));
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<AddCharacterDto>>>> AddCharacter(AddCharacterDto character)
        {
            
            return Ok(await _CharacterService.AddCharacter(character));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<AddCharacterDto>>>> UpdateCharacter(UpdateCharacterDto character)
        {
            var response = await _CharacterService.UpdateCharacter(character);
            if(response.Data is null) {
                return NotFound(response);
            }
            return Ok(response);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> DeleteCharacter(int id)
        {
            var response = await _CharacterService.DeleteCharacter(id);
            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }


        [HttpPost("Skill")]
        public async Task<ActionResult<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto characterSkill)
        {
            return Ok(await _CharacterService.AddCharacterSkill(characterSkill));
        }

    }
}
