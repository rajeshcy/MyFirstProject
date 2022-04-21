using System;
using System.Collections.Generic;

namespace PhaseProject1
{
    public class SortByFirstName : IComparer<Teacher> 
    {
        int IComparer<Teacher>.Compare(Teacher x, Teacher y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    
    }
}
