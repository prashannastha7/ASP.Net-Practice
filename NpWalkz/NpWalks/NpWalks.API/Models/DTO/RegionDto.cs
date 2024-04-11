// DTOs used : to not expose the names of domain,
// helps to only exposed the limited data to client 
// changes the model but the dtos reminds same so that we aren't breaking the contract btw client and API


//This can have one or multiple properties of Domain Model


namespace NpWalks.API.Models.DTO
{
    public class RegionDto
    {
        public Guid Id { get; set; }
        public required string Code { get; set; }
        public required string Name { get; set; }
        public string? RegionImageUrl { get; set; } //? is used to make nullable
    }
}
