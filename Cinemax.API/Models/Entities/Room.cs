namespace Cinemax.API.Models
{
    public class Room{
        public int RoomId {get; set;}
        public int Width {get; set;}
        public int Height {get; set;}

        public virtual ICollection<RoomTypeRoom> RoomTypeRooms { get; set; }
        public virtual ICollection<Projection>? Projections { get; set; }
        public virtual ICollection<Chair> Chairs {get; set;}
    }
}