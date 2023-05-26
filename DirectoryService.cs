using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementApp
{
    public class DirectoryService : IDirectory
    {
        private readonly List<Directory> _directories;
        public DirectoryService()
        {
            _directories = new List<Directory> { };
        }
        public void Add(Directory item)
        {
            _directories.Add(item);
        }

        public void Delete(Directory item)
        {
            _directories.Remove(item);
        }

        public void Update(Directory item)
        {
            var updated = _directories.FirstOrDefault(i => i.RecordId == i.RecordId);
            updated.FirstName = item.FirstName;
            updated.LastName = item.LastName;
            updated.Number = item.Number;
        }

        public void GetList()
        {
            var list = _directories.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"\n{item.FirstName}, {item.LastName}, {item.Number}");
            }
        }
    }

}
