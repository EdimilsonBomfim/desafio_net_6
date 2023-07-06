namespace TGregDemo.Application.DTOs
{
    public class CustomerDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }

        public IList<AdressDTO> Adresses { get; set; }
    }
}
