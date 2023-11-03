using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3._2
{
    internal interface IChatRoom
    {
        void UserJoin(User member);
        void UserLeave(User member);
        void SendMessage(User member, string message);
    }
}
