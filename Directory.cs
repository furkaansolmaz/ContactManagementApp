using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementApp
{
    public class Directory
    {
        [Key]
        public int RecordId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }

    }
}
