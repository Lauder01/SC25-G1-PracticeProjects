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
        
        // Default constructor
        public Client() 
        {
            Contracts = new List<Contract>();
            Apartments = new List<Apartment>();
        }

        // Full parameter constructor
        public Client(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Contracts = new List<Contract>();
            Apartments = new List<Apartment>();
        }

        public override string ToString()
        {
            return $"Client: {Id}, Name: {Name}, Email: {Email}";
        }
    }
}
