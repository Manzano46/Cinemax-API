public class PaymentType
{
    public int PaymentTypeId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<Ticket> Tickets {get; set;}
}
