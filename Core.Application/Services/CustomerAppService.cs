using Core.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Application.ViewModels;
using Core.Domain.Interfaces;

namespace Core.Application.Services
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerDomService custService;

        public CustomerAppService(ICustomerDomService custService)
        {
            this.custService = custService;
        }

        public CustomerAppViewModel getCustomer()
        {
            var customer = custService.getCustomer();
            
            return new CustomerAppViewModel()
            {
                Id = customer.Id,
                Name = customer.Name,
                LastName = customer.LastName,
                Adress = customer.Adress,
                Phone = customer.Phone
            };
        }
    }
}
