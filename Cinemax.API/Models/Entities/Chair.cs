public class Chair
{
    public int ChairId {get; set;}
    public int RoomId {get; set;}
    public virtual Room Room {get; set;}
    public virtual ICollection<Ticket>? Tickets {get; set;}
}