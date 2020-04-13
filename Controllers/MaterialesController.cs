using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using GatoApi.Daos;
using GatoApi.Entidades;
using System.Web.Http.Cors;

namespace GatoApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class MaterialesController : ControllerBase
    {
        private MaterialDao _materialDao = new MaterialDao();
        private TipoMaterialDao _tipoMaterialDao = new TipoMaterialDao();

        [HttpGet]
        [EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
        [Produces("application/json")]
        public IActionResult getMateriales()
        {
            try
            {
                return Ok(_materialDao.GetAll()); //todas las responses, ok , badRequed lo que dea, deben retornar un json, que es el fomrato de dato que espera angular
            }
            catch (Exception e)
            {
                return this.BadRequest("Hubo un problema, osea afó" + e.Message);
            }

        }

        [HttpGet("{id}")]
        [EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
        [Produces("application/json")]
        public IActionResult getMaterial(int id)
        {

            try
            {
                return Ok(this._materialDao.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest("adó" + e.Message);
            }
        }

        [HttpPost("agregar")]
        [EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
        [Produces("application/json")]
        public IActionResult AddMaterial(Material material)
        {
            try
            {
                this._materialDao.Persist(material);
                return Ok(material);
            }
            catch (Exception e)
            {
                return this.BadRequest("Hubo un problema, osea afó" + e.Message+e.StackTrace);
            }            
        }

        
        [HttpDelete("borrar/{id}")]
        [EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
        public IActionResult DeletMaterial( int id)
        {
            try
            {
                Material material = _materialDao.GetById(id);
                this._materialDao.Delete(id);
                return Ok(material);
            }
            catch(Exception e)
            {
                return this.BadRequest("Hubo un problema, osea afó" + e.Message);
            }

        }

        [HttpGet("tipos")]
        [EnableCors(origins: "http://localhost:4200/", headers: "*", methods: "*")]
        public IActionResult getTiposMaterial() {
            try
            {
                return Ok(_tipoMaterialDao.GetAll());
            }
            catch (Exception e)
            {
                return this.BadRequest("Hubo un problema, osea afó" + e.Message);
            }
        }
    }
}
