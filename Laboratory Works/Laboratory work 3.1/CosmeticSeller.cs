using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_3._1
{
    abstract class CosmeticSeller
    {
        protected string sellerName;

        public CosmeticSeller(string name)
        {
            this.sellerName = name;
        }
        public abstract void Sell();
    }
}
