using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactRepository.Context
{
    // DatabaseContext extends DbContext class
    public class DatabaseContext: DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        // Each DbSet<T> represents a table in the database
        public DbSet<Contact> Contacts { get; set; }
    }
}
