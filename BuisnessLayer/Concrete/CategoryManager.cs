using BuisnessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRepository;
        public CategoryManager()
        {
            efCategoryRepository = new EfCategoryRepository();
        }
        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetByID(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetListAllCategories(Category category)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
