using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringExtensions
{
    public static bool CustomEndsWith(this string a, string b)
    {
        int ap = a.Length - 1;
        int bp = b.Length - 1;
    
        while (ap >= 0 && bp >= 0 && a [ap] == b [bp])
        {
            ap--;
            bp--;
        }
    
        return (bp < 0);
    }

    public static bool CustomStartsWith(this string a, string b)
    {
        int aLen = a.Length;
        int bLen = b.Length;
    
        int ap = 0; int bp = 0;
    
        while (ap < aLen && bp < bLen && a [ap] == b [bp])
        {
            ap++;
            bp++;
        }
    
        return (bp == bLen);
    }
}