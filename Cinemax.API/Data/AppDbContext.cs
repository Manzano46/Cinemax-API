using Microsoft.EntityFrameworkCore;
namespace Cinemax.API.Models;

public class AppDbContext:DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
         
    }


    // public DbSet<Projection> Projections {get; set;}
    // public DbSet<Ticket> Tickets {get; set;}
    // public DbSet<Actor> Actors {get; set;}
    // public DbSet<Card> Cards {get; set;}
    // public DbSet<Chair> Chairs {get; set;}
    // public DbSet<Country> Countries {get; set;}
    // public DbSet<Director> Directors {get; set;}
    // public DbSet<Discount> Discounts {get; set;}
    // public DbSet<Genre> Genres {get; set;}
    public DbSet<Movie> Movies {get; set;} = null!;
    // public DbSet<PaymentType> PaymentTypes {get; set;}
    // public DbSet<Role> Roles {get; set;}
    // public DbSet<Room> Rooms {get; set;}   
    // public DbSet<RoomType> RoomTypes {get; set;}
    // public DbSet<User> Users {get; set;}
    // public DbSet<CardUser> CardUsers {get; set;}
    // public DbSet<MovieActor> MovieActors {get; set;}
    // public DbSet<MovieCountry> MovieCountries {get; set;}
    // public DbSet<MovieDirector> MovieDirectors {get; set;}
    // public DbSet<MovieGenre> MovieGenres {get; set;}
    // public DbSet<RoleUser> RoleUsers {get; set;}
    // public DbSet<RoomTypeRoom> RoomTypeRooms {get; set;}
    // public DbSet<TicketCard> TicketCards {get; set;}
    // public DbSet<TicketDiscount> TicketDiscounts {get; set;}
}