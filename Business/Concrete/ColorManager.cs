using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorService;
        public ColorManager(IColorDal colorDal)
        {
            _colorService = colorDal;
        }
        public List<Color> GetAll()
        {
            return _colorService.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorService.Get(c => c.ColorId == colorId);
        }
    }
}
