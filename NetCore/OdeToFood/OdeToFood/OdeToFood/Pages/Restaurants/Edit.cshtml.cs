using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public Restaurant Restaurant { get; set; }
        public IEnumerable<SelectListItem> Cuisines { get; set; }
        private readonly IRestaurantData restaurantData;
        private readonly IHtmlHelper htmlHelper;

        public EditModel(IRestaurantData restaurantData,IHtmlHelper htmlHelper)
        {
            this.restaurantData = restaurantData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int? restaurantId) // changed Void to IActionResult to handle the exception.
        {
            Cuisines = htmlHelper.GetEnumSelectList<Cusisine>();
            if (restaurantId.HasValue)
            {
                Restaurant = restaurantData.GetById(restaurantId.Value);
            }
            else
            {
                Restaurant = new Restaurant();
            }
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
            //Restaurant = new Restaurant();
            //Restaurant.Id = restaurantId;
        }
        // commnted to support Add new restaurant, this function will work for update only
        //public IActionResult OnPost()
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Restaurant = restaurantData.Update(Restaurant);
        //        restaurantData.Commit();
        //        return RedirectToPage("./Details", new {restaurantId = Restaurant.Id });
        //    }
        //    Cuisines = htmlHelper.GetEnumSelectList<Cusisine>();

        //    return Page();
        //}
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Cuisines = htmlHelper.GetEnumSelectList<Cusisine>();
                return Page();
            }
            if (Restaurant.Id > 0)
            {
                restaurantData.Update(Restaurant);
            }
            else
            {
                restaurantData.Add(Restaurant);
            }
            TempData["Message"] = "Restaurant Saved!";
            restaurantData.Commit();
            return RedirectToPage("./Details", new {restaurantId = Restaurant.Id });            
        }
    }
}