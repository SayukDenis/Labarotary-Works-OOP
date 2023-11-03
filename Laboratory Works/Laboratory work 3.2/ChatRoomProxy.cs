using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3._2
{
    internal class ChatRoomProxy : IChatRoom
    {
        private ChatRoom chatRoom;

        public ChatRoomProxy(int maxUsers)
        {
            chatRoom = new ChatRoom(maxUsers, this);
        }

        public void UserJoin(User member)
        {
            if (chatRoom.GetCountUsers() < chatRoom.MaxUsers)
            {
                chatRoom.UserJoin(member);
                Console.WriteLine($"{member.Username} has joined the chat.");
            }
            else
            {
                Console.WriteLine($"{member.Username} cannot join the chat. Maximum users reached.");
            }
        }

        public void UserLeave(User member)
        {
            chatRoom.UserLeave(member);
        }

        public void SendMessage(User member, string message)
        {
            chatRoom.SendMessage(member, message);
        }
    }
}
