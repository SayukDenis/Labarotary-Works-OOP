using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Technician : Common
{
    public Technician(int id, string name, int headId) : base(id, name, headId)
    {

    }
    public Technician() { }
    public override void Work()
    {
        base.Work();
        Console.WriteLine("Займається своїми технічними справами...");
    }
}
