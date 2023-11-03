using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CustomException : Exception
{
    public CustomException(CustomExEventArgs ea) : base(ea.ToString()) { }

}

public class CustomExEventArgs : EventArgs
{
    public Employee employee { get; set; }
    public CustomExEventArgs(Employee employee)
    {
        this.employee = employee;
    }
    public override string ToString()
    {
        string info = $"Працівник {employee.GetType()} {employee.Name}, id: {employee.ID} працює понаднормово!";
        return info;
    }
}
