public class TicketCard
{
    public int TicketId {get; set;}
    public int CardId {get; set;}
    public virtual Ticket Ticket {get; set;}
    public virtual Card Card {get; set;}   
}