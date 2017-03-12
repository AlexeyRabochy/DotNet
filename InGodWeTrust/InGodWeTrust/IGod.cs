using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InGodWeTrust.Entities;

namespace InGodWeTrust
{
    internal interface IGod
    {
        Human CreateHuman();
        Human CreateHuman(Gender sex);
        Human CreatePair(Human human);
    }
}
