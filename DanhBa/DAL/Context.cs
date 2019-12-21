using DanhBa.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhBa.DAL
{
    class Context : DbContext
    {
        public Context()
           : base("Data Source=.;Initial Catalog=DanhBa;Integrated Security=True;User ID=sa,Password=123")
        {

        }
        public DbSet<DanhBaQL> DanhBaDbset { get; set; }
        public DbSet<NhomDB> NhomDanhBaDbset { get; set; }
    }
}
