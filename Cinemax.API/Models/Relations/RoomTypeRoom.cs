public class RoomTypeRoom
{
    public int RoomTypeRoomId {get; set;}
    public int RoomId {get; set;}
    public int RoomTypeId {get; set;}
    public virtual Room Room {get; set;}
    public virtual RoomType RoomType {get; set;}   
}