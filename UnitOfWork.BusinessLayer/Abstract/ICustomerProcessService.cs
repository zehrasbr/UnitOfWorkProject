using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccessLayer.Abstract;
using UnitOfWork.EntityLayer.Concrete;

namespace UnitOfWork.BusinessLayer.Abstract
{
    public interface ICustomerProcessService : IGenericService<CustomerProcess>
    {
    }
}
