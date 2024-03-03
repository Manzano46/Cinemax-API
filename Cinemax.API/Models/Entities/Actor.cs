namespace Cinemax.API.Models
{
    public class Actor
    {
        public int ActorId {get; set;}
        public string Name {get; set;}    
        public virtual ICollection<MovieActor>? MovieActors { get; set; }
    }
}