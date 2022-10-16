using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> ListAllCategory();
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
        Category GetById(int id);
    }
}
