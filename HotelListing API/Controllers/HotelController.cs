using HotelListing_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing_API.Controllers;

//test
[Route("api/[controller]")]
[ApiController]
public class HotelController : ControllerBase
{

    private static List<Hotel> hotels = new List<Hotel>()
    {
        new Hotel { Id = 1, Address = "124 fake st", Name = "fairmount", Rating = 4.5 },
        new Hotel { Id = 2, Address = "453 george st", Name = "ramada", Rating = 3.5 }
    };

    // GET: api/<HotelsController>
    [HttpGet] 
    public ActionResult<IEnumerable<Hotel>> Get()
    {
        return Ok(hotels);
    }

    // GET api/<HotelsController>/5
    [HttpGet("{id}")]
    public ActionResult<Hotel> Get(int id)
    {
        //firstOrDefault will grab the item your looking for, if not found, resorts to the default, which is null.
        var hotel = hotels.FirstOrDefault(hotel => hotel.Id == id);
        if (hotel == null) {
            return NotFound();
        }

        return Ok(hotel);
    }

    // POST api/<HotelsController>
    [HttpPost]
    public ActionResult<Hotel> Post([FromBody] Hotel newHotel)
    {
        if (hotels.Any(h => h.Id == newHotel.Id)) { return BadRequest("Hotel with this ID already exists"); }

        //here we are just adding to our lit in memory above. normally would be a db insert
        hotels.Add(newHotel);
        return CreatedAtAction(nameof(Get), newHotel);

    }

    // PUT api/<HotelsController>/5
    [HttpPut("{id}")]
    public ActionResult Put(int id, [FromBody] Hotel updatedHotel)
    {
        var existingHotel = hotels.FirstOrDefault(hotel => hotel.Id == id);
        if (existingHotel == null)
        {
            return NotFound("The hotel ID you are trying to edit doesnt exist: " + id);
        }
        else {
            existingHotel.Name = updatedHotel.Name;
            existingHotel.Address = updatedHotel.Address;
            existingHotel.Rating = updatedHotel.Rating;

            return Ok(updatedHotel);
        }
    }

    // DELETE api/<HotelsController>/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var existingHotel = hotels.FirstOrDefault(hotel => hotel.Id == id);
        if (existingHotel == null)
        {
            return NotFound(id);
        }

        hotels.Remove(existingHotel);
        return NoContent();
    }
}
