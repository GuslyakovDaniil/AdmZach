using Microsoft.AspNetCore.Mvc;
using MyApiApp.Models;
using System.Collections.Generic;

namespace MyApiApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Model1Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Model1> Get()
        {
            // Здесь должен быть код, возвращающий данные модели Model1
            return new List<Model1>();
        }
    }
}
