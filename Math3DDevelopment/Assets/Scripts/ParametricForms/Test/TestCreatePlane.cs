using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCreatePlane : MonoBehaviour
{
    [Header("Test Create Plane")]
    public Transform A;
    public Transform B;
    public Transform C;
    TestPlane plane;
    public float s;
    public float t;

    private void Awake()
    {
        plane = new TestPlane(new RecreateCoordinates(A.position),new RecreateCoordinates(B.position),new RecreateCoordinates(C.position));
        for(s = 0f;s < 1; s += 0.1f)
        {
            for(t = 0f; t < 1; t += 0.1f)
            {
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = plane.Lerp(s,t).ConvertToVector();
                
            }
        }
    }
}
