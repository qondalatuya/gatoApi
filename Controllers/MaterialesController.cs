using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GatoApi.Daos;
using GatoApi.Entidades;

namespace GatoApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MaterialesController:ControllerBase
    {
        private MaterialDao _materialDao = new MaterialDao();

        [HttpGet]
        public IActionResult getMateriales()
        {
            try
            {
                return Ok(_materialDao.GetAll());
            }
            catch (Exception e)
            {
                return this.BadRequest("Hubo un problema, osea afó" + e.Message);
            }
            
        }
    }
}
