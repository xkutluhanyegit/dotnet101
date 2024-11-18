using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Northwind;
using Entities.Concrete.Northwind;

namespace DataAccess.Concrete.Entityframework.Northwind
{
    public class EfCustomerDAL:EfEntityRepositoryBase<NorthwindContext,Customer>,ICustomerDAL
    {
        
    }
}