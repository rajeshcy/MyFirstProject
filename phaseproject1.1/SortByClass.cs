using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseProject1
{
    public class SortByCclass : IComparer<Teacher>
    {
        int IComparer<Teacher>.Compare(Teacher x, Teacher y)
        {
            return x.Cclass.CompareTo(y.Cclass);
        }
    }
}
