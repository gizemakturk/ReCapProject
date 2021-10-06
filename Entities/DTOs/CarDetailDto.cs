using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public String CarName { get; set; }
        public String BrandName { get; set; }
        public String ColorName { get; set; }
        public int DailyPrice { get; set; }
    }
}
