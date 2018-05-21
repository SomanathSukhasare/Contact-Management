using System.Data.Entity;

namespace ContactsDAL.Context
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
