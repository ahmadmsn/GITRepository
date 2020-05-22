using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        [TempData]
        public string Message { get; set; }
        public Restaurant Restaurant { get; set; }
        private readonly IRestaurantData restaurantData;

        public DetailsModel(IRestaurantData restaurantData)
        {
            this.restaurantData = restaurantData;
        }
        public IActionResult OnGet(int restaurantId) // changed Void to IActionResult to handle the exception.
        {
            Restaurant = restaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
            //Restaurant = new Restaurant();
            //Restaurant.Id = restaurantId;
        }
    }
}