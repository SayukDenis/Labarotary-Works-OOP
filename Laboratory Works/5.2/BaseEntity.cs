using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class BaseEntity
    {
        public string Identifier;
        protected IConnector _connector;

        public BaseEntity(IConnector connector = null, string id = "_")
        {
            this._connector = connector;
            this.Identifier = id;
        }

        public void SetConnector(IConnector connector)
        {
            this._connector = connector;
        }
    }
}
