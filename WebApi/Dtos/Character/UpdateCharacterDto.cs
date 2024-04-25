using WebApi.Models;

namespace WebApi.Dtos.Character
{
    public class UpdateCharacterDto
    {

        public int Id { get; set; }
        public string Name { get; set; } = "player1";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int MyProperty { get; set; } = 10;
        public int Defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}
