using OP_Sem3_Lab2_ABOBA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void BonusHandler();
public abstract class Employee : IDisposable, IBonus
{
    protected bool disposed = false;
    public int salary;
    protected int id;
    protected string name;
    protected List<string> currTasks;
    public bool isWorkingOvertime;
    public event BonusHandler bh;
    public int ID
    {
        get { return id; }
    }

    public string Name
    {
        get { return name; }
    }

    public List<string> GetCurrTasks
    {
        get { return currTasks; }
    }

    public string AddTask
    {
        set 
        {
            if(value != null || value != string.Empty || value.Length < 5)
            {
                currTasks.Add(value);
            }
        }
    }

    public void Dispose()
    {
        Console.WriteLine("Видалення за допомогою методу.");
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
        currTasks = new List<string>();
        this.bh += () => Console.WriteLine("Bonus handler");
        this.isWorkingOvertime = false;
    }

    public Employee()
    {
        this.id=0;
        this.name = "Працівник";
        currTasks = new List<string>();
        this.bh += () => Console.WriteLine("Bonus handler");
        this.isWorkingOvertime = false;
    }

    public virtual void Work()
    {
        if(this.isWorkingOvertime)
        {
            throw new CustomException(new CustomExEventArgs(this));
        }
        Console.WriteLine($"{this.GetType()} {this.Name}, id: {this.ID} починає працювати...");
        
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;
        if (disposing)
        {
            this.id = 0;
            this.name= string.Empty;
            this.currTasks = null;
        }
        disposed = true;
    }
    Func<List<string>, string> getRemoveTask = (List<string> tasks) =>
    {
        string res = tasks[0];
        tasks.RemoveAt(0);
        return res;
    };
    public event EventHandler<CustomExEventArgs>? error;
    void IBonus.GetBonus()
    {
        bonusMessage(this);
    }
    Action<Employee> bonusMessage = (Employee employee) => Console.WriteLine($"Employee {employee.Name} has got a bonus!");
    static Employee()
    {
        Console.WriteLine("Першого прцівника створено, спрацював статичний конструктор!");
    }

    ~Employee() 
    {
        Dispose(false);
        Console.WriteLine("Працює деструктор.");
    }
}
public static class Workaholic
{
    public static void workOvertime(this Employee e)
    {
        e.isWorkingOvertime = true;
        Console.WriteLine($"{e.Name} {e.ID} is working overtime!");
    }
}
