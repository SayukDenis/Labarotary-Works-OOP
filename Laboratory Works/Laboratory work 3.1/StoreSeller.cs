using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3._1
{
    internal class StoreSeller : CosmeticSeller
    {
        public StoreSeller(string name) : base(name) { }

        public override void Sell()
        {
            Console.WriteLine($"Store seller {sellerName} sells cosmetics.");
        }
    }
}
