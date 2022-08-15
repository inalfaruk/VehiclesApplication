using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal :IRepository<Car>
    {



        void Delete(Car car);

        void HeadLightsSwitch(int id ,bool key);



    }
}
