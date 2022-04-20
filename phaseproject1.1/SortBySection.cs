using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseProject1
{
    internal class SortBySection: IComparer<Teacher>
    {
        int IComparer<Teacher>.Compare(Teacher x, Teacher y)
        {
            return x.Section.CompareTo(y.Section);
        }
    }
}
