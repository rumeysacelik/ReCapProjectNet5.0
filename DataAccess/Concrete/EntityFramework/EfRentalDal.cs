using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
   public class EfRentalDal:EfEntityRepositoryBase<Rental,ReCapDbContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetailDtos()
        {
            throw new NotImplementedException();
        }
    }
}
