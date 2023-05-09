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
                new Category { Id = 1, Name = "Монітори", Description = "Пристрій оперативного візуального зв'язку користувача з керуючим пристроєм та відображенням даних, що передаються з клавіатури, миші або центрального процесора" },
                new Category { Id = 2, Name = "Перифірія для ПК", Description = "Апаратура, яка дозволяє вводити інформацію до комп'ютера або виводити її з нього" }
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
