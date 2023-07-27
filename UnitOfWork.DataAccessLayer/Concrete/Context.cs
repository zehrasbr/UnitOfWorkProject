using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EntityLayer.Concrete;

namespace UnitOfWork.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options):base (options)
        { 

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerProcess> CustomersProcess { get; set; }
    }
}
