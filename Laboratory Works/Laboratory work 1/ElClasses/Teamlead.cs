using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Teamlead : Senior
{
    public Teamlead(int id, string name, List<int> subordinatesID) : base(id, name, subordinatesID)
    {

    }
    public override void Work()
    {
        base.Work();
        Console.WriteLine("Займається своїми тімлідськими справами...");
    }
}
