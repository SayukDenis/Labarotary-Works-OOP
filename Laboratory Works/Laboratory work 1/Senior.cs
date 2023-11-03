using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Senior : Employee
{
    private List<int> subordinatesID;

    public List<int> GetSubordinatesID
    {
        get { return subordinatesID; }
    }

    public int AddSubordinateID
    {
        set
        {
            if(value <= 0)
            {
                subordinatesID.Add(value);
            }
        }
    }

    public Senior(int id, string name, List<int> subordinatesID):base(id, name)
    {
        if(subordinatesID == null)
        {
            subordinatesID = new List<int>();
        }
        else
        {
            this.subordinatesID = subordinatesID;
        }
    }

    public Senior():base()
    {
        subordinatesID=new List<int>();
    }
}
