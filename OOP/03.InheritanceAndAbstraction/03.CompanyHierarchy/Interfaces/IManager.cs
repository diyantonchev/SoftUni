using Person.Employee;
using System.Collections.Generic;

namespace Interfaces
{
    interface IManager
    {
        ISet<Employee> Employees { get; set; }
    }
}
