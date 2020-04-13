using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GatoApi.Daos;
using GatoApi.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        private MaterialDao _materialDao = new MaterialDao();
        private TipoMaterialDao _tipoMaterialDao = new TipoMaterialDao();
        
        [HttpGet]
        public IActionResult agregarCliente()
        {
            Material material = new Material();
            material.Nombre = "Malta Pale";
            material.Tipo = _tipoMaterialDao.GetById(1);
            _materialDao.Persist(material);
            material.Tipo.Materials = null;
            return Ok(material);
        }
    }
}