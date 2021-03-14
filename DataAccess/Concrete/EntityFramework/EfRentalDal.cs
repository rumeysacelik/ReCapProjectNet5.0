using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            using (ReCapDbContext recapContext = new ReCapDbContext())
            {
                var results = from rental in recapContext.Rentals
                              join car in recapContext.Cars on rental.CarId equals car.Id
                              join brand in recapContext.Brands on car.BrandId equals brand.Id
                              join customer in recapContext.Customers on rental.CustomerId equals customer.Id
                              join user in recapContext.Users on customer.UserId equals user.Id
                              select new RentalDetailDto
                              {
                                  RentalId = rental.Id,
                                  CarName = car.Name,
                                  BrandName = brand.Name,
                                  FirstName = user.FirstName,
                                  LastName = user.LastName
                              };
                return results.ToList();
            }
        }
    }
}
