using BuisnessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        /// <summary>
        /// Aşağıdaki constuructor sayesinde injection yapılıyor ve DAL içerisinde bloğa ait tüm fonksiyonlar ile iletişim kuruluyor.
        /// </summary>
        /// <param name="blogDal"></param>
        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);
        }


        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public Blog GetByID(Blog blog)
        {
            return _blogDal.GetByID(blog.BlogID);
        }

        public List<Blog> GetListAllBlogs()
        {
            return _blogDal.GetListAll();
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
