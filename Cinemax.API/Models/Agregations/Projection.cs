
public class Projection
    {
        public int ProjectionId {get; set;}
        public DateTime DateTime {get; set;}
        public int Price {get; set;}
        public int RoomId {get; set;}
        public int MovieID {get; set;}

        public virtual Room? Room {get; set;}
        public virtual Movie? Movie {get; set;}
        public virtual ICollection<Ticket>? Tickets {get; set;}
    }
