namespace TGregDemo.Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }

        public IEnumerable<Adress> Adresses { get; set; }
    }
}
