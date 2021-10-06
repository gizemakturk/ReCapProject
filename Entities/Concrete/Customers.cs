using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    class Customers:Users,IEntity
    {
        public string CompanyName { get; set; }
        

    }
}
