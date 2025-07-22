namespace CozyHouseExampleLibrary
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }

        public Apartment(int id, string address, int clientId)
        {
            Id = id;
            Address = address;
            ClientId = clientId;
        }
    }
}
