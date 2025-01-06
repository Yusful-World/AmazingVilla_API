using AmazingVilla_API.Dtos;

namespace AmazingVilla_API.Data
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto {Id = 1, Name = "BarBeach" },
                new VillaDto {Id = 2, Name = "ElegusiBeach" },
                new VillaDto { Id = 3, Name = "ElekoBeach" }
        };

    }
}
