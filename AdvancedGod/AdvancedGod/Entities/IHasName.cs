using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedGod.Entities
{
    public interface IHasName : IPrintableToConsole
    {
        string Name { get; }
    }
}
