using System.Collections.Generic;
using Nancy;

namespace nancy_sample.Module
{
    public class CategoryService : NancyModule
    {

        public CategoryService() : base("/services")
        {
            Get["/categories"] = parameters =>
            {
                return Response.AsJson(Categories.all());
            };
        }

    }

    public class Categories
    {
        public static List<Category> allCategories = new List<Category>(){new Category(1, "tactial"),new Category(2,"strategic"), new Category(3, "staff aug")};



        public static List<Category> all()
        {
            return allCategories;
        }
    }

    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}