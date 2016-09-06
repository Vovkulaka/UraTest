using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace KontrolProject.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Kitchen { get; set; }
        public double Rating { get; set; }
    }
}