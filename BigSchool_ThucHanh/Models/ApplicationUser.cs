using System.Data.Entity;

namespace BigSchool_ThucHanh.Models
{
    public interface IApplicationDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Course> Courses { get; set; }
    }
}