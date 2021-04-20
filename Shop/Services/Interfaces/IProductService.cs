using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Services.Interfaces
{
    public interface IProductService
    {
        public static int ProductsPerPage
        {
            get
            {
                return 10;
            }
        }
    }
}
