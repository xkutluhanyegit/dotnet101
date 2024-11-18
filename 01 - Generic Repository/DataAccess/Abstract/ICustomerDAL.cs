using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete.Northwind;

namespace DataAccess.Abstract
{
    public interface ICustomerDAL:IEntityRepository<Customer>
    {
        
    }
}