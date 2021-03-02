using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface ICarImageService
    {
        IResult Add(CarImage carImage);
        IResult Update(CarImage carImage);
        IResult Delete(int carImageId);
        IDataResult<List<CarImage>> GetAllCars();
        IDataResult<CarImage> GetCarId(int carImageId);
    }
}
