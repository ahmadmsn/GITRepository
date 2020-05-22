using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantdata;
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public string MessageCs { get; set; }
        public string MessageApp { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public ListModel(IConfiguration config, IRestaurantData restaurantdata)
        {
            this.config = config;
            this.restaurantdata = restaurantdata;
        }
        //public void OnGet(string searchTerm)
        public void OnGet(string SearchTerm)
        {
            MessageCs = "Hello Word!";
            MessageApp = config["MessageAppSettings"];
            //Restaurants = restaurantdata.GetAll();
            //Restaurants = restaurantdata.GetRestaurantByName(searchTerm);
            Restaurants = restaurantdata.GetRestaurantByName(SearchTerm);
        }
    }
}