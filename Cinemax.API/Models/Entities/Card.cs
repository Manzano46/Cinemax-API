namespace Cinemax.API.Models
{
    public class Card
    {
        public int CardId {get; set;}
        public virtual ICollection<CardUser> CardUsers { get; set;}
        public virtual ICollection<TicketCard> TicketCards {get; set;}
    }
}