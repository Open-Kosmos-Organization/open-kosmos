﻿using System.Collections.Generic;

namespace Kosmos.Prototypes.Parts
{
    public static class Utils
    {
        //Extension method for IReadOnlyList
        public static int IndexOf<T>( this IReadOnlyList<T> self, T elementToFind )
        {
            int i = 0;
            foreach( T element in self )
            {
                if( Equals( element, elementToFind ) )
                    return i;
                i++;
            }
            return -1;
        }
    }
}