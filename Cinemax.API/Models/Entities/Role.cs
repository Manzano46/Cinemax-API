namespace Cinemax.API.Models
{
    public class Role
    {
        public int RoleId {get; set;}
        public string Name {get; set;}
        public virtual ICollection<RoleUser> RoleUsers { get; set;}
    }
}