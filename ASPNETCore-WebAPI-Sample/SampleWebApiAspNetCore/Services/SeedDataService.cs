using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Repositories;
using System;
using System.Threading.Tasks;

namespace SampleWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public async Task Initialize(FoodDbContext context)
        {
            context.FoodItems.Add(new FoodItem() { Calories = 2000, Name = "pie", Weight = 100, Created = DateTime.Now });
            context.FoodItems.Add(new FoodItem() { Calories = 1000, Name = "Lasagne", Weight = 50, Created = DateTime.Now });
            context.FoodItems.Add(new FoodItem() { Calories = 1100, Name = "Hamburger", Weight = 60, Created = DateTime.Now });
            context.FoodItems.Add(new FoodItem() { Calories = 1200, Name = "Spaghetti", Weight = 75, Created = DateTime.Now });
            context.FoodItems.Add(new FoodItem() { Calories = 1300, Name = "Pizza", Weight = 80, Created = DateTime.Now });

            await context.SaveChangesAsync();
        }
    }
}
