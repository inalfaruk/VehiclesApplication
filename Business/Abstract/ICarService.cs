using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {

        
        List<Car> GetAll(); 
        List<Car> GetAllByColorName(string colorName);

        string DeleteByCarId(Car car);

        string HeadLightSwitch(int id, bool key);

        



       




    }
}
