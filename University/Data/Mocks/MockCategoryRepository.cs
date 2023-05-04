using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> categories;

        public MockCategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category { Id = 1, Name = "Computers", Description = "Desktops, laptops and tablets" },
                new Category { Id = 2, Name = "Accessories", Description = "Keyboards, mice and other peripherals" }
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            return categories.FirstOrDefault(c => c.Id == id);
        }

        public void AddCategory(Category category)
        {
            category.Id = categories.Count + 1;
            categories.Add(category);
        }
        public void UpdateCategory(Category category)
        {
            var index = categories.FindIndex(c => c.Id == category.Id);
            if (index >= 0)
            {
                categories[index] = category;
            }
        }

        public void DeleteCategory(int id)
        {
            var index = categories.FindIndex(c => c.Id == id);
            if (index >= 0)
            {
                categories.RemoveAt(index);
            }
        }
    }
}
