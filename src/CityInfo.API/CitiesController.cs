using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesController : Controller
    {
        [Route("api/cities")]
        [HttpGet()]
        public JsonResult GetCities()
        {
            return new JsonResult(new List<Object>
            {


            new { id=1, Name="New York City"},
            new { id=2, Name="Antwerp"}
            });
        }
    }
}
