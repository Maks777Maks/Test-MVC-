using Start.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Start.Data.Interfaces
{
    public interface ICars
    {
        IEnumerable<Car> GetCars { get; }

    }
}
