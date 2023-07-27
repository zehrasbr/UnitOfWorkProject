using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccessLayer.Concrete;
using UnitOfWork.DataAccessLayer.UnitOfWork.Abstract;

namespace UnitOfWork.DataAccessLayer.UnitOfWork.Concrete
{
    public class UowDal : IUowDal
    {
        private readonly Context _context;

        public UowDal(Context context)
        {
            _context = context;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
