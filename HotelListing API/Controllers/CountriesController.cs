using Microsoft.AspNetCore.Mvc;
using HotelListing_API.Models;

namespace HotelListing_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountriesController : ControllerBase
{
    private readonly HotelListingDbContext _context;

    public CountriesController(HotelListingDbContext context)
    {
        _context = context;
    }

    // GET: api/Values
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/Values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/Values
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
