using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class BaseEntity
    {
        protected BaseEntity(Guid Id)
        {
            this.Id = Id;
        }
        
        public Guid Id { get; private set; }
    }
}