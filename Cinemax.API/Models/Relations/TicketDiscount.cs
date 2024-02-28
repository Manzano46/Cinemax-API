public class TicketDiscount
{
    public int TicketDiscountId {get; set;}
    public int TicketId {get; set;}
    public int DiscountId {get; set;}    
    public virtual Discount Discount {get; set;}
    public virtual Ticket Ticket {get; set;}
}