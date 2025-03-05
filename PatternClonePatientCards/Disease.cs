using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    internal class Disease: ICloneable // Болезнь является частью диагноза не наследуется создается через New
    {
        internal string Name { get; set; }
        internal string Description { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
