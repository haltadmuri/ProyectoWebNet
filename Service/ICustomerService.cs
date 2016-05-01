using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ICustomerService<C> : IDisposable
    {
        C Insert(C instancia);
        int Edit(C instancia);
        int Delete(C instancia);
        IEnumerable<C> GetList(string nombre);
        C Get(int Identity);
    }
}
