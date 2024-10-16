using Clinic.Interfaces.Client;
using Clinic.Models;
using Clinic.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clientService.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute]int id)
        {
            Client client = _clientService.GetById(id);

            if (client == null)
                return NotFound("Client not found!");

            return Ok(client);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateClientRequest request)
        {
            _clientService.Create(request);
            return Created();
        }

        [HttpPut]
        public IActionResult MakeAppointment([FromBody] MakeAppointmentRequest request)
        {
            _clientService.MakeAppointment(request);
            return Ok();
        }
    }
}
