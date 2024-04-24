using AutoMapper;
using WebApi.Dtos.Character;
using WebApi.Dtos.Fight;
using WebApi.Dtos.Skill;
using WebApi.Dtos.Weapon;
using WebApi.Models;

namespace WebApi.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character,GetCharacterDto> ();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
            CreateMap<Character, HighScoreDto>();


        }

    }
}
