using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseProject1
{
     public class SortByLastName : IComparer<Teacher>
    {
        int IComparer<Teacher>.Compare(Teacher x, Teacher y)
        {
            return x.LastName.CompareTo(y.LastName);
        }

    }
}
