public class MovieActor
{
    public int ActorId {get; set;}
    public int MovieId {get; set;}
    public virtual Actor Actor {get; set;}
    public virtual Movie Movie {get; set;}
}