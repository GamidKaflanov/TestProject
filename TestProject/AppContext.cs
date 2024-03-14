using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUITestProject
{
    public class AppContext : DbContext
    {
        public AppContext(): base("DbBankConnection") { }
        public DbSet<User> Users { get; set; }
    }
}
