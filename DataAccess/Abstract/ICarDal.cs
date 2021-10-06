using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //DAl(c) dao (java)
    public  interface ICarDal:IEntityRepository<Car>
    {
        
        List<CarDetailDto> GetCarDetails();
    }
}
