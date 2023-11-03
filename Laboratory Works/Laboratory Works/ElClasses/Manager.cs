using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Manager : Senior
{
    public Manager(int id, string name, List<int> subordinatesID) : base(id, name, subordinatesID)
    {

    }
    public Manager() { }
    public override void Work()
    {
        base.Work();
        Console.WriteLine("Займається своїми менеджерськими справами...");
    }
}
