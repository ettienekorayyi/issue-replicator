using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Employee : BaseEntity
    {
        /**/
        public Employee(Guid id) : base(id)
        {
            
        }
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}