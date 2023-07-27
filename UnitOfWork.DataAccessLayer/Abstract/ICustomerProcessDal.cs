using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EntityLayer.Concrete;

namespace UnitOfWork.DataAccessLayer.Abstract
{
    public interface ICustomerProcessDal : IGenericDal<CustomerProcess>
    {
    }
}
