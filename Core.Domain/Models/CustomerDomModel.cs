using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Models
{
    public class CustomerDomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
    }
}
