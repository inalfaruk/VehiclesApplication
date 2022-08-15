using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BusDal : IBusDal
    {
        List<Bus> _buses;

        public BusDal()
        {
            _buses = new List<Bus>
            {
                new Bus{ColorName="red",},
                new Bus{ColorName="black"},         
                new Bus{ColorName="blue"},

            };
        }
 
        public List<Bus> GetAll()
        {
            return _buses;
        }

           
       
    }
}
