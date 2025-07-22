using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CozyHouseExampleLibrary;
using System.Collections.Generic;

namespace CozyHouseExampleAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CozyHouseExampleAPIController : ControllerBase
    {
        //Get CozyHouseExample
        [HttpGet("CozyHouseExample")]
        public IActionResult GetHelloWorld()
        {
            // Forma 1: Constructor por defecto y asignación de propiedades
            var client1 = new Client();
            client1.Id = 1;
            client1.Name = "Alice Smith";
            client1.Email = "alice@example.com";

            var apartment1 = new Apartment();
            apartment1.Id = 1;
            apartment1.Address = "123 Main St";
            apartment1.ClientId = client1.Id;

            var contract1 = new Contract();
            contract1.Id = 1;
            contract1.Description = "Lease for Alice";
            contract1.ClientId = client1.Id;
            contract1.ApartmentId = apartment1.Id;

            // Forma 2: Constructor con todos los parámetros
            var client2 = new Client(2, "Bob Johnson", "bob@example.com");
            var apartment2 = new Apartment(2, "456 Oak Ave", client2.Id);
            var contract2 = new Contract(2, "Lease for Bob", client2.Id, apartment2.Id);

            // Forma 3: Inicializador de objetos
            var client3 = new Client
            {
                Id = 3,
                Name = "Carol White",
                Email = "carol@example.com"
            };
            var apartment3 = new Apartment
            {
                Id = 3,
                Address = "789 Pine Rd",
                ClientId = client3.Id
            };
            var contract3 = new Contract
            {
                Id = 3,
                Description = "Lease for Carol",
                ClientId = client3.Id,
                ApartmentId = apartment3.Id
            };

            // Añadir contratos y apartamentos a los clientes
            contract1.AssociateWithClientAndApartment(client1, apartment1);
            contract2.AssociateWithClientAndApartment(client2, apartment2);
            contract3.AssociateWithClientAndApartment(client3, apartment3);

            // Crear listas
            var clients = new List<Client> { client1, client2, client3 };
            var apartments = new List<Apartment> { apartment1, apartment2, apartment3 };
            var contracts = new List<Contract> { contract1, contract2, contract3 };
            return Ok(clients);
        }
    }
}
