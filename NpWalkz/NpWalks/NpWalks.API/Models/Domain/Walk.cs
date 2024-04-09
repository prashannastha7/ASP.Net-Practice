namespace NpWalks.API.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string  Description{ get; set; }
        public string? WalkImageUrl { get; set; } //? is used to make nullable
        public Guid DifficultyId{ get; set; }
        public Guid RegionId{ get; set; }
    }

    //Navigation properties

}
