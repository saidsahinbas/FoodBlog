using System.Collections.Generic;

namespace FoodBlog.Models.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
