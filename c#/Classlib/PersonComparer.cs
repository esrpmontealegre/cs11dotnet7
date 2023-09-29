using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class.Shared;

public class PersonComparer : IComparer<Person?>
{
    public int Compare(Person? x, Person? y)
    {
        int posn=0;

        if((x is not null) && (y is not null))
        {
            if((x.Name is not null) && (y.Name is not null))
            {
                int result = x.Name.Length.CompareTo(y.Name.Length);
                if (result == 0)
                {
                    return x.Name.CompareTo(y.Name);
                }
                else
                {
                    posn = result;
                }
            }
            else if ((x.Name is not null) && (y.Name is null))
            {
                posn = -1;
            }
            else if ((x.Name is null) && (y.Name is not null))
            {
                posn = 1;
            }
            else
            {
                posn = 0;
            }
        }

        return posn;

    }
}
