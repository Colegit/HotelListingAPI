﻿namespace HotelListing_API.Models;

public class Country
{
    public int CountryId { get; set; }

    public required string Name { get; set; }

    public string? ShortName { get; set; }

    public IList<Hotel> Hotels { get; set; } = [];

}
