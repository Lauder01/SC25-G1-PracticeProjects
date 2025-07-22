using System.Collections.Generic;

namespace CozyHouseExampleLibrary
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Contract> Contracts { get; set; }
        public List<Apartment> Apartments { get; set; }

        public Client(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Contracts = new List<Contract>();
            Apartments = new List<Apartment>();
        }
    }
}
