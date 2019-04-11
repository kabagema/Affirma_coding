using System;

namespace SampleWebApiAspNetCore.Dtos
{
    public class FoodItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        // add weight here
        public int Weight { get; set; }
        public int Calories { get; set; }
        public DateTime Created { get; set; }
    }
}
