using Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Interfaces
{
    public interface ICustomerDomService
    {
        CustomerDomModel getCustomer(); 
    }
}
