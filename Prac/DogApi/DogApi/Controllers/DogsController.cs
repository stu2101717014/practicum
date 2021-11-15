using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DogApi.Models;
using DogApi.Contexts;
using DogApi.Enums;
using System;

namespace DogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogsController : ControllerBase
    {
        private readonly DogDBContext _context;

        public DogsController(DogDBContext context)
        {
            _context = context;
        }


       [HttpGet]
        public async Task<ActionResult<IEnumerable<Dog>>> GetDog()
        {
            return await _context.Dogos.ToListAsync();
        }


        [HttpGet("{params}")]
        public  ActionResult<IEnumerable<Dog>> Get(
            [FromQuery(Name = "IsCute")] bool isCute
            ,[FromQuery(Name = "IsSmart")] bool isSmart
            ,[FromQuery(Name = "IsEducated")] bool isEducated
            ,[FromQuery(Name = "DogBreed")] DogBreed dogBreed
            ,[FromQuery(Name = "UseCheckBoxesForFilteringData")] bool useCheckBoxesForFilteringData
            )
        {

            Func<Dog, bool> CheckCheckBoxes = delegate (Dog d)
            {
                if (useCheckBoxesForFilteringData)
                {
                    return d.IsCute == isCute && d.IsEducated == isEducated && d.IsSmart == isSmart;
                }
                return true;
            };

            Func<Dog, bool> CheckBreeds = delegate (Dog d)
            {
                if (dogBreed == DogBreed.All)
                {
                    return true;
                }
                if (dogBreed == DogBreed.None)
                {
                    return false;
                }
                return d.Breed == dogBreed;
            };

            var dogos = _context.Dogos
                .AsEnumerable()
                .Where(d => CheckCheckBoxes(d))
                .Where(d => CheckBreeds(d))
                .ToList();

            return dogos;

        }

    }
}
