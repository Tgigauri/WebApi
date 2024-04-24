using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebApi.Data;
using WebApi.Dtos.Character;
using WebApi.Dtos.Weapon;
using WebApi.Models;

namespace WebApi.Services.WeaponService
{
    public class WeaponService : IWeaponService
    {
        public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _mapper = mapper;
        }

        private DataContext _context { get; }
        private IHttpContextAccessor _httpContextAccessor { get; }
        private IMapper _mapper { get; }

        public async Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon)
        {
            var response = new ServiceResponse<GetCharacterDto>();
            try
            {
                var character = await _context.Characters
                    .FirstOrDefaultAsync(c=> c.Id == newWeapon.CharacterId && 
                    c.User!.Id == int.Parse(_httpContextAccessor.HttpContext!
                    .User.FindFirstValue(ClaimTypes.NameIdentifier)!));
                if(character == null)
                {
                    response.Success = false;
                    response.Message = "Character Not Found";
                    return response;
                }
                var weapon = new Weapon
                {
                    Name = newWeapon.Name,
                    Damage = newWeapon.Damage,
                    Character = character,
                };
                _context.Weapons.Add(weapon);
                await _context.SaveChangesAsync();

                response.Data = _mapper.Map<GetCharacterDto>(character);
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
