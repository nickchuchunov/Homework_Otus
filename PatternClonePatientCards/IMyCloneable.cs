using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternClonePatientCards
{
    public interface IMyCloneable <T>
    {
       public T MuCloneClass();
    }
}
