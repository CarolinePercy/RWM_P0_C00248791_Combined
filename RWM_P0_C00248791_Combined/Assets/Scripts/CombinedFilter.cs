using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinedFilter : MonoBehaviour
{
    public static int[] combinedFilter(int[] xs)
    {
        return ModO3.Module3(DecrementiflessthanfirstFilter.cubes(xs));
    }
}
