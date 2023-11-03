using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Common : Employee
{
    private int headID;

    public int HeadID
    {
        get { return headID; }
    }

    public Common(int id, string name, int headID):base(id, name)
    {
        this.headID = headID;
    }

    public Common():base()
    {
        headID = 0;
    }
}
