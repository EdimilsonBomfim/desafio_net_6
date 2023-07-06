namespace TGregDemo.Domain.Entities
{
    public class Adress : Entity
    {
        public Guid CustomerId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
