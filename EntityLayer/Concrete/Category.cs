using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    /// <summary>
    /// Category Entity tanımları
    /// </summary>
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Blog> Blogs { get; set; } // Bir categoride birden çok blog olabilir.

        // IClooection --> elementleri tutar IEnumerable arayüzünü kullanır
        // List --> elementin indexini tutar IColleciton ve IEnumerable araüyzünü kullanır
    }
}
