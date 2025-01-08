using AmazingVilla_API.Dtos;

namespace AmazingVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto {Id = 1, Name = "BarBeach", Occupancy = 50, SqFeet = 100},
                new VillaDto {Id = 2, Name = "ElegusiBeach", Occupancy = 60, SqFeet = 100 },
                new VillaDto { Id = 3, Name = "ElekoBeach", Occupancy = 70, SqFeet = 100 }
        };

    }
}
