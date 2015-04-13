using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gh.DataAccessUtilities.IRepositories
{
    public interface IReadRepository<T>

        where T : class
    {

        IQueryable<T> FindAll();

        T FindById(params object[] id);

    }
}
