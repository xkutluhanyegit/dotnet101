using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Concrete;
using Core.Utilities.Results.Abstract;
using Entities.Concrete.Northwind;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer entity);
        IResult Delete(Customer entity);
        IResult Update(Customer entity);
        IDataResult<Customer> GetById(int id);
        IDataResult<List<Customer>> GetAll();
        
    }
}