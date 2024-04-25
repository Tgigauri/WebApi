 using WebApi.Dtos.Character;
using WebApi.Models;

namespace WebApi.Services.CharacterService
{
    public interface ICharacterService

    {

        Task<ServiceResponse<List<GetCharacterDto>>> getAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>>AddCharacter(AddCharacterDto character);

        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);

        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

        Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto characterSkill);

    }
}
