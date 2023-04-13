using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace DAO
{
    public interface DAOInterface
    {
        Task<bool> Insert(Produto produto);
        Task<bool> Alter(Produto produto);
        Task<bool> Remove(int ID);
        Task<IEnumerable<Produto>> Select();
        Task<Produto> SelectID(int ID);
    }
}
