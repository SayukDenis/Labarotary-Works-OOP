namespace Laboratory_work_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ChatRoomProxy chatRoom = new ChatRoomProxy(3);

            User user1 = new User("Alice");
            User user2 = new User("Bob");
            User user3 = new User("Charlie");
            User user4 = new User("Diana");

            chatRoom.UserJoin(user1); 
            chatRoom.UserJoin(user2); 
            chatRoom.UserJoin(user3); 

            chatRoom.SendMessage(user1, "Hello, everyone!");
            chatRoom.SendMessage(user2, "Hi Alice and Charlie!");
            chatRoom.SendMessage(user3, "Welcome, Bob!");

            chatRoom.UserJoin(user4); 

   
            chatRoom.UserLeave(user2);
        }
    }
}