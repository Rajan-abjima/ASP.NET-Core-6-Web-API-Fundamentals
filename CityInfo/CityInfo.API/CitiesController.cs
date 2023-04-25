﻿using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API

{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object>
               {
                    new{id=1, name="New York City" },
                    new{id=2, name="AntWerp" },
                    new{id=3, name="Paris" }
               });

        }
    }
}
