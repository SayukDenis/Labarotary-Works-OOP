using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3._1
{
    internal class GroupManager : CosmeticSeller
    {
        private List<CosmeticSeller> members = new List<CosmeticSeller>();

        public GroupManager(string name) : base(name) { }

        public void AddMember(CosmeticSeller member)
        {
            members.Add(member);
        }

        public override void Sell()
        {
            Console.WriteLine($"Group manager {sellerName} sells cosmetics.");
            foreach (var member in members)
            {
                member.Sell();
            }
        }
    }
}
