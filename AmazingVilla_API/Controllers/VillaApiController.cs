using AmazingVilla_API.Dtos;
using AmazingVilla_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazingVilla_API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaApi")]
    [ApiController]
    public class VillaApiController : ControllerBase 
    {
        [HttpGet]
        public IEnumerable<VillaDto> GetVillas()
        {
            return new List<VillaDto>
            {
                new VillaDto {Id = 1, Name = "BarBeach" },
                new VillaDto {Id = 2, Name = "ElegusiBeach" },
                new VillaDto {Id = 3, Name = "ElekoBeach" }
            };
        }
    }
}
