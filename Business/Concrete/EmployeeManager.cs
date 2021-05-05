using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrate
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void Add(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(),employee);
            _employeeDal.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public List<Employee> NameSearch(string employeeName)
        {
            return _employeeDal.GetAll(p => p.Adı.ToLower().Contains(employeeName.ToLower()));
        }

        public void Update(Employee employee)
        {
            ValidationTool.Validate(new EmployeeValidator(), employee);
            _employeeDal.Update(employee);
        }
    }
}
