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
   public class ColorManager:IColorService
   {
       private IColorDal _colorDal;

       public ColorManager(IColorDal colorDal)
       {
           _colorDal = colorDal;
       }

       public void Add(Color color)
        {
           _colorDal.Add(color);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }

        public void Delete(int colorId)
        {
            _colorDal.Delete(_colorDal.Get(p=>p.Id==colorId));
        }

        public List<Color> GetAllColors()
        {
            return _colorDal.GetAll();
        }

        public Color GetColorId(int colorId)
        {
            return _colorDal.Get(p => p.Id == colorId);
        }
    }
}
