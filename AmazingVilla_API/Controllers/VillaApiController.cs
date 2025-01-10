using AmazingVilla_API.Data;
using AmazingVilla_API.Dtos;
using AmazingVilla_API.Logging;
using AmazingVilla_API.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace AmazingVilla_API.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaApi")]
    [ApiController]
    public class VillaApiController : ControllerBase 
    {
        //private readonly ILogging _logger;
        //public VillaApiController(ILogging logger)
        //{
        //    _logger = logger;
        //}


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            //_logger.Log("Getting all Villas", "");
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
                //_logger.Log($"{id} is not a valid id, pleasae input a valid id", "error");
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


        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public IActionResult DeleteVilla([FromRoute] int id)
        {
            if (id == null)
            {
                return BadRequest(id);
            }

            var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            
            if (villa == null)
            {
                return NotFound("Villa does not exist");
            }

            VillaStore.villaList.Remove(villa);

            return NoContent();
        }


        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id:int}", Name = "UpdateVilla")]
        public IActionResult UpdateVilla(int id, [FromBody] VillaDto villaDto)
        {
            if (villaDto == null || id != villaDto.Id)
            {
                return BadRequest();
            }

            var existingVilla = VillaStore.villaList.FirstOrDefault(x => x.Id == id);
            if (existingVilla == null)
            {
                return NotFound();
            }

            existingVilla.Name = villaDto.Name;
            existingVilla.Sqft = villaDto.Sqft;
            existingVilla.Occupancy = villaDto.Occupancy;

            return NoContent();
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPatch("{id:int}", Name = "PartialUpdateVilla")]
        public IActionResult PartialUpdateVilla(int id, JsonPatchDocument<VillaDto> patchVillaDto)
        {
            if (patchVillaDto == null || id == 0)
            {
                return BadRequest();
            }

            var existingVilla = VillaStore.villaList.FirstOrDefault(x => x.Id == id);
            if (existingVilla == null)
            {
                return NotFound();
            }

            patchVillaDto.ApplyTo(existingVilla, ModelState);
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return NoContent();
        }
    }
}
