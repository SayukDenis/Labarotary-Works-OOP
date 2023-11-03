using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

internal class Engineer : Common
{
    public Engineer(int id, string name, int headId):base(id, name, headId)
    {
        
    }
    public override void Work()
    {
        base.Work();
        Console.WriteLine("Займається своїми інженерськими справами...");
    }
}
