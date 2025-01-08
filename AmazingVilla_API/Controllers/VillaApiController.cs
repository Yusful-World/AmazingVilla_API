using AmazingVilla_API.Data;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            var listOfVillas = VillaStore.villaList;
            return Ok(listOfVillas);
        }

        [HttpGet("{id:int}", Name ="GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(typeof(VillaDto), 200)]
        public ActionResult<VillaDto> GetVilla([FromRoute] int id)
        {
            if (id is 0)
            {
                return BadRequest("Invalid id");
            }

            var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound("Villa does not exist");
            }

            return Ok(villa);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDto> CreateVilla([FromBody] VillaDto villaDto)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (VillaStore.villaList.FirstOrDefault(v => v.Name.ToLower() == villaDto.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Villa already exists");
                return BadRequest(ModelState);
            }

            if (villaDto == null)
            {
                return BadRequest(villaDto);
            }

            if (villaDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            villaDto.Id = VillaStore.villaList.OrderByDescending(v => v.Id).FirstOrDefault().Id + 1;
            VillaStore.villaList.Add(villaDto);
            
            return CreatedAtRoute("GetVilla", new { id = villaDto.Id }, villaDto);
        }
    }
}
