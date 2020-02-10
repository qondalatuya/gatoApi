using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GatoApi.Daos;
using GatoApi.Entidades;
using GatoApi.Config;

namespace GatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private ClienteDao _clienteDao = new ClienteDao();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_clienteDao.GetAll());
        }

        [HttpGet("{i}")]
        public IActionResult Get(int i)
        {
            if (_clienteDao.GetById(i) == null)
            {
                return NotFound("No se encontro el cliente");
            }
            else
            {
                return Ok(_clienteDao.GetById(i));
            }
        }

        
        [HttpPost("agregar")]
        public IActionResult Post(Cliente cliente)
        {
            _clienteDao.Persist(cliente);
            return Ok();

        }
        

    }
}