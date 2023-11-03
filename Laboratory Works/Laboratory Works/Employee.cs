using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Employee : IDisposable
{
    protected bool disposed = false;

    protected int id;
    protected string name;
    protected List<string> currTasks;

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
    }

    public Employee():this(0)
    {
        this.name = "Працівник";
        currTasks = new List<string>();
    }

    public virtual void Work()
    {
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
    private Employee(int id)
    {
        this.id = id;
    }
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
