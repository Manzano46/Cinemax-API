public class User
{
    public int UserId {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}  
    public DateOnly Birth {get; set;}
    public int Points {get; set;}
    public virtual ICollection<RoleUser> RoleUsers { get; set;}  
    public virtual ICollection<CardUser>? CardUsers { get; set;}
    public virtual ICollection<Ticket>? Tickets {get; set;}
}
