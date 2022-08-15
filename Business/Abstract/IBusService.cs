using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBusService
    {
        List<Bus> GetAll();
        List<Bus> GetAllByColorName(string colorName);
    }
}
