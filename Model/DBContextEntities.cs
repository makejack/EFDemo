using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;


namespace Model
{
    public class DBContextEntities : DbContext
    {
        public DBContextEntities() : base("PayParkingLotsEntities")
        {
        }

        public virtual DbSet<Administrators> Administrators { get; set; }
    }
}
