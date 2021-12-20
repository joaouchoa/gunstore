using gunstore.Enum;

namespace gunstore.Classes
{
    public class Melee : Weapon
    {
        public string? Nome { get; set; }
        public string? Fabricante { get; set; }
        public EType Tipo {get; set;}
    }
}