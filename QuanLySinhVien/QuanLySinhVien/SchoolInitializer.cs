namespace QuanLySinhVien
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SchoolInitializer : DbContext
    {
        public SchoolInitializer()
            : base("name=SchoolInitializer")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
