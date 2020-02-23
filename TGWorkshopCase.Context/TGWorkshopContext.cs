using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TGWorkshopCase.Entities.Model;

namespace TGWorkshopCase.Context
{
    public class TGWorkshopContext:DbContext
    {

        public TGWorkshopContext(DbContextOptions<TGWorkshopContext> options) : base(options) { }


        public virtual DbSet<TGUser> TGUsers { get; set; }
        public virtual DbSet<TGProduct> TGProducts { get; set; }
        public virtual DbSet<TGSupplier> TGSuppliers { get; set; }
        public virtual DbSet<TGSupplierProduct> TGSupplierProducts { get; set; }
    }
}
