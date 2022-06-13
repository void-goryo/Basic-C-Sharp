using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace StudentEntity
{
    class SchoolContext : DbContext
    {
        public SchoolContext(): base()
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
