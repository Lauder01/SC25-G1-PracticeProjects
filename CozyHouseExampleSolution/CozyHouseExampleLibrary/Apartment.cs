namespace CozyHouseExampleLibrary
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int ClientId { get; set; }

        // Default constructor
        public Apartment() { }

        // Full parameter constructor
        public Apartment(int id, string address, int clientId)
        {
            Id = id;
            Address = address;
            ClientId = clientId;
        }

        public override string ToString()
        {
            return $"Apartment: {Id}, Address: {Address}, ClientId: {ClientId}";
        }
    }
}
