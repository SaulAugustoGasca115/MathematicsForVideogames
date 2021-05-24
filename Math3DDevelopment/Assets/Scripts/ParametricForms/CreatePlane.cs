﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlane : MonoBehaviour
{
    [Header("Create a Plane")]
    public Transform A;
    public Transform B;
    public Transform C;
    Plane plane;

    // Start is called before the first frame update
    void Awake()
    {
        plane = new Plane(new RecreateCoordinates(A.position),new RecreateCoordinates(B.position),new RecreateCoordinates(C.position));
        for(float s=0;s < 1;s += 0.1f)
        {
            for(float t = 0;t < 1; t += 0.1f)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = plane.Lerp(s,t).ConvertToVector();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}