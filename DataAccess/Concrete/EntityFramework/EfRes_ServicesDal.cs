using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRes_ServicesDal : EfEntityRepositoryBase<Res_Services,HotelContext>,IRes_ServiceDal
    {
    }
}
