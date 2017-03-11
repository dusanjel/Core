using Core.Domain.Interfaces;
using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Services
{
    public class CustomerDomService : ICustomerDomService
    {
        public CustomerDomModel getCustomer()
        {
            return new CustomerDomModel()
            {
                Id = 1,
                Name = "Dusan",
                LastName = "Jelic",
                Adress = "No number",
                Phone = "23456654"
            };
        }
    }
}
