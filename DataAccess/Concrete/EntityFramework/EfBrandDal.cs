using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : Core.DataAccess.EntityFramework.EfEntityRepostioryBase<Brand, RentACarProjectContext>,  IBrandDal
    {
       
    }
}
