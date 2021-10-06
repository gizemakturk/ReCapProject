using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

         public IDataResult<List<Brand>> GetAll()
        {//iş kodları
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }
        public IDataResult<List<Brand>> GetByBrandId(int Id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(x => x.BrandId == Id));
        }
    }
}
