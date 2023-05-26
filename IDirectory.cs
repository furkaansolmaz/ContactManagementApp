using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementApp
{
    public interface IDirectory
    {
        void Add(Directory item);
        void Delete(Directory item);
        void Update(Directory item);
        void GetList();
    }
}
