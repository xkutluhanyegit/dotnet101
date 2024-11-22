using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validaation;
using Core.CrossCuttingConcerns.Validation;
using Entities.Concrete.Northwind;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UI.Controllers
{
    
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(ILogger<CustomerController> logger,ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        
        public async Task<IActionResult> Index(int page = 1)
        {
            
            return View();
        }



        
       
        public async Task<IActionResult> Add(Customer customer)
        {
            try
            {
                var result = await _customerService.Add(customer);
                if (result.Success)
                {
                    return View();
                }
            }
            catch (ValidationException ex)
            {
                
                
            }
            
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}