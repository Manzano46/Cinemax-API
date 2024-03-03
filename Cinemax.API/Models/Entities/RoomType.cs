namespace Cinemax.API.Models
{
    public class RoomType
    {
        public int RoomTypeId {get; set;}
        public string Name {get; set;}
        public virtual ICollection<RoomTypeRoom>? RoomTypeRooms { get; set;}
    }
}