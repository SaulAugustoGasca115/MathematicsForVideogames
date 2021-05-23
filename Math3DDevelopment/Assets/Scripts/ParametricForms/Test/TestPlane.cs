using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlane
{

    [Header("Test Plane")]
    public RecreateCoordinates A;
    RecreateCoordinates B;
    RecreateCoordinates C;
    RecreateCoordinates v;
    RecreateCoordinates u;
    public float s;
    public float t;

    public TestPlane(RecreateCoordinates A, RecreateCoordinates B, RecreateCoordinates C)
    {
        this.A = A;
        this.B = B;
        this.C = C;
        this.v = B - A;
        this.u = C - A;
    }

    public TestPlane(RecreateCoordinates A,Vector3 V,Vector3 U)
    {
        this.A = A;
        this.v = new RecreateCoordinates(V.x,V.y,V.z);
        this.u = new RecreateCoordinates(U.x,U.y,U.z);
    }

    public RecreateCoordinates Lerp(float s,float t)
    {
        float xst = A.x + v.x * s + u.x * t;
        float yst = A.y + v.y * s + u.y * t;
        float zst = A.z + v.z * s + u.z * t;

        return new RecreateCoordinates(xst,yst,zst);
    }

}
