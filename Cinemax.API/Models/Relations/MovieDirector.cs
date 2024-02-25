public class MovieDirector
{
    public int DirectorId {get; set;}
    public int MovieId {get; set;}
    public virtual Director Director {get; set;}
    public virtual Movie Movie {get; set;}   
}