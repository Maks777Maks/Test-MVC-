using Start.Data.Interfaces;
using Start.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Start.Data.Mocks
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{
                        Id = 1,
                        CategoryName ="Benzin"
                    },
                     new Category{
                         Id = 2,
                         CategoryName ="Dizel"
                     }
                };
            }
        }
    }
}
