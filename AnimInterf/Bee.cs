using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimInterf
{
   public class Bee : Animal
    {
        public override string Sound()
        {
            return base.Sound() + "bzzzz";
        }

        public int NumberOfWings { get { return 4; } }

    }
}