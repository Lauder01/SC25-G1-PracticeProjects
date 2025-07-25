namespace CozyHouseExampleLibrary
{
    public class Contract
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public int ApartmentId { get; set; }

        // Default constructor
        public Contract() { }

        // Full parameter constructor
        public Contract(int id, string description, int clientId, int apartmentId)
        {
            Id = id;
            Description = description;
            ClientId = clientId;
            ApartmentId = apartmentId;
        }

        public void AssociateWithClientAndApartment(Client client, Apartment apartment)
        {
            if (!client.Contracts.Contains(this))
                client.Contracts.Add(this);
            if (!client.Apartments.Contains(apartment))
                client.Apartments.Add(apartment);
        }

        public override string ToString()
        {
            return $"Contract: {Id}, Description: {Description}, ClientId: {ClientId}, ApartmentId: {ApartmentId}";
        }
    }
}
