using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext //Burada Inheritance  //Bu class içerisinde Connection String (Bağlantı adresi) tanımlanacak.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // Tanımlanan OnConfiguring methodunun içerisinde Connection string tanımlanacak. Parantez içerisine parametre girilir Connection stringi tanımlamak için böyle bir yapıya ihtiyaç var
        {
            optionsBuilder.UseSqlServer("server=.; database=Eblog; integrated security=true;");
        }

        public DbSet<About>? Abouts { get; set; }
        public DbSet<Blog>? Blogs { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<Writer>? Writers { get; set; }
    }
}
