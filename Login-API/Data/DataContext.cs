public class DataContext:DbContext{
    public DataContext(DbContextOptions<DataContext> Options):base(Options){}
    public DbSet <Users> Users {get; set;}
}