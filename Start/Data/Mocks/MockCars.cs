using Start.Data.Interfaces;
using Start.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Start.Data.Mocks
{
    public class MockCars : ICars
    {
        private readonly ICategory _category = new MockCategory();
        public IEnumerable<Car> GetCars
        {
            get
            {
                return new List<Car>
                {
                    new Car{
                        Id = 1,
                        Name ="Tesla",
                        Image ="/img/tesla.jpg",
                        Price = 100000,
                        Available =true,
                        Category =_category.Categories.First() },
                    new Car{
                        Id = 2,
                        Name ="Audi",
                        Image ="/img/audi.jpg",
                        Price = 50000,
                        Available =false,
                        Category =_category.Categories.Last() },
                     new Car{
                        Id = 2,
                        Name ="Mercedes",
                        Image ="/img/mercedes.jpg",
                        Price = 70000,
                        Available =false,
                        Category =_category.Categories.Last() }
                };
            }
        }

    }
}
