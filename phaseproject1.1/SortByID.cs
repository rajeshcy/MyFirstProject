using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseProject1
{
    internal class SortByID : IComparer<Teacher>
    {
        int IComparer<Teacher>.Compare(Teacher x, Teacher y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }
}
