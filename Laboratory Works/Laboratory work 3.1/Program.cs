namespace Laboratory_work_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreSeller storeSeller1 = new StoreSeller("Store A");
            StoreSeller storeSeller2 = new StoreSeller("Store B");
            StoreSeller storeSeller3 = new StoreSeller("Store C");
            GroupManager groupManager = new GroupManager("Main Group");
            groupManager.AddMember(storeSeller1);
            groupManager.AddMember(storeSeller2);
            groupManager.AddMember(storeSeller3);
            groupManager.Sell();
        }



    }
}