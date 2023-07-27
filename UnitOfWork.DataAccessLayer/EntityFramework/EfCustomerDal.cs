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
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }

    }
}
