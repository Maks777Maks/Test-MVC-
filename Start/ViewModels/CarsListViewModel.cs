using Start.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Start.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> GetCars { get; set; }
        public string CarCategory { get; set; }
    }
}
