using AmazingVilla_API.Dtos;

namespace AmazingVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto {Name = "BarBeach", Occupancy = 50, Sqft = 100},
                new VillaDto {Name = "ElegusiBeach", Occupancy = 60, Sqft = 100 },
                new VillaDto { Name = "ElekoBeach", Occupancy = 70, Sqft = 100 }
        };

    }
}
