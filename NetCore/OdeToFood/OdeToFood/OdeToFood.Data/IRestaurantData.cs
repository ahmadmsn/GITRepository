using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
   public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id =1,Name ="Peter",Location="Delhi",Cusiine=Cusisine.Indian },
                new Restaurant {Id =2,Name ="Anders",Location="Ranchi",Cusiine=Cusisine.Italian },
                new Restaurant {Id =3, Name ="Walter",Location="Bangalore",Cusiine=Cusisine.Mexican }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }       
    }
}




