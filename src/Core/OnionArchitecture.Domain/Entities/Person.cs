using OnionArchitecture.Domain.Comman;

namespace OnionArchitecture.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
