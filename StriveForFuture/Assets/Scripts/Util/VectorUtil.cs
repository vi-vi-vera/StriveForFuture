using System;
using System.Collections.Generic;
using UnityEngine;

class VectorUtil
{
    public static float Distance(Vector3 v1, Vector3 v2)
    {
        return (v1 - v2).magnitude;
    }
}
