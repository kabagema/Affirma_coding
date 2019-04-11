using System;
using System.Linq;

namespace SampleWebApiAspNetCore.Entities
{
    public class FoodItem
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Calories { get; set; }
        // add a weight method
        // Where is the weight variable?
        public int Weight { get; set; }
        public DateTime Created { get; set; }

        
    }
}
