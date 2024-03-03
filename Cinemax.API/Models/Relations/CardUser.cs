namespace Cinemax.API.Models
{
    public class CardUser
    {
    public int CardUserId {get; set;}
    
        public int CardId {get; set;}
        public int UserId {get; set;}
        public virtual Card Card {get; set;}
        public virtual User User {get; set;}
    }
}