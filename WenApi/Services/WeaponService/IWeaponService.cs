using WebApi.Dtos.Character;
using WebApi.Dtos.Weapon;
using WebApi.Models;

namespace WebApi.Services.WeaponService
{
    public interface IWeaponService
    {

        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}
