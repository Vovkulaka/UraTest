using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Data.Entity;

namespace KontrolProject.Models
{
    public class RestaurantsContext : DbContext
    {
        public RestaurantsContext()
            : base("RestaurantsDBConnection")
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}