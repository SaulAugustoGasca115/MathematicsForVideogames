﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLine
{
    [Header("Test Line")]
    RecreateCoordinates A;
    RecreateCoordinates B;
    RecreateCoordinates v;

    public enum LINETYPE
    {
        LINE,
        SEGMENT,
        RAY
    };

    LINETYPE type;

    public TestLine(RecreateCoordinates A, RecreateCoordinates B, LINETYPE type)
    {
        this.A = A;
        this.B = B;
        this.type = type;
        v = new RecreateCoordinates(B.x - A.x,B.y - A.y,B.z - A.z);
    }

    public TestLine(RecreateCoordinates A,RecreateCoordinates V)
    {
        this.A = A;
        B = A + V;
        this.v = V;
    }

    public RecreateCoordinates GetPointAt(float t)
    {

        if(type == LINETYPE.SEGMENT)
        {
            t = Mathf.Clamp(t,0,1);

        }else if(type == LINETYPE.RAY && t < 0)
        {
            t = 0;
        }

        float xt = A.x + v.x * t;
        float yt = A.y + v.y * t;
        float zt = A.z + v.z * t;

        return new RecreateCoordinates(xt,yt,zt);
    }

    public RecreateCoordinates Lerp(float t)
    {
        if(type == LINETYPE.SEGMENT)
        {
            t = Mathf.Clamp(t, 0, 1);

        }else if(type == LINETYPE.RAY && t < 0)
        {
            t = 0;
        }

        float xt = A.x + v.x * t;
        float yt = A.y + v.y * t;
        float zt = A.z + v.y * t;

        return new RecreateCoordinates(xt,yt,zt);
    }
}
