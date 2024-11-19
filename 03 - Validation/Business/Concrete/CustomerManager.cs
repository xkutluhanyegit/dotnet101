using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Northwind;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _customerDal;
        public CustomerManager(ICustomerDAL customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer entity)
        {
            _customerDal.Add(entity);
            return new SuccessResult(Messages.AddSuccess);
        }

        public IResult Delete(Customer entity)
        {
            _customerDal.Delete(entity);
            return new SuccessResult(Messages.DeleteSuccess);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var  result = _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(result,Messages.ListedSuccess);
        }

        public IDataResult<Customer> GetById(int id)
        {
            var result = _customerDal.Get(x=>x.CustomerId == Convert.ToString(id));
            return new SuccessDataResult<Customer>(result,Messages.GetByIdSuccess);

        }

        public IResult Update(Customer entity)
        {
            _customerDal.Update(entity);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}