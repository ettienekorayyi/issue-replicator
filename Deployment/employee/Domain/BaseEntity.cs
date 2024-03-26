using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class BaseEntity
    {
        protected BaseEntity(int Id)
        {
            this.Id = Id;
        }
        
        public int Id { get; private set; }
    }
}