using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;

namespace Service
{
   public class BaseService: IDisposable
    {
    readonly IUnitOfWork _unitOfWork;

        public BaseService(IUnitOfWork unitOfWork)
        {
            if (null == unitOfWork)
            {
                throw new ArgumentException("unitOfWork");
            }
            _unitOfWork = unitOfWork;
        }
        public int SaveChanges()
        {
            return _unitOfWork.SaveChanges();
        }
        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
