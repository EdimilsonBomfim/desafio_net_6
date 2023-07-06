namespace TGregDemo.Application.DTOs.Customers
{
    public class UpdateCustomerDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
    }
}
