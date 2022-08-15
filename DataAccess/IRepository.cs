using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepository<T> where T : class, new()
    {

        List<T> GetAll();

      

    }
}

