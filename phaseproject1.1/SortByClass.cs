using System;
using System.Collections.Generic;


namespace PhaseProject1
{
    public class SortByCclass : IComparer<Teacher>
    {
        int IComparer<Teacher>.Compare(Teacher x, Teacher y)
        {
            return int.Parse(x.Cclass).CompareTo(int.Parse((y.Cclass)));
        }
    }
}
