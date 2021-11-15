using DogApi.Attributes;
using DogApi.Contexts;
using DogApi.Enums;
using DogApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParamsController : ControllerBase
    {
        private readonly DogDBContext _context;

        public ParamsController(DogDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Tuple<string, string>>> GetDogParams()
        {
            var type = typeof(Dog);
            var props = type.GetProperties().ToList().Where(p =>
                {
                    return Attribute.IsDefined(p, typeof(DogExportableAttr));
                });

            var listForReturn = new List<Tuple<string, string>>();
            foreach (var prop in props)
            {
                var current = new Tuple<string, string>(
                    prop.Name,
                    prop.PropertyType.ToString());
                listForReturn.Add(current);
            }

            var dogExportableAttrValues = Enum.GetValues(typeof(DogBreed));

            foreach (var val in dogExportableAttrValues) 
            {
                listForReturn.Add(new Tuple<string, string>("DogBreed", val.ToString()));
            }

            return listForReturn;
        }
    }
}
