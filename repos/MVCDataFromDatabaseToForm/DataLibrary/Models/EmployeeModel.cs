using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailAddress { get; set; }
    }
}
