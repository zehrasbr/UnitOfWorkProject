using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.DataAccessLayer.UnitOfWork.Abstract
{
    public interface IUowDal
    {
        void Save();
    }
}
