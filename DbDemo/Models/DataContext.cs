using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DbDemo.Models
{
    public class DataContext : DbContext
    {
       public  DbSet<Emplyee> Emplyees { get; set; }

    }
}