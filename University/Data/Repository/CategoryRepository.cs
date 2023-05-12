using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DBContent dBContent;

        public CategoryRepository(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }

        public IEnumerable<Category> GetCategories() => dBContent.Categories;

        public Category GetCategoryById(int id) => dBContent.Categories.FirstOrDefault(c => c.Id == id);

        public void AddCategory(Category category)
        {
            category.Id = dBContent.Categories.Count() + 1;
            dBContent.Categories.Add(category);
        }
        public void UpdateCategory(Category category)
        {
            var categoryToChange = dBContent.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (categoryToChange != null)
            {
                categoryToChange = category;
            }
        }

        public void DeleteCategory(int id)
        {
            var categoryToDelete = dBContent.Categories.FirstOrDefault(c => c.Id == id);
            if (categoryToDelete != null)
            {
                dBContent.Categories.Remove(categoryToDelete);
            }
        }
    }
}
