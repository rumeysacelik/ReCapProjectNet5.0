using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage)
        {
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }

        public IResult Update(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int carImageId)
        {
           string d= "sdde";
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetCarId(int carImageId)
        {
            throw new NotImplementedException();
        }
    }
}
