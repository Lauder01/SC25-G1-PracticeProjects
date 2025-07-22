using CozyHouseExampleLibrary;
using System.Collections.Generic;

// Create sample clients
var client1 = new Client(1, "Alice Smith", "alice@example.com");
var client2 = new Client(2, "Bob Johnson", "bob@example.com");
var client3 = new Client(3, "Carol White", "carol@example.com");
var client4 = new Client(4, "David Brown", "david@example.com");

// Create sample apartments
var apartment1 = new Apartment(1, "123 Main St", client1.Id);
var apartment2 = new Apartment(2, "456 Oak Ave", client2.Id);
var apartment3 = new Apartment(3, "789 Pine Rd", client3.Id);
var apartment4 = new Apartment(4, "321 Maple Ln", client4.Id);

// Create sample contracts
var contract1 = new Contract(1, "Lease for Alice", client1.Id, apartment1.Id);
var contract2 = new Contract(2, "Lease for Bob", client2.Id, apartment2.Id);
var contract3 = new Contract(3, "Lease for Carol", client3.Id, apartment3.Id);
var contract4 = new Contract(4, "Lease for David", client4.Id, apartment4.Id);

// Associate contracts with clients and apartments
contract1.AssociateWithClientAndApartment(client1, apartment1);
contract2.AssociateWithClientAndApartment(client2, apartment2);
contract3.AssociateWithClientAndApartment(client3, apartment3);
contract4.AssociateWithClientAndApartment(client4, apartment4);

// Create a list of contracts
var contracts = new List<Contract> { contract1, contract2, contract3, contract4 };

// Print contract details
foreach (var contract in contracts)
{
    Console.WriteLine($"Contract Id: {contract.Id}, Description: {contract.Description}, Client Id: {contract.ClientId}, Apartment Id: {contract.ApartmentId}");
}
