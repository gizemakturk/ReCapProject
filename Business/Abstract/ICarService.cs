using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult <List<Car>> GetAll();
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<Car>>GetByDailyPrice(int min, int max);
        IDataResult<List<CarDetailDto>> GetCarDetailIs();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
       

    }
}
