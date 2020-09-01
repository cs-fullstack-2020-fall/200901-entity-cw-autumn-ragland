using Microsoft.EntityFrameworkCore;
using Classwork.Models;
namespace Classwork.DAO
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        public DbSet<StudentModel> students{get;set;}
    }
}