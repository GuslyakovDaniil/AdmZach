using Microsoft.AspNetCore.Mvc;
using MyApiApp.Models;
using System.Collections.Generic;

namespace MyApiApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Model2Controller : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Model2> Get()
        {
            // Здесь должен быть код, возвращающий данные модели Model2
            return new List<Model2>();
        }
    }
}
