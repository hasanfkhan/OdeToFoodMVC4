﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Models
{
    public class OdeToFoodDb : DbContext
    {
        public OdeToFoodDb() : base("name=DefaultConnection")
        {

        }
        public IDbSet<Restaurant> Restaurants { get; set; }
        public IDbSet<RestaurantReview> Reviews { get; set; }
    }
}
