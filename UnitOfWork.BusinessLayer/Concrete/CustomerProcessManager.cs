using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.BusinessLayer.Abstract;
using UnitOfWork.DataAccessLayer.Abstract;
using UnitOfWork.DataAccessLayer.EntityFramework;
using UnitOfWork.DataAccessLayer.UnitOfWork.Abstract;
using UnitOfWork.EntityLayer.Concrete;

namespace UnitOfWork.BusinessLayer.Concrete
{
    public class CustomerProcessManager : ICustomerProcessService
    {
        private readonly ICustomerProcessDal _customerProcessDal;
        private readonly IUowDal _uowDal;

        public CustomerProcessManager(IUowDal uowDal, ICustomerProcessDal customerProcessDal)
        {
            _uowDal = uowDal;
            _customerProcessDal = customerProcessDal;
        }

        public void TDelete(CustomerProcess t)
        {
            _customerProcessDal.Delete(t);
            _uowDal.Save();
        }

        public CustomerProcess TGetByID(int id)
        {
            return _customerProcessDal.GetByID(id);
        }

        public List<CustomerProcess> TGetList()
        {
            return _customerProcessDal.GetList();
        }

        public void TInsert(CustomerProcess t)
        {
            _customerProcessDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<CustomerProcess> t)
        {
            _customerProcessDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(CustomerProcess t)
        {
            _customerProcessDal.Update(t);
            _uowDal.Save();
        }
    }
}
