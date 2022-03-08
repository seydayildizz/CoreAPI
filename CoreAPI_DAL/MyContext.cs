using CoreAPI_EL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreAPI_DAL
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            :base(options)
        {

        }

        //Tablolara ait sanal dbSet
        public virtual DbSet<Assignment> Assignments { get; set; }
    }
}
