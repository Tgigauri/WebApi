using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos.Fight;
using WebApi.Models;
using WebApi.Services.FightService;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {

        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        public IFightService _fightService { get; }

        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }


        [HttpPost("Skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> Fight(FightRequestDto request)
        {
            return Ok(await _fightService.Fight(request));
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<HighScoreDto>>>> GetHighScore()
        {
            return Ok(await _fightService.GetHighScore());
        }
    }
}
