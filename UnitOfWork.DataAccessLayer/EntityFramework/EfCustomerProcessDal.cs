using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccessLayer.Abstract;
using UnitOfWork.DataAccessLayer.Concrete;
using UnitOfWork.DataAccessLayer.Repositories;
using UnitOfWork.EntityLayer.Concrete;

namespace UnitOfWork.DataAccessLayer.EntityFramework
{
    public class EfCustomerProcessDal : GenericRepository<CustomerProcess>, ICustomerProcessDal
    {
        public EfCustomerProcessDal(Context context) : base(context)
        {
        }
    }
}
