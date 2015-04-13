using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gh.DataAccessUtilities.IRepositories
{
    public interface IInsertRepository<T>

        where T : class
    {

        void Add(T entity);

    }
}
