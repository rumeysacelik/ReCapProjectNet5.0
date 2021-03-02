using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
   public class BrandManager:IBrandService
   {
       private IBrandDal _brandDal;

       public BrandManager(IBrandDal brandDal)
       {
           _brandDal = brandDal;
       }

       public void Add(Brand brand)
        {
           _brandDal.Add(brand);
        }

        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

        public void Delete(int brandId)
        {
            _brandDal.Delete(_brandDal.Get(p=>p.Id==brandId));
        }

        public List<Brand> GetAllBrands()
        {
            return _brandDal.GetAll();
        }

        public Brand GetBrandId(int brandId)
        {
           return _brandDal.Get(p => p.Id == brandId);
        }
    }
}
