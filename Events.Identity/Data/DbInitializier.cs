namespace Events.Identity.Data
{
    public class DbInitializier
    {
        public static void Initialize(AuthDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
