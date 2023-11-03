using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3._2
{
    internal class ChatRoom : IChatRoom
    {
        private List<User> users = new List<User>();
        private int maxUsers;
        private ChatRoomProxy proxy;

        public int MaxUsers
        {
            get { return maxUsers; }
        }

        public int GetCountUsers()
        {
            return users.Count;
        }

        public ChatRoom(int maxUsers, ChatRoomProxy proxy)
        {
            this.maxUsers = maxUsers;
            this.proxy = proxy;
        }

        public void UserJoin(User member)
        {
            users.Add(member);
        }

        public void UserLeave(User member)
        {
            users.Remove(member);
            Console.WriteLine($"{member.Username} has left the chat.");
        }

        public void SendMessage(User member, string message)
        {
            Console.WriteLine($"{member.Username} says: {message}");
        }
    }
}
