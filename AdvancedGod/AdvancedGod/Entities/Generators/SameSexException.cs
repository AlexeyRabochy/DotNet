using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedGod.Entities.Generators
{
    [Serializable()]
    internal class SameSexException : InvalidOperationException
    {
        private static string CreateMessage(Human parent, Human anotherParent)
        {
            return $"У {parent.Name} и {anotherParent.Name} одинаковый пол!";
        }
        public SameSexException(Human parent, Human anotherParent) : base(CreateMessage(parent, anotherParent)) { }
    }
}
