using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(int brandId);
        List<Brand> GetAllBrands();
        Brand GetBrandId(int brandId);
    }
}
