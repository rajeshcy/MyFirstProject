using System;
using System.Collections.Generic;


namespace PhaseProject1
{
    internal class SortByID : IComparer<Teacher>
    {
        int IComparer<Teacher>.Compare(Teacher x, Teacher y)
        {
            return int.Parse(x.ID).CompareTo(int.Parse((y.ID)));
        }
    }
}
