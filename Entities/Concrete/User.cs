using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public decimal Username { get; set; }
        public string Password { get; set; }
    }
}
