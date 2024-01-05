using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User:BaseEntity
    {
        
        public string LastName { get; set; }
        public string NationalityNumber { get; set; }
        public string BirthDate { get; set; }
    }
}
