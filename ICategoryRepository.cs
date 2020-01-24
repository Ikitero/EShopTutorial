using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Models
{
    interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get;  }
    }
}
