using WebApi.Dtos.Skill;
using WebApi.Dtos.Weapon;
using WebApi.Models;

namespace WebApi.Dtos.Character
{
    public class GetCharacterDto
    {

        public int Id { get; set; }
        public string Name { get; set; } = "player1";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int MyProperty { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public GetWeaponDto? Weapon { get; set; }

        public List<GetSkillDto>?  Skills { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}
