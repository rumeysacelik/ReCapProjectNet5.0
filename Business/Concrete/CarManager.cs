using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            IResult result = BusinessRules.Run(CheckIfCarNameExists(car.Name),
                CheckIfProductCountOfCategoryCorrect(car.Id), CheckIfCategoryLimitExceded());

            if (result != null)
            {
                return result;
            }

            _carDal.Add(car);
            return new SuccessResult();
        }

        public IResult Delete(int carId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetCarId(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=>p.Id==carId));
        }

        public IResult Update(Car car)
        {
           _carDal.Update(car);
           return new SuccessResult();
        }
        private IResult CheckIfCarNameExists(string carName)
        {
            var result = _carDal.GetAll(p => p.Name == carName).Any();
            if (result)
            {
                return new ErrorResult("Aynı araç bulunuyor");
            }
            return new SuccessResult();
        }
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            //Select count(*) from products where categoryId=1
            //var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count;
            //if (result >= 15)
            //{
            //    return new ErrorResult(Messages.ProductCountOfCategoryError);
            //}
            return new SuccessResult();
        }


        private IResult CheckIfCategoryLimitExceded()
        {
            var result = _carDal.GetAll();
            if (result.Count > 15)
            {
                return new ErrorResult(Messages.LimitExceded);
            }

            return new SuccessResult();
        }

    }
}

