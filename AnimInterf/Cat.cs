using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimInterf
{
    public class Cat : Animal
    {
        public override string Sound()
        {
            return "Miau";
        }

        public string NumberOfNipples()
        {
            return "8";
        }

    }
}