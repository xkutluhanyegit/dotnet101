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
        Task<IResult> Add(Customer entity);
        Task<IResult> Delete(Customer entity);
        Task<IResult> Update(Customer entity);
        Task<IDataResult<Customer>> GetById(int id);
        Task<IDataResult<List<Customer>>> GetAll();
        
    }
}