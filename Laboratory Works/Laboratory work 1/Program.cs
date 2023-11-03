using OP_Sem3_Lab2_ABOBA;
using System;
using System.Text;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        CompanyOwner owner = new CompanyOwner();
        List<Employee> employees = new List<Employee>();
        for (int i = 0; i < 9; i++)
        {
            string name = "Worker" + i.ToString();
            employees.Add(new Engineer(i, name, 0));
        }
        Company company = new Company(owner, employees);
        company.employees[1].isWorkingOvertime = true;
        owner.StartWorking();
        
    }
}