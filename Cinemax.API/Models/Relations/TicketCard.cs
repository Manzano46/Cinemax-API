public class TicketCard
{
    public int TicketCardId {get; set;}
    public int TicketId {get; set;}
    public int CardId {get; set;}
    public virtual Ticket Ticket {get; set;}
    public virtual Card Card {get; set;}   
}