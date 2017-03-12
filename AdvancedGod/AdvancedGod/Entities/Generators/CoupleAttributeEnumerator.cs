using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AdvancedGod.Helpers;

namespace AdvancedGod.Entities.Generators
{
    public class CoupleAttributeEnumerator : IEnumerable<CoupleAttribute>
    {
        private readonly List<CoupleAttribute> _attributes;

        private CoupleAttributeEnumerator(List<CoupleAttribute> attributes)
        {
            _attributes = attributes;
        }


        public IEnumerator<CoupleAttribute> GetEnumerator()
        {
            return _attributes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static CoupleAttributeEnumerator CreateFor(Human human)
        {
            Throw.IfNull(human, nameof(human));
            return new CoupleAttributeEnumerator(Attribute.GetCustomAttributes(human.GetType()).ToList().ConvertAll(attr => attr as CoupleAttribute));
        }
    }
}
