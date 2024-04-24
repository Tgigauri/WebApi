using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos.Character;
using WebApi.Dtos.Weapon;
using WebApi.Models;
using WebApi.Services.WeaponService;

namespace WebApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController : ControllerBase
    {

        public IWeaponService _weaponService { get; }



        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }


        [HttpPost]
        public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {


            return Ok(await _weaponService.AddWeapon(newWeapon));

        }

    }
}
