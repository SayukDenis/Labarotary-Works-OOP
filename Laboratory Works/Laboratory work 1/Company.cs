using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Sem3_Lab2_ABOBA
{
    internal class Company
    {
        public List<Employee> employees;
        public delegate void EmployeeDelegate(Employee e);
        public Company(CompanyOwner owner, List<Employee> employees)
        {
            this.employees = employees;
            InitializeCompany(owner);
        }
        public void InitializeCompany(CompanyOwner owner)
        {
            foreach (Employee e in employees) 
            {
                owner.WorkingEvent += delegate() { e.Work(); };
            }
        }
    }
}
