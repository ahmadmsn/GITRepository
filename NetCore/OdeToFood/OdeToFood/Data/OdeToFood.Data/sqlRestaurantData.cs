using System.Collections.Generic;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class sqlRestaurantData : IRestaurantData
    {
        private readonly OdeToFoodDbContext db;
        public sqlRestaurantData(OdeToFoodDbContext db)
        {
            this.db = db;
        }

        public OdeToFoodDbContext Db { get; }

        public Restaurant Add(Restaurant newRestaurant)
        {
            db.Add(newRestaurant);
            return newRestaurant;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public IEnumerable<Restaurant> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Restaurant GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Restaurant> GetRestaurantByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            throw new System.NotImplementedException();
        }
    }

}




