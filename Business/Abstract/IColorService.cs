using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(int colorId);
        List<Color> GetAllColors();
        Color GetColorId(int colorId);
    }
}
