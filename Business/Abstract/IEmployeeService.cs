using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> NameSearch(string employeeName);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
        

    }
}
