using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_4._2
{
    internal interface IBeddingBuilder
    {
        void AddPillowcase();
        void AddSheet();
        void AddCover();
        BeddingKit GetBeddingKit();
    }
}
