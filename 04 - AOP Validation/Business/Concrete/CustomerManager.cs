using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constant;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validaation;
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

        [ValidationAspect(typeof(CustomerValidator))]
        public async Task<IResult> Add(Customer entity)
        {
            await _customerDal.AddAsync(entity);
            return new SuccessResult(Messages.AddSuccess);
        }

        public async Task<IResult> Delete(Customer entity)
        {
            await _customerDal.Delete(entity);
            return new SuccessResult(Messages.DeleteSuccess);
        }

        public async Task<IDataResult<List<Customer>>> GetAll()
        {
            var result = await _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(result,Messages.ListedSuccess);
        }

        public async Task<IDataResult<Customer>> GetById(int id)
        {
            var result = await _customerDal.Get(p=> p.CustomerId == id.ToString());
            return new SuccessDataResult<Customer>(result,Messages.GetByIdSuccess);
        }

        public async Task<IResult> Update(Customer entity)
        {
            await _customerDal.Update(entity);
            return new SuccessResult(Messages.UpdateSuccess);
        }
    }
}