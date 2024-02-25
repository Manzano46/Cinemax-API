public class Discount
{
    public int DiscountId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<TicketDiscount>? TicketDiscounts {get; set;}
}