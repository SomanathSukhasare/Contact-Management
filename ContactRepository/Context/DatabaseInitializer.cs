using System.Data.Entity;

namespace ContactRepository.Context
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
            context.SaveChanges();
        }
    }
}
